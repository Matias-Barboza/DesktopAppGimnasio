using DesktopAppGimnasio.Models;
using MySql.Data.MySqlClient;

namespace DesktopAppGimnasio._Repositories
{
    public class CuotaRepository : BaseRepository, ICuotaRepository
    {

        // Constructor
        public CuotaRepository(String connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CuotaModel cuotaModel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO cuotas (codigo_socio_fk, id_tipo_fk, fecha_pago, fecha_vencimiento, mes_abonado, monto_abonado)
                                            VALUES (@codigoSocio, @id_tipo_nuevo, @fecha_pago_nuevo, @fecha_vencimiento_nuevo, @mes_abonado_nuevo, @monto_abonado_nuevo);";

                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = cuotaModel.CodigoSocio
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "id_tipo_nuevo",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = cuotaModel.IdTipoCuota
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "fecha_pago_nuevo",
                        MySqlDbType = MySqlDbType.Date,
                        Value = cuotaModel.FechaDePago
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "fecha_vencimiento_nuevo",
                        MySqlDbType = MySqlDbType.Date,
                        Value = cuotaModel.FechaDeVencimiento
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "mes_abonado_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = cuotaModel.MesQueAbona
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "monto_abonado_nuevo",
                        MySqlDbType = MySqlDbType.Float,
                        Value = cuotaModel.MontoAbonado
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(CuotaModel cuotaModel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE cuotas SET codigo_socio_fk = @codigoSocio, id_tipo_fk = @id_tipo_nuevo,
                                                    fecha_pago = @fecha_pago_nuevo, fecha_vencimiento = @fecha_vencimiento_nuevo,
                                                    mes_abonado = @mes_abonado_nuevo, monto_abonado = @monto_abonado_nuevo
                                            WHERE codigo_cuota = @codigoCuota;";

                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoCuota",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = cuotaModel.CodigoCuota
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = cuotaModel.CodigoSocio
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "id_tipo_nuevo",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = cuotaModel.IdTipoCuota
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "fecha_pago_nuevo",
                        MySqlDbType = MySqlDbType.Date,
                        Value = cuotaModel.FechaDePago
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "fecha_vencimiento_nuevo",
                        MySqlDbType = MySqlDbType.Date,
                        Value = cuotaModel.FechaDeVencimiento
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "mes_abonado_nuevo",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = cuotaModel.MesQueAbona
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "monto_abonado_nuevo",
                        MySqlDbType = MySqlDbType.Float,
                        Value = cuotaModel.MontoAbonado
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int codigoCuota)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"DELETE FROM cuotas
                                            WHERE codigo_cuota = @codigoCuota;";

                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoCuota",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = codigoCuota
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAllCuotasOfSocio(int codigoSocio)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"DELETE FROM cuotas
                                            WHERE codigo_socio_fk = @codigoSocio;";

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

        public IEnumerable<CuotaModel> GetAll()
        {
            List<CuotaModel> cuotasList = new List<CuotaModel>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT c.codigo_cuota, c.codigo_socio_fk, s.nombre, s.apellido, t.descripcion, c.fecha_pago, c.fecha_vencimiento, c.mes_abonado, c.monto_abonado, c.id_tipo_fk
                                            FROM cuotas AS c
                                                JOIN
                                                socios AS s
                                                ON s.codigo_socio = c.codigo_socio_fk
                                                JOIN tipos AS t
                                                ON c.id_tipo_fk = t.id_tipo
                                            ORDER BY c.codigo_cuota DESC;";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            CuotaModel cuota = new CuotaModel();

                            cuota.CodigoCuota = (int) reader[0];
                            cuota.CodigoSocio = (int) reader[1];
                            cuota.NombreSocio = (String) reader[2];
                            cuota.ApellidoSocio = (String) reader[3];
                            cuota.DescripcionCuota = (String) reader[4];
                            cuota.FechaDePago = (DateTime) reader[5];
                            cuota.FechaDeVencimiento = (DateTime) reader[6];
                            cuota.MesQueAbona = (String) reader[7];
                            cuota.MontoAbonado = (float) reader[8];
                            cuota.IdTipoCuota = (int) reader[9];

                            cuotasList.Add(cuota);
                        }
                    }
                }
            }

            return cuotasList;
        }

        public IEnumerable<CuotaModel> GetByValue(string value)
        {
            List<CuotaModel> cuotasList = new List<CuotaModel>();
            int codigo_cuota = int.TryParse(value, out _) ? int.Parse(value) : 0;
            int codigo_socio = int.TryParse(value, out _) ? int.Parse(value) : 0;
            string nombreYApellidoSocio = "%" + value + "%";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT c.codigo_cuota, c.codigo_socio_fk, s.nombre, s.apellido, t.descripcion, c.fecha_pago, c.fecha_vencimiento, c.mes_abonado, c.monto_abonado
                                            FROM cuotas AS c
                                                JOIN
                                                socios AS s
                                                ON s.codigo_socio = c.codigo_socio_fk
                                                JOIN tipos AS t
                                                ON c.id_tipo_fk = t.id_tipo
                                            WHERE c.codigo_cuota = @codigo_cuota OR c.codigo_socio_fk = @codigo_socio OR s.nombre LIKE @nombre_apellido OR s.apellido LIKE @nombre_apellido OR
                                                  CONCAT(s.nombre, ' ', s.apellido) LIKE @nombre_apellido
                                            ORDER BY c.codigo_cuota DESC;";
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigo_cuota",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = codigo_cuota
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigo_socio",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = codigo_socio
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "nombre_apellido",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = nombreYApellidoSocio
                    });

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            CuotaModel cuota = new CuotaModel();

                            cuota.CodigoCuota = (int) reader[0];
                            cuota.CodigoSocio = (int) reader[1];
                            cuota.NombreSocio = (String) reader[2];
                            cuota.ApellidoSocio = (String) reader[3];
                            cuota.DescripcionCuota = (String) reader[4];
                            cuota.FechaDePago = (DateTime) reader[5];
                            cuota.FechaDeVencimiento = (DateTime) reader[6];
                            cuota.MesQueAbona = (String) reader[7];
                            cuota.MontoAbonado = (float) reader[8];

                            cuotasList.Add(cuota);
                        }
                    }
                }
            }

            return cuotasList;
        }

        public IEnumerable<CuotaModel> GetAllDebts()
        {
            List<CuotaModel> cuotasVencidasList = new List<CuotaModel>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT cv.codigo_cuota, cv.codigo_socio_fk, s.nombre, s.apellido, cv.fecha_pago, cv.fecha_vencimiento
                                            FROM cuotas AS cv
		                                        JOIN
	                                            socios AS s
	                                            ON cv.codigo_socio_fk = s.codigo_socio
                                            WHERE CURDATE() > cv.fecha_vencimiento AND
                                                              s.esta_activo = TRUE AND
                                                              cv.fecha_vencimiento = (SELECT MAX(c.fecha_vencimiento)
															                          FROM cuotas AS c
															                          WHERE c.codigo_socio_fk = cv.codigo_socio_fk);";


                    using(MySqlDataReader reader = command.ExecuteReader()) 
                    {

                        while(reader.Read()) 
                        {
                            CuotaModel cuota = new CuotaModel();

                            cuota.CodigoCuota = (int) reader[0];
                            cuota.CodigoSocio = (int) reader[1];
                            cuota.NombreSocio = (String) reader[2];
                            cuota.ApellidoSocio = (String) reader[3];
                            cuota.FechaDePago = (DateTime) reader[4];
                            cuota.FechaDeVencimiento = (DateTime) reader[5];

                            cuotasVencidasList.Add(cuota);
                        }
                    }
                }
            }

            return cuotasVencidasList;
        }

        public IEnumerable<CuotaModel> GetDebtsByValue(string value)
        {
            List<CuotaModel> cuotasVencidasList = new List<CuotaModel>();
            int codigo_cuota = int.TryParse(value, out _) ? int.Parse(value) : 0;
            int codigo_socio = int.TryParse(value, out _) ? int.Parse(value) : 0;
            string nombreYApellidoSocio = "%" + value + "%";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT cv.codigo_cuota, cv.codigo_socio_fk, s.nombre, s.apellido, cv.fecha_pago, cv.fecha_vencimiento
                                            FROM cuotas AS cv
                                                    JOIN
                                                    socios AS s
                                                    ON cv.codigo_socio_fk = s.codigo_socio
                                            WHERE CURDATE() > cv.fecha_vencimiento AND
                                                              (cv.codigo_cuota = @codigoCuota OR cv.codigo_socio_fk = @codigoSocio OR s.nombre = @nombre_y_apellido OR
                                                              s.apellido = @nombre_y_apellido OR CONCAT(s.nombre,' ',s.apellido) = @nombre_y_apellido) AND
                                                              s.esta_activo = TRUE AND
                                                              cv.fecha_vencimiento = (SELECT MAX(c.fecha_vencimiento)
												                                      FROM cuotas AS c
												                                      WHERE c.codigo_socio_fk = cv.codigo_socio_fk);";
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoCuota",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = codigo_cuota
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = codigo_socio
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "nombre_y_apellido",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = nombreYApellidoSocio
                    });

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            CuotaModel cuota = new CuotaModel();

                            cuota.CodigoCuota = (int) reader[0];
                            cuota.CodigoSocio = (int) reader[1];
                            cuota.NombreSocio = (String) reader[2];
                            cuota.ApellidoSocio = (String) reader[3];
                            cuota.FechaDePago = (DateTime) reader[4];
                            cuota.FechaDeVencimiento = (DateTime) reader[5];

                            cuotasVencidasList.Add(cuota);
                        }
                    }
                }
            }

            return cuotasVencidasList;
        }
    }
}
