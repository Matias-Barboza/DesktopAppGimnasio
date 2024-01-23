using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using DesktopAppGimnasio.Models;

namespace DesktopAppGimnasio._Repositories
{
    public class SocioRepository : BaseRepository, ISocioRepository
    {

        // Constructor
        public SocioRepository(String connectionString) 
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(SocioModel socioModel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO socios (DNI, nombre, apellido, esta_activo) VALUES (@DNI_nuevo, @nombre_nuevo, @apellido_nuevo, true)";
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "DNI_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = socioModel.DNI
                    }) ;
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "nombre_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = socioModel.Nombre
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "apellido_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = socioModel.Apellido
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int codigoSocio)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM socios WHERE codigo_socio = @codigoSocio";
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = codigoSocio
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(SocioModel socioModel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE socios SET DNI = @DNI_nuevo, nombre = @nombre_nuevo, apellido = @apellido_nuevo
                                           WHERE codigo_socio = @codigoSocio";
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = socioModel.CodigoSocio
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "DNI_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = socioModel.DNI
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "nombre_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = socioModel.Nombre
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "apellido_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = socioModel.Apellido
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<SocioModel> GetAll()
        {
            List<SocioModel> sociosList = new List<SocioModel>();

            using(MySqlConnection connection = new MySqlConnection(connectionString)) 
            {

                using (MySqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM socios ORDER BY codigo_socio DESC";

                    using (MySqlDataReader reader = command.ExecuteReader()) 
                    {
                    
                        while (reader.Read()) 
                        {
                            SocioModel socio = new SocioModel();

                            socio.CodigoSocio = (int) reader[0];
                            socio.DNI = (String) reader[1];
                            socio.Nombre = (String) reader[2];
                            socio.Apellido = (String) reader[3];
                            socio.EstaActivo = (bool) reader[4];

                            sociosList.Add(socio);
                        }
                    }
                }
            }

            return sociosList;
        }

        public IEnumerable<SocioModel> GetByValue(string value)
        {
            List<SocioModel> sociosList = new List<SocioModel>();
            int codigoSocio = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            String nombreYApellidoSocio = "%" + value + "%";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM socios
                                            WHERE codigo_socio = @numero_socio OR nombre LIKE @nombre_y_apellido OR apellido like @nombre_y_apellido
                                            ORDER BY codigo_socio DESC";
                    command.Parameters.Add(new MySqlParameter(){
                        ParameterName = "@numero_socio",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = codigoSocio
                    });
                    command.Parameters.Add(new MySqlParameter() {
                        ParameterName = "@nombre_y_apellido",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = nombreYApellidoSocio
                    });

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            SocioModel socio = new SocioModel();

                            socio.CodigoSocio = (int) reader[0];
                            socio.DNI = (String) reader[1];
                            socio.Nombre = (String) reader[2];
                            socio.Apellido = (String) reader[3];
                            socio.EstaActivo = (bool) reader[4];

                            sociosList.Add(socio);
                        }
                    }
                }
            }

            return sociosList;
        }
    }
}
