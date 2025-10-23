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
    public class BoatTable
    {
        private readonly string _connectionString;
        private SqlConnection _sqlConnection;

        public BoatTable()
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


        public void Create(string name, string color)
        {
            OpenConnection();
            string sql = $"Insert Into Boat(bname,color) Values('{name}','{color}')";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void Update(int id, string name, string color)
        {
            OpenConnection();
            string sql = $"Update Boat Set bname ='{name}',color ='{color}' Where bid ={id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void Delete(int id)
        {
            OpenConnection();
            string sql = $"DELETE FROM Boat WHERE bid = {id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }


        public Boat Read(int id)
        {
            Boat boat = null;
            OpenConnection();
            string sql = $"Select * From Boat Where bid = '{id}'";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    boat = new Boat
                    {
                        Id = (int)dataReader["bid"],
                        BoatName = (string)dataReader["bname"],
                        BoatColor = (string)dataReader["color"],
                    };

                }
                dataReader.Close();
            }

            CloseConnection();

            return boat;
        }
        public List<Boat> ReadAll()
        {
            List<Boat> boats = new List<Boat>();

            OpenConnection();
            string sql = $"Select * From Boat";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    Boat boat = new Boat
                    {
                        Id = (int)dataReader["bid"],
                        BoatName = (string)dataReader["bname"],
                        BoatColor = (string)dataReader["color"],
                    };

                    boats.Add(boat);
                }
                dataReader.Close();
            }

            CloseConnection();
            return boats;
        }

        public List<Boat> ReadLike(string name, string color)
        {
            List<Boat> boats = new List<Boat>();
            OpenConnection();
            string sql = $"Select * From Boat Where bname like " + $"'%{name}%'" + " and color like " + $"'%{color}%'";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    Boat boat = new Boat
                    {
                        Id = (int)dataReader["bid"],
                        BoatName = (string)dataReader["bname"],
                        BoatColor = (string)dataReader["color"],
                    };

                    boats.Add(boat);
                }
                dataReader.Close();
            }

            CloseConnection();
            return boats;
        }
    }
}
