using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace DataBase
{
    public class TicketDB
    {
        string cadena = " server=localhost; user=root; database=solicitudes; password=123456";


        public Boolean Guardar(Ticket ticket)
        {
            Boolean inserto = false;
            int idFactura = 0;

            try
            {
                StringBuilder sqlFactura = new StringBuilder();
                sqlFactura.Append(" INSERT INTO ticket (Fecha, CodigoUsuario, IdentidadCliente, Soporte, DescripcionSolicitud, DescripcionRespuesta, Precio, ISV, Descuento, SubTotal, Total) VALUES (@Fecha, @CodigoUsuario, @IdentidadCliente, @Soporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @ISV, @Descuento, @SubTotal, @Total); ");
                sqlFactura.Append(" SELECT LAST_INSERT_ID(); ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    MySqlTransaction transaccion = _conexion.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        using (MySqlCommand comando1 = new MySqlCommand(sqlFactura.ToString(), _conexion, transaccion))
                        {
                            comando1.CommandType = System.Data.CommandType.Text;
                            comando1.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;
                            comando1.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = ticket.CodigoUsuario;
                            comando1.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = ticket.IdentidadCliente;
                            comando1.Parameters.Add("@Soporte", MySqlDbType.VarChar, 50).Value = ticket.Soporte;
                            comando1.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 200).Value = ticket.DescripcionSolicitud;
                            comando1.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 200).Value = ticket.DescripcionRespuesta;
                            comando1.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.Precio;
                            comando1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = ticket.ISV;
                            comando1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                            comando1.Parameters.Add("@SubTotal", MySqlDbType.Decimal).Value = ticket.SubTotal;
                            comando1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                            idFactura = Convert.ToInt32(comando1.ExecuteScalar());
                        }
                        transaccion.Commit();
                        inserto = true;



                    }
                    catch (System.Exception ex)
                    {
                        inserto = false;
                        transaccion.Rollback();
                    }
                }






            }
            catch (System.Exception ex)
            {
            }
            return inserto;
        }


    }
}
