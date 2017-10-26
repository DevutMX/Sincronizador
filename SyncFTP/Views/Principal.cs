using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using Newtonsoft.Json;
using SyncFTP.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;

namespace SyncFTP.Views
{
    public partial class Principal : XtraForm
    {
        public Principal()
        {
            InitializeComponent();

            ToStartup();
        }

        /// <summary>
        /// Objeto a nivel global que permite interactuar con los metodos de cifrado
        /// </summary>
        Secret _secret = new Secret();

        /// <summary>
        /// Objeto a nivel global que permite interactuar con el nucleo para hacer lectura y validaciones de los ajustes de los servidores
        /// </summary>
        Kernel _kernel = new Kernel();

        /// <summary>
        /// Objeto a nivel global que permite interactuar con los metodos de la base de datos
        /// </summary>
        Bridge _bridge = new Bridge();

        /// <summary>
        /// Objeto a nivel global que permite llamar notificaciones dentro de este formulario
        /// </summary>
        Notify _notify;

        /// <summary>
        /// Variable de nivel global que indica la direccion logica donde esta la carpeta con los archivos remotos
        /// </summary>
        private string _remoteFilesDirectory = Application.StartupPath + @"\RemoteFiles";

        /// <summary>
        /// Variable privada de nivel global que reinicia el contador de segundos por cada operacion
        /// </summary>
        private int _seconds = 0;

        private string _copyPath;

        private int _archivos = 0;

        #region Events

        /// <summary>
        /// Evento que se dispara justo despues de cargar la ventana del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Shown(object sender, EventArgs e)
        {
            ObtenerDispositivos();

            CargarHistorial();

            WindowState = FormWindowState.Minimized;

            if (CheckInternet())
            {
                BeginToSyncRemote();
            }

            else
            {
                BeginToSyncLocal();
            }
        }

        /// <summary>
        /// Metodo que al ser llamado verifica por medio de un ping si hay conexion a internet
        /// </summary>
        /// <returns>Retorna true cuando hay acceso internet</returns>
        private bool CheckInternet()
        {
            try
            {
                Ping _pinger = new Ping();

                PingReply _reply = _pinger.Send("www.google.com.mx");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Evento que se dispara cuando se hace clic en la imagen de ajustes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petSettings_Click(object sender, EventArgs e)//Revisar integridad
        {
            Bienvenido _settingsForm = new Bienvenido();

            Hide();

            _settingsForm.ShowDialog();

            Show();

            PromptSettings();
        }

        /// <summary>
        /// Evento que envia el formulario al icono de sistema en la barra de tareas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                _notify = new Notify("Minimizado", "SyncFTP está en segundo plano", 1);

                _notify.Show();

                nicSystemTray.Visible = true;
                Hide();
                ShowInTaskbar = false;
            }

            else if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                nicSystemTray.Visible = false;
            }
        }

