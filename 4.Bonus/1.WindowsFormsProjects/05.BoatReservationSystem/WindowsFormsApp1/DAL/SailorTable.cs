using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BoatReservationSystem.Model;

namespace BoatReservationSystem.DAL
{
    public class SailorTable
    {
        private readonly string _connectionString;
        private SqlConnection _sqlConnection;

        public SailorTable()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString; ;
        }
        private void OpenConnection()
        {
            _sqlConnection = new SqlConnection { ConnectionString = _connectionString };
            _sqlConnection.Open();
        }

        private void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection?.Close();
            }
        }


        public void Create(string name, int rate, DateTime date)
        {
            OpenConnection();
            string sql = $"Insert Into Sailor(sname,srate,sdate) Values('{name}',{rate},'{date}')";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public List<Sailor> ReadAll()
        {
            List<Sailor> sailors = new List<Sailor>();

            OpenConnection();
            string sql = $"Select * From Sailor";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    Sailor sailor = new Sailor
                    {
                        Id = (int)dataReader["sid"],
                        SailorName = (string)dataReader["sname"],
                        SailorRate = (int)dataReader["srate"],
                        SailorBirthDate = DateTime.Parse(dataReader["sdate"].ToString())
                    };

                    sailors.Add(sailor);
                }
                dataReader.Close();
            }

            CloseConnection();
            return sailors;
        }


        public List<Sailor> ReadLike(string name, int rate, DateTime date)
        {
            List<Sailor> sailors = new List<Sailor>();
            OpenConnection();
            string sql = $"Select * From Sailor Where sname like " + $"'%{name}%'" + " or sdate like " + $"'%{date}%' or srate = {rate}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    Sailor sailor = new Sailor()
                    {
                        Id = (int)dataReader["sid"],
                        SailorName = (string)dataReader["sname"],
                        SailorRate = (int)dataReader["srate"],
                        SailorBirthDate = DateTime.Parse(dataReader["sdate"].ToString())
                    };

                    sailors.Add(sailor);
                }
                dataReader.Close();
            }

            CloseConnection();
            return sailors;
        }

        public void Delete(int id)
        {
            OpenConnection();
            string sql = $"DELETE FROM Sailor WHERE sid = {id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void Update(int id, string name, int rate, DateTime date)
        {
            OpenConnection();
            string sql = $"Update Sailor Set sname ='{name}',srate ={rate},sdate='{date}' Where sid ={id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}
