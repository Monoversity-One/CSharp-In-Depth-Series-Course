using System.Data;
using Microsoft.Data.SqlClient;

namespace _07.LINQ.AutoLotDAL.BulkImport
{
    public class ProcessBulkImport
    {
        private static SqlConnection _sqlConnection = null;
        private static readonly string _connectionString =@"Data Source = .\SQLSERVER17;Integrated Security=true;Catalog=AutoLot";
        private static void OpenConnection()
        {
            _sqlConnection = new SqlConnection { ConnectionString = _connectionString };
            _sqlConnection.Open();
        }
        private static void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection?.Close();
            }
        }

        public static void ExecuteBulkImport<T>(IEnumerable<T> records, string tableName)
        {
            OpenConnection();
            using (SqlConnection conn = _sqlConnection)
            {
                SqlBulkCopy bc = new SqlBulkCopy(conn)
                {
                    DestinationTableName = tableName
                };
                var dataReader = new MyDataReader<T>(records.ToList());
                try
                {
                    bc.WriteToServer(dataReader);
                }
                catch (Exception ex)
                {
                    //Should do something here
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

    }
}
