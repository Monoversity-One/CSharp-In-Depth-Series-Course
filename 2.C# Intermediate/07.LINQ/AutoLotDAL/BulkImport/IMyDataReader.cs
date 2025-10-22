using System.Data;

namespace _07.LINQ.AutoLotDAL.BulkImport
{
    public interface IMyDataReader<T> : IDataReader
    {
        List<T> Records { get; set; }
    }
}
