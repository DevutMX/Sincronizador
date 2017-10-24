using DevExpress.XtraGrid;
using SyncFTP.Controllers;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SyncFTP.Models
{
    class SyncFTPRepository
    {
        private readonly string _connectionString = "Data Source = " + Application.StartupPath + @"\Historial.db; Version = 3;";

        SQLiteConnection _connection;
        SQLiteCommand _command;
        SQLiteDataReader _dataReader;
        SQLiteDataAdapter _dataAdapter;
        DataTable _table;

        /// <summary>
        /// Registra un movimiento en la base de datos
        /// </summary>
        /// <param name="movement">Objeto que contiene todos los datos a almacenar en la BD</param>
        /// <returns>True cuando el registro fue exitoso</returns>
        protected internal bool CreateMovement(Movements movement)
        {
            try
            {
                using (_connection = new SQLiteConnection(_connectionString))
                {
                    string _query = "INSERT INTO Movimientos VALUES( null, @a, @b, @c);";

                    _connection.Open();

                    _command = new SQLiteCommand(_query, _connection);

                    _command.Parameters.AddWithValue("@a", movement.Fecha);
                    _command.Parameters.AddWithValue("@b", movement.Archivos);
                    _command.Parameters.AddWithValue("@c", movement.Servidor);

                    int _response = _command.ExecuteNonQuery();

                    return _response > 0 ? true : false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Llena un GridControl con informacion del servidor central de la base de datos
        /// </summary>
        /// <param name="_toFill">GridControl donde se mostrarán los datos</param>
        protected internal void RemoteMovementsToList(GridControl _toFill)
        {
            try
            {
                using (_connection = new SQLiteConnection(_connectionString))
                {
                    string _query = "SELECT Movimiento as 'No. de Movimiento', Fecha as 'Ultima sincronización', Archivos as 'No. de archivos transferidos' FROM Movimientos WHERE Servidor = 0 Order by Fecha Desc;";

                    _connection.Open();

                    _command = new SQLiteCommand(_query, _connection);

                    _table = new DataTable();

                    _dataAdapter = new SQLiteDataAdapter(_command);

                    _dataAdapter.Fill(_table);

                    _toFill.DataSource = _table;
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Llena un GridControl con informacion del servidor local de la base de datos
        /// </summary>
        /// <param name="_toFill">GridControl donde se mostrarán los datos</param>
        protected internal void LocalMovementsToList(GridControl _toFill)
        {
            try
            {
                using (_connection = new SQLiteConnection(_connectionString))
                {
                    string _query = "SELECT Movimiento as 'No. de Movimiento', Fecha as 'Ultima sincronización', Archivos as 'No. de archivos transferidos' FROM Movimientos WHERE Servidor = 1 Order by Fecha Desc;";

                    _connection.Open();

                    _command = new SQLiteCommand(_query, _connection);

                    _table = new DataTable();

                    _dataAdapter = new SQLiteDataAdapter(_command);

                    _dataAdapter.Fill(_table);

                    _toFill.DataSource = _table;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

