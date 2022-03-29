using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zurumbia_11883.DAL
{
    public class SocialWorkerManager : DbManager
    {
        public void Create(SocialWorker a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                    INSERT INTO sw_social_worker (
                    sw_name_11883,
                    sw_region_11883,
                    sw_hours_11883,
                    sw_rate_11883
                ) 
                    VALUES(
                    '{a.Name}',
                    '{a.Region}',
                    '{a.Hours}',
                    '{a.Rate}'
                )";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        public void Update(SocialWorker a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                    UPDATE sw_social_worker SET
                    sw_name_11883 = '{a.Name}',
                    sw_region_11883 = '{a.Region}',
                    sw_hours_11883 = '{a.Hours}',
                    sw_rate_11883 = '{a.Rate}'
                    WHERE sw_id_11883 = {a.Id}";

                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                          DELETE FROM sw_social_worker 
                          WHERE sw_id_11883 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public SocialWorker GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                    SELECT 
                    sw_id_11883, 
                    sw_name_11883,
                    sw_region_11883,
                    sw_hours_11883,
                    sw_rate_11883
                    FROM sw_social_worker
                    WHERE sw_id_11883 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var a = GetFromReader(reader);
                    return a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            // if we are here - something went wrong
            return null;
        }

        public List<SocialWorker> GetAll()
        {
            var connection = Connection;
            var result = new List<SocialWorker>();
            try
            {
                var sql = "SELECT sw_id_11883, sw_name_11883, sw_region_11883, sw_hours_11883, sw_rate_11883 FROM sw_social_worker";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return result;
        }

        private SocialWorker GetFromReader(SqlCeDataReader reader)
        {
            var a = new SocialWorker
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                Region = Convert.ToInt32(reader.GetValue(2)),
                Hours = Convert.ToDecimal(reader.GetValue(3)),
                Rate = Convert.ToDecimal(reader.GetValue(4))
            };
            return a;
        }
    }
}
