using System.Collections.Generic;
using System.Data;

namespace _08_1.AdoNetConnectedLayer.AutoLotDAL.BulkImport
{
    public interface IMyDataReader<T> : IDataReader
    {
        List<T> Records { get; set; }
    }
}
