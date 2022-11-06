using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SoporteDatos
    {
        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Soporte";
                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync(); 
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(Soporte soporte)
        {
            Boolean inserto = false;
            try
            {
                string sql = "INSERT INTO soporte VALUES (@Tipo, @Descripcion, @Respuesta, @Precio)";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Tipo", MySqlDbType.VarChar, 50).Value = soporte.Tipo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 80).Value = soporte.Descripcion;
                        comando.Parameters.Add("@Respuesta", MySqlDbType.VarChar, 80).Value = soporte.Respuesta;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = soporte.Precio;

                        await comando.ExecuteNonQueryAsync(); 
                        inserto = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }

        public async Task<bool> ActualizarAsync(Soporte soporte)
        {
            bool actualizo = false;

            try
            {
                string sql = "UPDATE soporte SET Descripcion=@Descripcion, Respuesta=@Respuesta, Precio=@Precio WHERE Tipo=@Tipo";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Tipo", MySqlDbType.VarChar, 50).Value = soporte.Tipo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 80).Value = soporte.Descripcion;
                        comando.Parameters.Add("@Respuesta", MySqlDbType.VarChar, 80).Value = soporte.Respuesta;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = soporte.Precio;

                        await comando.ExecuteNonQueryAsync(); 
                        actualizo = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return actualizo;
        }

        public async Task<bool> EliminarAsync(string tipo)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM soporte WHERE Tipo=@Tipo";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Tipo", MySqlDbType.VarChar, 50).Value = tipo;

                        await comando.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }
    
        public async Task<Soporte> GetDeTipo(string tipo)
        {
            Soporte soporte = new Soporte();
            try
            {
                string sql = "SELECT * FROM soporte WHERE Tipo = @Tipo";
                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Tipo", MySqlDbType.VarChar, 50).Value = tipo;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        if (dr.Read())
                        {
                            soporte.Tipo = dr["Tipo"].ToString();
                            soporte.Descripcion = dr["Descripcion"].ToString();
                            soporte.Respuesta = dr["Respuesta"].ToString();
                            soporte.Precio = Convert.ToDecimal(dr["Precio"]);
                        }
                    }

                }
            }
            catch (Exception)
            {
            }
            return soporte;
        }
    }
}
