using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Repositories
{
    public interface IOperationRepository
    {
        void AddOperations(Operation operation);
        void DeleteOperations(Operation operation);
        List<Operation> GetOperations(DateTimeOffset date);
    }
}