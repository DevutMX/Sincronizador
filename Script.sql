create table Movimientos
(
    Movimiento integer primary key autoincrement,
    Fecha Date not null,
    Archivos integer not null,
    Servidor integer not null
);