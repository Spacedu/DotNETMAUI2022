using AppControleFinanceiro.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        LiteDatabase _db;
        public OperationRepository()
        {
            _db = new LiteDatabase(AppSettings.DatabaseConnection);
        }
        public List<Operation> GetOperations(DateTimeOffset date)
        {
            //TODO - Filtrar consulta
            var collection = _db.GetCollection<Operation>("operations");
            return collection.Query().ToList();
        }
        public void AddOperations(Operation operation)
        {
            var collection = _db.GetCollection<Operation>("operations");
            collection.Insert(operation);
            collection.EnsureIndex(x => x.Name);
        }
        public void DeleteOperations(Operation operation)
        {
            var collection = _db.GetCollection<Operation>("operations");
            collection.Delete(operation.Id);
        }
    }
}
