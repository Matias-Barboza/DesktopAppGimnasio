using DesktopAppGimnasio.Models;
using MySql.Data.MySqlClient;

namespace DesktopAppGimnasio._Repositories
{
    internal class TipoCuotaRepository : BaseRepository, ITipoCuotaRepository
    {
        // Constructor
        public TipoCuotaRepository(String conecctionString) 
        {
            this.connectionString = conecctionString;
        }

        // Methods
        public void Edit(TipoCuotaModel tipoCuotaModel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) 
            {
                using (MySqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE tipos SET monto = @monto_nuevo
                                            WHERE id_tipo = @id_tipo_edit;";
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "id_tipo_edit",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = tipoCuotaModel.IdTipoCuota
                    });
                    command.Parameters.Add(new MySqlParameter()
                    {
                        ParameterName = "monto_nuevo",
                        MySqlDbType = MySqlDbType.Float,
                        Value = tipoCuotaModel.Monto
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TipoCuotaModel> GetAll()
        {
            List<TipoCuotaModel> tiposCuotaList = new List<TipoCuotaModel>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT id_tipo, descripcion, monto
                                            FROM tipos;";

                    using(MySqlDataReader reader = command.ExecuteReader()) 
                    {
                        
                        while (reader.Read())
                        {
                            TipoCuotaModel tipoCuotaModel = new TipoCuotaModel();

                            tipoCuotaModel.IdTipoCuota = (int) reader[0];
                            tipoCuotaModel.Descripcion = (String) reader[1];
                            tipoCuotaModel.Monto = (float) reader[2];

                            tiposCuotaList.Add(tipoCuotaModel);
                        }
                    }
                }
            }

            return tiposCuotaList;
        }

        public IEnumerable<float> GetAllAmounts() 
        {
            List<float> amounts = new List<float>();

            using (MySqlConnection connection = new MySqlConnection(connectionString)) 
            {
                using (MySqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT monto
                                            FROM tipos;";

                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read()) 
                        {
                            amounts.Add((float) reader[0]);
                        }
                    }
                }
            }

            return amounts;
        }
    }
}
