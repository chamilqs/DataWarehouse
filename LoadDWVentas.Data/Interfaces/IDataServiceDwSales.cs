using LoadDWVentas.Data.Entities.DWSales;
using LoadDWVentas.Data.Result;

namespace LoadDWVentas.Data.Interfaces
{
    public interface IDataServiceDwSales
    {
        Task<OperationResult> LoadDWH();
    }
}