        /// <summary>
        /// Evento de emergencia, donde al presionar F12 en el teclado, permite que reaparezcan forzosamente los botones play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.F12))
            {
                VisibleButtons(true);
            }
        }

        /// <summary>
        /// Evento que restaura el formulario cuando se hace doble click en la barra de tareas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nicSystemTray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        /// <summary>
        /// Cuando esta en la barra de tareas y se presiona salir, se pregunta para confirmar la acción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitSysTray_Click(object sender, EventArgs e)//Revisar inutilidad --
        {
            if (XtraMessageBox.Show(UserLookAndFeel.Default, "¿En verdad desea cerrar la aplicación?\nEsto detendrá todas las transferencias si no se han terminado dejando archivos corruptos", "Cerrar SyncFTP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Evento que inicia la sincronizacion remota desde la barra de tareas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartRemote_Click(object sender, EventArgs e)//Preguntar si desea continuar --
        {
            if (CheckInternet())
            {
                BeginToSyncRemote();
            }

            else
            {
                DialogResult f = XtraMessageBox.Show(UserLookAndFeel.Default, "No cuenta con conexión a internet, pero puede intentar en caso de que\n el servidor \"central\" este conectado de forma local.\n\n¿Desea continuar?", "SyncFTP - Sin conexión a internet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (f == DialogResult.Yes)
                {
                    BeginToSyncRemote();
                }
            }
        }

        /// <summary>
        /// Evento que inicia la sincronizacion local desde la barra de tareas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartLocal_Click(object sender, EventArgs e)//Preguntar si desea continuar --
        {
            if (!CheckInternet())
            {
                BeginToSyncLocal();
            }

            else
            {
                DialogResult f = XtraMessageBox.Show(UserLookAndFeel.Default, "Al estar conectado a internet SyncFTP da preferencia a conexiones con el servidor \"central\",\ncancelando acciones con el servidor \"replica\", pero aún así puede acceder a él, si este está accesible.\n\n¿Desea continuar?", "SyncFTP - Confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (f == DialogResult.Yes)
                {
                    BeginToSyncLocal();
                }
            }
        }

        /// <summary>
        /// Obtiene el listado de directorios desde el servidor remoto y almacena la informacion en unn JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoteTreeStrip_Click(object sender, EventArgs e)//Convertir progress a marquee //
        {
            if (XtraMessageBox.Show(UserLookAndFeel.Default, "Este proceso puede tardar mucho tiempo. ¿Deseas continuar?", "SyncFTP - Confirme petición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GetRemoteLists();
            }
        }

        /// <summary>
        /// Obtiene el listado de directorios desde el servidor local y almacena la informacion en unn JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocalTreeStrip_Click(object sender, EventArgs e)//Convertir progress a marquee //
        {
            if (XtraMessageBox.Show(UserLookAndFeel.Default, "Este proceso puede tardar mucho tiempo. ¿Deseas continuar?", "SyncFTP - Confirme petición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GetLocalLists();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Guarda el registro de la aplicacion en el registro de windows para iniciar junto a el
        /// </summary>
        private void ToStartup()
        {
            try
            {
                RegistryKey _key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                //_key.SetValue("SyncFTP", Application.ExecutablePath);

                if (_key != null)
                {
                    _key.DeleteValue("SyncFTP", false);
                    _key.SetValue("SyncFTP", Application.ExecutablePath);
                }

                else
                {
                    _key.SetValue("SyncFTP", Application.ExecutablePath);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Evalua si los ajustes de los servidores no estan vacios
        /// </summary>
        private void PromptSettings()
        {
            try
            {
                Servers _settings = _kernel.ReadSettings();

                if (_settings != null)
                {
                    if (_settings.Remote.Server == "")
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que no configuró el servidor \"central\"...\nSolo se revisarán ajustes del servidor replica.\nRecuerde que para configurar el servidor \"central\" necesitará contar\ncon conexión a internet.", "SyncFTP - Servidor central desconocido", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            Central _central = new Central();

                            _central.ShowDialog();
                        }
                    }

                    if (_settings.Local.Server == "")
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que no configuró el servidor \"replica\"...\nSolo se revisarán ajustes del servidor central.", "SyncFTP - Servidor replica desconocido", MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            Replica _central = new Replica();

                            _central.ShowDialog();
                        }
                    }
                }

                else
                {
                    if (XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que no ha configurado las conexiones a los servidores...\n\nPor favor, ingrese los datos del servidor que tenga disponible,\nrecuerde que para configurar el servidor \"central\" necesitará\ncontar con conexión a internet.\n\n¿Desea proseguir con las configuraciones?", "SyncFTP - Servidores sin definir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        petSettings_Click(null, null);
                    }

                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Permite restaurar u ocultar los botones de sincronizacion
        /// </summary>
        /// <param name="visible">True para habilitar los botones</param>
        private void VisibleButtons(bool visible)//Revisar emergencia --
        {
            if (visible)
            {
                _seconds = 0;
                _tmpElapsedTime.Enabled = !visible;
                lblElapsedTime.Visible = !visible;
                lblElapsedTime.Text = "";
                pbcProgress.Position = 0;
                gbcSincronizar.Visible = visible;
                btnStartRemoteStrip.Visible = visible;
                btnStartLocalStrip.Visible = visible;
                lblAvance.Text = "0% de 100% completado";
            }

            else
            {
                pbcProgress.Position = 0;
                _tmpElapsedTime.Enabled = !visible;
                lblElapsedTime.Visible = !visible;
                gbcSincronizar.Visible = visible;
                btnStartRemoteStrip.Visible = visible;
                btnStartLocalStrip.Visible = visible;
            }
        }

        /// <summary>
        /// Se procesa el directorio remoto completamente, pudiendo tardar demasiado - No recomendado su uso
        /// </summary>
        /// <param name="server">Datos de los servidores donde evalua el remoto</param>
        /// <returns>Devuelve una cadena de texto segun se halla completado el directorio o no</returns>
        public string ProcessingRemote(Servers server)
        {
            try
            {
                SessionOptions _client = _kernel.RemoteIsValid(server);

                if (_client != null)
                {
                    List<FullPath> _pathList = new List<FullPath>();

                    string _remotePathList = Application.StartupPath + @"\PathList\remote.json";

                    if (!File.Exists(_remotePathList))
                    {
                        using (File.Create(_remotePathList)) { }
                    }

                    using (Session _session = new Session())
                    {
                        _session.FileTransferProgress += FileTransferProgress;

                        _session.Open(_client);

                        //petStatus.Invoke(new Action(() => petStatus.Image = Properties.Resources.SyncBusy));

                        IEnumerable<RemoteFileInfo> _fileInfos = _session.EnumerateRemoteFiles(_secret.Decrypt(server.Remote.Find), null, EnumerationOptions.EnumerateDirectories | EnumerationOptions.AllDirectories);

                        foreach (RemoteFileInfo _fileInfo in _fileInfos)
                        {
                            DirectoryStructure _dirStructure = new DirectoryStructure
                            {
                                FilePermissions = _fileInfo.FilePermissions.ToString(),
                                FileType = _fileInfo.FileType,
                                FullName = _fileInfo.FullName,
                                Group = _fileInfo.Group,
                                IsDirectory = _fileInfo.IsDirectory,
                                IsParentDirectory = _fileInfo.IsParentDirectory,
                                IsThisDirectory = _fileInfo.IsThisDirectory,
                                LastWriteTime = _fileInfo.LastWriteTime,
                                Length = _fileInfo.Length,
                                Length32 = _fileInfo.Length32,
                                Name = _fileInfo.Name,
                                Owner = _fileInfo.Owner
                            };

                            //lblNotifications.Invoke(new Action(() => lblNotifications.Text = "R - Obteniendo... " + _fileInfo.Name));

                            _pathList.Add(new FullPath { PathStructure = _dirStructure });
                        }

                        string _data = JsonConvert.SerializeObject(_pathList, Formatting.Indented);

                        File.WriteAllText(_remotePathList, _data);
                    }

                    return "Se creo el directorio del servidor central exitosamente";
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x001)", "Error al obtener directorios", 3);

                _notify.Show();

                return null;
            }
        }

        /// <summary>
        /// Se procesa el directorio local completamente, pudiendo tardar demasiado - No recomendado su uso
        /// </summary>
        /// <param name="server">Datos de los servidores donde evalua el local</param>
        /// <returns>Devuelve una cadena de texto segun se halla completado el directorio o no</returns>
        public string ProcessingLocal(Servers server)
        {
            try
            {
                SessionOptions _client = _kernel.LocalIsValid(server);

                if (_client != null)
                {
                    List<FullPath> _pathList = new List<FullPath>();

                    string _localPathList = Application.StartupPath + @"\PathList\local.json";

                    if (!File.Exists(_localPathList))
                    {
                        using (File.Create(_localPathList)) { }
                    }

                    using (Session _session = new Session())
                    {
                        _session.Open(_client);

                        //petStatus.Invoke(new Action(() => petStatus.Image = Properties.Resources.SyncBusy));

                        IEnumerable<RemoteFileInfo> _fileInfos = _session.EnumerateRemoteFiles(_secret.Decrypt(server.Local.Find), null, EnumerationOptions.EnumerateDirectories | EnumerationOptions.AllDirectories);

                        foreach (RemoteFileInfo _fileInfo in _fileInfos)
                        {
                            DirectoryStructure _dirStructure = new DirectoryStructure
                            {
                                FilePermissions = _fileInfo.FilePermissions.ToString(),
                                FileType = _fileInfo.FileType,
                                FullName = _fileInfo.FullName,
                                Group = _fileInfo.Group,
                                IsDirectory = _fileInfo.IsDirectory,
                                IsParentDirectory = _fileInfo.IsParentDirectory,
                                IsThisDirectory = _fileInfo.IsThisDirectory,
                                LastWriteTime = _fileInfo.LastWriteTime,
                                Length = _fileInfo.Length,
                                Length32 = _fileInfo.Length32,
                                Name = _fileInfo.Name,
                                Owner = _fileInfo.Owner
                            };

                            _pathList.Add(new FullPath { PathStructure = _dirStructure });

                            //lblNotifications.Invoke(new Action(() => lblNotifications.Text = "L - Obteniendo... " + _fileInfo.Name));
                        }

                        string _data = JsonConvert.SerializeObject(_pathList, Formatting.Indented);

                        File.WriteAllText(_localPathList, _data);
                    }

                    return "Se creo el directorio del servidor replica exitosamente";
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x002)", "Error al obtener directorios", 3);

                _notify.Show();

                return null;
            }
        }

        /// <summary>
        /// Metodo asincrono que permite obtener el directorio remoto
        /// </summary>
        private async void GetRemoteLists()//Verificar no halla ajustes vacios --
        {
            try
            {
                Servers _servers = _kernel.ReadSettings();

                if (_servers.Remote.Server != "")
                {
                    if (CheckInternet())
                    {
                        _notify = new Notify("Espere por favor...", "Obteniendo directorio del servidor central", 1);

                        _notify.Show();

                        lblNotifications.Text = "Obteniendo directorio central... espere por favor";

                        _archivos = 0;

                        lblNotifications.Refresh();
                        Task<string> _remote = new Task<string>(() => ProcessingRemote(_servers));
                        _remote.Start();

                        if (await _remote == "Se creo el directorio del servidor central exitosamente")
                        {
                            lblNotifications.Text = "Se creo el directorio del servidor central exitosamente";
                            //petStatus.Image = Properties.Resources.SyncOK;
                            _bridge.CreateMovement(new Movements { Fecha = DateTime.Now, Servidor = 0, Archivos = _archivos });
                        }

                        else
                        {
                            VisibleButtons(true);

                            _notify = new Notify("Error (0x003)", "Error al generar directorios", 3);

                            _notify.Show();
                        }
                    }

                    else
                    {
                        DialogResult f = XtraMessageBox.Show(UserLookAndFeel.Default, "No cuenta con conexión a internet, pero puede intentar en caso de que\n el servidor \"central\" este conectado de forma local.\n\n¿Desea continuar?", "SyncFTP - Sin conexión a internet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (f == DialogResult.Yes)
                        {
                            _notify = new Notify("Espere por favor...", "Obteniendo directorio del servidor central", 1);

                            _notify.Show();

                            lblNotifications.Text = "Obteniendo directorio central... espere por favor";

                            _archivos = 0;

                            lblNotifications.Refresh();
                            Task<string> _remote = new Task<string>(() => ProcessingRemote(_servers));
                            _remote.Start();

                            if (await _remote == "Se creo el directorio central exitosamente")
                            {
                                lblNotifications.Text = "Se creo el directorio central exitosamente";
                                //petStatus.Image = Properties.Resources.SyncOK;

                                _bridge.CreateMovement(new Movements { Fecha = DateTime.Now, Servidor = 0, Archivos = _archivos });
                            }

                            else
                            {
                                VisibleButtons(true);

                                _notify = new Notify("Error (0x003)", "Error al generar directorios", 3);

                                _notify.Show();
                            }
                        }
                    }
                }

                else
                {
                    _notify = new Notify("Sin configuración", "Faltan datos de conexión remota", 2);

                    _notify.Show();
                }

                CargarHistorial();
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x003)", "Error al generar directorios", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Metodo asincrono que permite obtener el directorio local
        /// </summary>
        private async void GetLocalLists()//Verificar no halla ajustes vacios --
        {
            try
            {
                Servers _servers = _kernel.ReadSettings();

                if (_servers.Local.Server != "")
                {
                    if (!CheckInternet())
                    {
                        _notify = new Notify("Espere por favor...", "Obteniendo directorio del servidor replica", 1);

                        _notify.Show();

                        lblNotifications.Text = "Obteniendo directorio replica... espere por favor";

                        _archivos = 0;

                        lblNotifications.Refresh();
                        Task<string> _local = new Task<string>(() => ProcessingLocal(_servers));
                        _local.Start();

                        if (await _local == "Se creo el directorio del servidor replica exitosamente")
                        {
                            lblNotifications.Text = "Se creo el directorio del servidor replica exitosamente";

                            _notify = new Notify("Éxito", "Directorio del servidor replica generado", 1);

                            _notify.Show();

                            //petStatus.Image = Properties.Resources.SyncOK;

                            _bridge.CreateMovement(new Movements { Fecha = DateTime.Now, Servidor = 1, Archivos = _archivos });
                        }

                        else
                        {
                            VisibleButtons(true);

                            _notify = new Notify("Error (0x004)", "Error al generar directorios", 3);

                            _notify.Show();
                        }
                    }

                    else
                    {
                        DialogResult f = XtraMessageBox.Show(UserLookAndFeel.Default, "Al estar conectado a internet SyncFTP da preferencia a conexiones con el servidor \"central\",\ncancelando acciones con el servidor \"replica\", pero aún así puede acceder a él, si este está accesible.\n\n¿Desea continuar?", "SyncFTP - Confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (f == DialogResult.Yes)
                        {
                            _notify = new Notify("Espere por favor...", "Obteniendo directorio de servidor replica", 1);

                            _notify.Show();

                            lblNotifications.Text = "Obteniendo directorio del servidor replica... espere por favor";

                            _archivos = 0;

                            lblNotifications.Refresh();
                            Task<string> _local = new Task<string>(() => ProcessingLocal(_servers));
                            _local.Start();

                            if (await _local == "Se creo el directorio del servidor replica exitosamente")
                            {
                                lblNotifications.Text = "Se creo el directorio replica exitosamente";

                                _notify = new Notify("Éxito", "Directorio del servidor replica generado", 1);

                                _notify.Show();

                                //petStatus.Image = Properties.Resources.SyncOK;

                                _bridge.CreateMovement(new Movements { Fecha = DateTime.Now, Servidor = 1, Archivos = _archivos });
                            }

                            else
                            {
                                VisibleButtons(true);

                                _notify = new Notify("Error (0x004)", "Error al generar directorios", 3);

                                _notify.Show();
                            }
                        }
                    }
                }

                else
                {
                    _notify = new Notify("Sin configuración", "Faltan datos de conexión local", 2);

                    _notify.Show();
                }

                CargarHistorial();
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x004)", "Error al generar directorios", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Comienza a sincronizar los archivos del servidor remoto al equipo
        /// </summary>
        /// <param name="server">Datos de los servidores donde evalua el remoto</param>
        /// <returns>Devuelve una cadena de texto segun se halla completado la sincronizacion o no</returns>
        private string SynchronizeRemoteData(Servers server)
        {
            try
            {
                SessionOptions _client = _kernel.RemoteIsValid(server);

                if (_client != null)
                {
                    if (!Directory.Exists(_remoteFilesDirectory))
                    {
                        Directory.CreateDirectory(_remoteFilesDirectory);
                    }

                    using (Session _session = new Session())
                    {
                        _session.FileTransferred += FilesTransferred;

                        _session.FileTransferProgress += FileTransferProgress;

                        //petStatus.Invoke(new Action(() => petStatus.Image = Properties.Resources.SyncBusy));

                        _session.Open(_client);

                        SynchronizationResult _syncResult;

                        _syncResult = _session.SynchronizeDirectories(SynchronizationMode.Local, _remoteFilesDirectory, _secret.Decrypt(server.Remote.Find), false, false, SynchronizationCriteria.Either);

                        _syncResult.Check();
                    }

                    return "Sincronización con el servidor central completada";
                }
                else
                {
                    return "Servidor central no válido";
                }
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x005)", "Error al sincronizar", 3);

                _notify.Show();

                return null;
            }
        }

        /// <summary>
        /// Inicializa el proceso de sincronizacion desde el servidor remoto al equipo local
        /// </summary>
        private async void BeginToSyncRemote()//Verificar no halla ajustes vacios --
        {
            try
            {
                Servers _servers = _kernel.ReadSettings();

                if (_servers.Remote.Server != "")
                {
                    if (string.IsNullOrEmpty(_servers.Remote.Server))
                    {
                        lblNotifications.Text = "Aún no hay datos del servidor central";

                        _notify = new Notify("Sin datos...", "Aún no hay datos del servidor central", 2);

                        _notify.Show();
                    }

                    else
                    {
                        VisibleButtons(false);

                        _notify = new Notify("Iniciando conexión", "Sincronizando con servidor central", 1);

                        _notify.Show();

                        lblNotifications.Text = "Sincronizando servidor central...";

                        _archivos = 0;

                        lblNotifications.Refresh();
                        //petStatus.Image = Properties.Resources.SyncBusy;
                        Task<string> _beginSync = new Task<string>(() => SynchronizeRemoteData(_servers));
                        _beginSync.Start();

                        if (await _beginSync == "Sincronización con el servidor central completada")
                        {
                            _notify = new Notify("Éxito", "Sincronización con servidor central completada", 0);

                            _notify.Show();

                            //petStatus.Image = Properties.Resources.SyncOK;

                            VisibleButtons(true);

                            lblNotifications.Text = "Los archivos se sincronizaron con el servidor central. (Acción finalizada)";

                            string _copyTo = "";

                            _bridge.CreateMovement(new Movements { Fecha = DateTime.Now, Servidor = 0, Archivos = _archivos });

                            DialogResult _answer = XtraMessageBox.Show(UserLookAndFeel.Default, "¿Desea pasar los archivos sincronizados a un dispositivo extraíble?", "SyncFTP - ¿Copiar archivos?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (_answer == DialogResult.Yes)
                            {
                                if (fbdFolderSelect.ShowDialog() == DialogResult.OK)
                                {
                                    _copyTo = _copyPath;

                                    if (!string.IsNullOrEmpty(_copyTo) && Directory.Exists(_remoteFilesDirectory))
                                    {
                                        Task<bool> _beginToCopy = new Task<bool>(() => CopyDirectory(_remoteFilesDirectory, _copyTo, true));
                                        _beginToCopy.Start();

                                        if (await _beginToCopy)
                                        {
                                            if (XtraMessageBox.Show(UserLookAndFeel.Default, "¡Listo!, ahora los archivos están donde indicaste.\n¿Desea cerrar el programa?", "SyncFTP - Copia de archivos terminada", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                            {
                                                Application.Exit();
                                            }
                                        }

                                        else
                                        {
                                            if (XtraMessageBox.Show(UserLookAndFeel.Default, "Ocurrió un error al copiar los archivos automáticamente.\nPor favor copie todos los archivos manualmente.\n¿Desea abrir la ventana con los archivos?", "SyncFTP - Error al copiar archivos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                            {
                                                Process.Start("explorer", _remoteFilesDirectory);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        else
                        {
                            VisibleButtons(true);

                            _notify = new Notify("Verficando ajustes", "Reintente sincronización", 2);

                            _notify.Show();
                        }
                    }
                }

                else
                {
                    _notify = new Notify("Sin configuración", "Faltan datos de conexión remota", 2);

                    _notify.Show();
                }

                CargarHistorial();
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x006)", "Error al sincronizar", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Comienza a sincronizar los archivos del equipo local al servidor local
        /// </summary>
        /// <param name="server">Datos de los servidores donde evalua el local</param>
        /// <returns>Devuelve una cadena de texto segun se halla completado la sincronizacion o no</returns>
        private string SynchronizeLocalData(Servers server)
        {
            try
            {
                SessionOptions _client = _kernel.LocalIsValid(server);

                if (_client != null)
                {
                    if (!Directory.Exists(_remoteFilesDirectory))
                    {
                        Directory.CreateDirectory(_remoteFilesDirectory);
                    }

                    using (Session _session = new Session())
                    {
                        _session.FileTransferred += FilesTransferred;

                        _session.FileTransferProgress += FileTransferProgress;

                        _session.Open(_client);

                        //petStatus.Invoke(new Action(() => petStatus.Image = Properties.Resources.SyncBusy));

                        SynchronizationResult _syncResult;
                        _syncResult = _session.SynchronizeDirectories(SynchronizationMode.Remote, _remoteFilesDirectory, _secret.Decrypt(server.Local.Find), false, false, SynchronizationCriteria.Either);

                        _syncResult.Check();
                    }

                    return "Sincronización con servidor replica completada";
                }
                else
                {
                    return "Servidor replica no válido";
                }
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x007)", "Error al sincronizar", 3);

                _notify.Show();

                return null;
            }
        }

        /// <summary>
        /// Inicializa el proceso de sincronizacion desde el equipo local al servidor local
        /// </summary>
        private async void BeginToSyncLocal()//Verificar no halla ajustes vacios --
        {
            try
            {
                Servers _servers = _kernel.ReadSettings();

                if (_servers.Local.Server != "")
                {

                    if (string.IsNullOrEmpty(_servers.Local.Server))
                    {
                        lblNotifications.Text = "Aún no hay datos del servidor replica";

                        _notify = new Notify("Sin datos...", "Aún no hay datos del servidor replica", 2);

                        _notify.Show();
                    }

                    else
                    {
                        VisibleButtons(false);

                        _notify = new Notify("Iniciando conexión...", "Sincronizando con servidor replica", 1);

                        _notify.Show();

                        lblNotifications.Text = "Sincronizando servidor replica...";

                        _archivos = 0;

                        lblNotifications.Refresh();
                        Task<string> _beginSync = new Task<string>(() => SynchronizeLocalData(_servers));
                        _beginSync.Start();

                        if (await _beginSync == "Sincronización con servidor replica completada")
                        {
                            VisibleButtons(true);

                            //petStatus.Image = Properties.Resources.SyncOK;

                            lblNotifications.Text = "El servidor replica a sido sincronizado";

                            _notify = new Notify("Éxito", "Sincronización con servidor replica completada", 0);

                            _notify.Show();

                            _bridge.CreateMovement(new Movements { Fecha = DateTime.Now, Servidor = 1, Archivos = _archivos });
                        }

                        else
                        {
                            VisibleButtons(true);

                            _notify = new Notify("Verficando ajustes locales", "Reintente sincronización", 2);

                            _notify.Show();
                        }
                    }
                }

                else
                {
                    _notify = new Notify("Sin configuración", "Faltan datos de conexión local", 2);

                    _notify.Show();
                }

                CargarHistorial();
            }
            catch (Exception)
            {
                VisibleButtons(true);

                _notify = new Notify("Error (0x008)", "Error al sincronizar", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Indica el tipo de movimiento o ajuste que se realiza al archivo con el que actualmente se esta trabajando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilesTransferred(object sender, TransferEventArgs e)
        {
            if (e.Error == null)
            {
                lblNotifications.Invoke(new Action(() => lblNotifications.Text = e.FileName + " cargado exitosamente"));
            }
            else
            {
                lblNotifications.Invoke(new Action(() => lblNotifications.Text = "Archivo: " + e.FileName + " error al cargar. Error: " + e.Error.ToString()));
            }

            if (e.Chmod != null)
            {
                if (e.Chmod.Error == null)
                {
                    lblNotifications.Invoke(new Action(() => lblNotifications.Text = "Archivo: " + e.Chmod.FileName + ", permisos modificados: " + e.Chmod.FilePermissions));
                }
                else
                {
                    lblNotifications.Invoke(new Action(() => lblNotifications.Text = "Falló el ajuste de permisos: " + e.Chmod.FilePermissions + ", Archivo: " + e.Chmod.FileName));
                }
            }
            else
            {
                lblNotifications.Invoke(new Action(() => lblNotifications.Text = "No se modificaron permisos de: " + e.Destination));
            }

            if (e.Touch != null)
            {
                if (e.Touch.Error == null)
                {
                    lblNotifications.Invoke(new Action(() => lblNotifications.Text = "La fecha de: " + e.Touch.FileName + ", pasó a: " + e.Touch.LastWriteTime.ToString()));
                }
                else
                {
                    lblNotifications.Invoke(new Action(() => lblNotifications.Text = "Error: " + e.Touch.Error.ToString() + ", al ajustar fecha de: " + e.Touch.FileName.ToString()));
                }
            }
            else
            {
                lblNotifications.Invoke(new Action(() => lblNotifications.Text = "La fecha de: " + e.FileName.ToString() + ", no cambiará"));
            }

            _archivos++;
        }

        /// <summary>
        /// Muestra el progreso de las transferencias compatibles el la barra de progreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileTransferProgress(object sender, FileTransferProgressEventArgs e)
        {
            if (pbcProgress.Position > 0)
            {
                pbcProgress.Invoke(new Action(() => pbcProgress.Position = 0));
            }

            pbcProgress.Invoke(new Action(() => pbcProgress.Increment(Convert.ToInt32(e.OverallProgress * 100))));

            lblAvance.Invoke(new Action(() => lblAvance.Text = string.Format("{0}% de 100% completado", (e.OverallProgress * 100))));
        }

        /// <summary>
        /// Permite copiar archivos dentro del mismo equipo local, con todo y subdirectorios
        /// </summary>
        /// <param name="sourceDirName">Direccion logica desde donde se copiaran los archivos</param>
        /// <param name="destDirName">Direccion logica a donde se copiaran los archivos</param>
        /// <param name="copySubDirs">True para copiar tambien todo y subdirectorios</param>
        /// <returns></returns>
        private bool CopyDirectory(string sourceDirName, string destDirName, bool copySubDirs)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "No se encontró la carpeta de origen de datos: "
                        + sourceDirName);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();

                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, true);
                }

                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        CopyDirectory(subdir.FullName, temppath, copySubDirs);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo asincrono que permite la subida de archivos desde un pendrive al servidor local
        /// </summary>
        private async void UploadFromExternal()
        {
            try
            {
                if (XtraMessageBox.Show(UserLookAndFeel.Default, "¿Desea sincronizar los archivos desde un medio extraíble?\n\nSi es así, asegurese de conectar ahora el dispositivo", "SyncFTP - Medios extraíbles", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (fbdFolderSelect.ShowDialog() == DialogResult.OK)
                    {
                        Task<bool> _beginToCopy = new Task<bool>(() => CopyDirectory(fbdFolderSelect.SelectedPath, _remoteFilesDirectory, true));
                        _beginToCopy.Start();

                        if (await _beginToCopy)
                        {
                            XtraMessageBox.Show(UserLookAndFeel.Default, "Si lo desea, ya puede extraer el dispositivo, ahora empezaremos a subir los archivos.", "SyncFTP - Transferencia asegurada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (!CheckInternet())
                            {
                                BeginToSyncLocal();
                            }

                            else
                            {
                                DialogResult f = XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que esta conectado a internet, se intentará acceder al servidor \"replica\".\n\n¿Desea continuar y transferir archivos?", "SyncFTP - Confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (f == DialogResult.Yes)
                                {
                                    BeginToSyncLocal();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                _notify = new Notify("Error (0x009)", "Error al cargar datos externos", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Inicia el metodo asincrono de copia de archivos desde un dispositivo extraible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petFromDrive_Click(object sender, EventArgs e)
        {
            try
            {
                UploadFromExternal();
            }
            catch (Exception)
            {
                _notify = new Notify("Error (0x010)", "Error al iniciar carga", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Funcion sorpresa al usuario que permite cambiar de forma aleatoria la visualizacion de SyncFTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Random _random = new Random();

                    switch (_random.Next(0, 5))
                    {
                        case 1:
                            dlafSkins.LookAndFeel.SkinName = "Springtime";
                            break;

                        case 2:
                            dlafSkins.LookAndFeel.SkinName = "Summer 2008";
                            break;

                        case 3:
                            dlafSkins.LookAndFeel.SkinName = "Xmas 2008 Blue";
                            break;

                        case 4:
                            dlafSkins.LookAndFeel.SkinName = "Darkroom";
                            break;

                        case 5:
                            dlafSkins.LookAndFeel.SkinName = "Foggy";
                            break;

                        default:
                            dlafSkins.LookAndFeel.SkinName = "Office 2016 Colorful";
                            break;
                    }
                }
            }
            catch (Exception)
            {
                _notify = new Notify("Error (0x00T)", "Error al ajustar tema", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Abre la carpeta donde se almacenan todos los archivos del servidor remoto en el explorador de windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petRemoteFiles_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer", _remoteFilesDirectory);
            }
            catch (Exception)
            {
                _notify = new Notify("Error (0x010)", "Error al abrir ubicación", 3);

                _notify.Show();
            }
        }

        /// <summary>
        /// Temporizador que mide el tiempo que lleva ejecutandose una accion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _tmpElapsedTime_Tick(object sender, EventArgs e)
        {
            lblElapsedTime.Refresh();
            lblElapsedTime.Text = "Tiempo: " + _seconds.ToString() + " seg.";
            _seconds++;
        }

        #endregion

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarCentral_Click(object sender, EventArgs e)
        {
            if (CheckInternet())
            {
                BeginToSyncRemote();
            }

            else
            {
                DialogResult f = XtraMessageBox.Show(UserLookAndFeel.Default, "No cuenta con conexión a internet, pero puede intentar en caso de que\n el servidor \"central\" este conectado de forma local.\n\n¿Desea continuar?", "Sin conexión a internet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (f == DialogResult.Yes)
                {
                    BeginToSyncRemote();
                }
            }
        }

        private void btnIniciarReplica_Click(object sender, EventArgs e)
        {
            if (!CheckInternet())
            {
                BeginToSyncLocal();
            }

            else
            {
                DialogResult f = XtraMessageBox.Show(UserLookAndFeel.Default, "Al estar conectado a internet SyncFTP da preferencia a conexiones con el servidor \"central\",\ncancelando acciones con el servidor \"replica\", pero aún así puede acceder a él, si este está accesible.\n\n¿Desea continuar?", "Confirme acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (f == DialogResult.Yes)
                {
                    BeginToSyncLocal();
                }
            }
        }

        private void ObtenerDispositivos()
        {
            try
            {
                DriveInfo[] dispositivos = DriveInfo.GetDrives();

                cbxDispositivos.Properties.Items.Clear();

                foreach (DriveInfo dispositivo in dispositivos)
                {
                    if (dispositivo.IsReady)
                    {
                        if (dispositivo.DriveType == DriveType.Fixed)
                        {
                            cbxDispositivos.Properties.Items.Add(dispositivo.Name + "  " + dispositivo.VolumeLabel + "  Disco Local");
                        }

                        if (dispositivo.DriveType == DriveType.Removable)
                        {
                            cbxDispositivos.Properties.Items.Add(dispositivo.Name + "  " + dispositivo.VolumeLabel + "  Unidad Extraible");
                        }

                        //if (dispositivo.DriveType == DriveType.CDRom || dispositivo.DriveType == DriveType.Network || dispositivo.DriveType == DriveType.NoRootDirectory || dispositivo.DriveType == DriveType.Ram || dispositivo.DriveType == DriveType.Unknown)
                        //{

                        //}
                    }
                }

                cbxDispositivos.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }

        private void cbxDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _copyPath = cbxDispositivos.SelectedItem.ToString().Substring(0, 3);

                MessageBox.Show(_copyPath);
            }
            catch (Exception)
            {

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _copyPath = cbxDispositivos.SelectedItem.ToString().Substring(0, 3) + @"Sincronizacion " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");

            MessageBox.Show(_copyPath);

            _notify = new Notify("Transfiriendo archivos", "Se transfirieron los archivos correctamente", 1);

            _notify.Show();
        }

        private void btnAvanzados_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdFolderSelect.ShowDialog() == DialogResult.OK)
                {
                    _copyPath = fbdFolderSelect.SelectedPath + @"Sincronizacion " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");

                    MessageBox.Show(_copyPath);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerDispositivos();
        }

        private void CargarHistorial()
        {
            try
            {
                _bridge.RemoteMovementsToList(gdcCentral);
                _bridge.LocalMovementsToList(gdcReplica);

                gdvCentral.Columns[1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

                gdvCentral.Columns[1].DisplayFormat.FormatString = "g";

                gdvReplica.Columns[1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

                gdvReplica.Columns[1].DisplayFormat.FormatString = "g";
            }
            catch (Exception)
            {

            }
        }

        private void Transferir(string path)
        {
            CopyDirectory(_remoteFilesDirectory, path + @"Sincronizacion " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss"), true);
        }
    }
}