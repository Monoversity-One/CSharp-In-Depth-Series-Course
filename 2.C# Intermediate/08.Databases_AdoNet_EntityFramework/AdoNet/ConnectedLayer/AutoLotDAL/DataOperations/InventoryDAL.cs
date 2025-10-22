using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using _08_1.AdoNetConnectedLayer.AutoLotDAL.Models;

namespace _08_1.AdoNetConnectedLayer.AutoLotDAL.DataOperations
{
    public class InventoryDAL
    {
        private readonly string _connectionString;
        private SqlConnection _sqlConnection;
        public InventoryDAL() : this(@"Data Source = .\SQLSERVER17; Initial Catalog = AutoLot;Integrated Security  = true") { }
        public InventoryDAL(string connectionString) => _connectionString = connectionString;

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

        public List<Car> GetAllInventory()
        {
            OpenConnection();
            List<Car> inventory = new List<Car>();

            string sql = "Select * From Inventory";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    inventory.Add(new Car
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    });
                }
                dataReader.Close();
            }
            return inventory;
        }

        public Car GetCar(int id)
        {
            OpenConnection();
            Car car = null;
            string sql = $"Select * From Inventory Where CarId = {id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    car = new Car
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    };
                }
                dataReader.Close();
            }
            return car;
        }


        public void InsertAuto(string color, string make, string PetName)
        {
            OpenConnection();
            string sql = $"Insert Into Inventory(Make,Color,PetName) Values('{make}','{color}','{PetName}')";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void InsertAuto(Car car)
        {
            OpenConnection();
            string sql = $"Insert Into Inventory(Make,Color,PetName) Values ('{car.Make}','{car.Color}','{car.PetName}')";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }

            CloseConnection();
        }


        public void InsertAutoUseDBParameters(Car car)
        {
            OpenConnection();
            string sql = $"Insert Into Inventory(Make,Color,PetName) Values (@Make,@Color,@PetName)";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@Make",
                    Value = car.Make,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Color",
                    Value = car.Color,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@PetName",
                    Value = car.PetName,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);


                command.ExecuteNonQuery();
            }

            CloseConnection();
        }


        public void DeleteCar(int id)
        {
            OpenConnection();
            string sql = $"Delete From Inventory Where CarId = {id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                try
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! That car is on order!", ex);
                    throw error;
                }
            }
            CloseConnection();
        }


        public void UpdateCarPetName(int id, string newPetName)
        {
            OpenConnection();
            string sql = $"Update Inventory Set PetName = '{newPetName}' Where CarId = {id}";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }

            CloseConnection();
        }



        //Use Stored Procedure
        public string LookUpPetName(int carId)
        {
            OpenConnection();

            string carPetName;
            using (SqlCommand command = new SqlCommand("GetPetName", _sqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                //Input Parameter
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@carId",
                    SqlDbType = SqlDbType.Int,
                    Value = carId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parameter);

                //Output Parameter
                parameter = new SqlParameter
                {
                    ParameterName = "@petName",
                    SqlDbType = SqlDbType.Char,
                    Size = 10,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

                carPetName = (string)command.Parameters["@petName"].Value;

                CloseConnection();
            }

            return carPetName;
        }



        public void ProccessCreditRisk(bool throwEx, int custId)
        {
            OpenConnection();

            string fName, lName;
            var cmdSelect = new SqlCommand($"Select * From Customers Where CustId = {custId}", _sqlConnection);

            using (var dataReader = cmdSelect.ExecuteReader())
            {

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    fName = (string)dataReader["FirstName"];
                    lName = (string)dataReader["LastName"];
                }
                else
                {
                    CloseConnection();
                    return;
                }
            }


            var cmdRemove = new SqlCommand($"Delete from Customers where CustId = {custId}", _sqlConnection);

            var cmdInsert = new SqlCommand($"Insert Into CreditRisks (FirstName, LastName) Values('{fName}', '{lName}')", _sqlConnection);
            SqlTransaction tx = null;
            try
            {
                tx = _sqlConnection.BeginTransaction();
                // Enlist the commands into this transaction.
                cmdInsert.Transaction = tx;
                cmdRemove.Transaction = tx;
                // Execute the commands.
                cmdInsert.ExecuteNonQuery();
                cmdRemove.ExecuteNonQuery();
                // Simulate error.
                if (throwEx)
                {
                    throw new Exception("Sorry! Database error! Tx failed...");
                }
                tx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                tx?.Rollback();
            }
            finally
            {
                CloseConnection();
            }


        }
    }
}
