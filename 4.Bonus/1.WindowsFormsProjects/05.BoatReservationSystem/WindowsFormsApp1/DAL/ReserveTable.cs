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
    public class ReserveTable
    {
        private readonly string _connectionString;
        private SqlConnection _sqlConnection;

        public ReserveTable()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            ;
        }

        private void OpenConnection()
        {
            _sqlConnection = new SqlConnection {ConnectionString = _connectionString};
            _sqlConnection.Open();
        }

        private void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection?.Close();
            }
        }

        public List<Reserve> ReadAll()
        {
            List<Reserve> reserves = new List<Reserve>();

            OpenConnection();
            string sql = $"select Sailor.sid,Sailor.sname,Boat.bid,Boat.bname,Reserve.rid,Reserve.date from Reserve " +
                         $"join Boat on Reserve.bid = Boat.bid " +
                         $"join Sailor on Reserve.sid = Sailor.sid";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    Reserve reserve = new Reserve
                    {
                        Id = (int) dataReader["rid"],
                        SailorName = (string) dataReader["sname"],
                        BoatName = (string) dataReader["bname"],
                        Sid = (int) dataReader["sid"],
                        Bid = (int) dataReader["bid"],
                        ReserveDate = DateTime.Parse(dataReader["date"].ToString())
                    };

                    reserves.Add(reserve);
                }

                dataReader.Close();
            }

            CloseConnection();
            return reserves;
        }


        public void Create(int sid, int bid,DateTime date)
        {
            OpenConnection();
            string sql = $"Insert Into Reserve(sid,bid,date) Values({sid},{bid},'{date}')";

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
            string sql = $"DELETE FROM Reserve WHERE rid = {id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }

            CloseConnection();
        }

        public List<Reserve> ReadLike(string sname)
        {
            List<Reserve> reserves = new List<Reserve>();
            OpenConnection();

            string sql = $"select Sailor.sid,Sailor.sname,Boat.bid,Boat.bname,Reserve.rid,Reserve.date from Reserve " +
                         $"join Boat on Reserve.bid = Boat.bid " +
                         $"join Sailor on Reserve.sid = Sailor.sid " +
                         $"Where Sailor.sname like " + $"N'%{sname}%'";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    Reserve reserve = new Reserve
                    {
                        Id = (int) dataReader["rid"],
                        Bid = (int) dataReader["bid"],
                        Sid = (int) dataReader["sid"],
                        BoatName = (string) dataReader["bname"],
                        SailorName = (string) dataReader["sname"],
                        ReserveDate = DateTime.Parse(dataReader["date"].ToString())
                    };

                    reserves.Add(reserve);
                }

                dataReader.Close();
            }

            return reserves;
        }

        public List<Reserve> ReadLike(DateTime date)
        {
            List<Reserve> reserves = new List<Reserve>();
            OpenConnection();

            string sql = $"select Sailor.sid,Sailor.sname,Boat.bid,Boat.bname,Reserve.rid,Reserve.date from Reserve " +
                         $"join Boat on Reserve.bid = Boat.bid " +
                         $"join Sailor on Reserve.sid = Sailor.sid " +
                         $"Where Reserve.date >= '{date}'";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    Reserve reserve = new Reserve
                    {
                        Id = (int)dataReader["rid"],
                        Bid = (int)dataReader["bid"],
                        Sid = (int)dataReader["sid"],
                        BoatName = (string)dataReader["bname"],
                        SailorName = (string)dataReader["sname"],
                        ReserveDate = DateTime.Parse(dataReader["date"].ToString())
                    };

                    reserves.Add(reserve);
                }

                dataReader.Close();
            }

            return reserves;
        }

        public void Update(int rid, int sid, int bid,DateTime date)
        {
            OpenConnection();
            string sql = $"Update Reserve Set sid ={sid},bid ={bid},date='{date}' Where rid ={rid}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

       
    }
}