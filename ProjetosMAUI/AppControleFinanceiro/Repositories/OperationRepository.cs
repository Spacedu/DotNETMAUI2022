using AppControleFinanceiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Repositories
{
    public class OperationRepository
    {
        public List<Operation> GetOperations(DateTimeOffset date)
        {
            return new List<Operation>
            {
                new Operation { 
                    Id = 1,
                    OperationType = OperationType.Income,
                    Name = "Salário", 
                    Date = new DateTimeOffset(2022, 10, 10, 0,0,0, new TimeSpan(0, -3, 0,0)),                    
                    Value = 3600                    
                },
                new Operation {
                    Id = 2,
                    OperationType = OperationType.Expenses,
                    Name = "Feira no mercado",
                    Date = new DateTimeOffset(2022, 10, 11, 0,0,0, new TimeSpan(0, -3, 0,0)),
                    Value = 600
                },
                new Operation {
                    Id = 3,
                    OperationType = OperationType.Expenses,
                    Name = "Sapato",
                    Date = new DateTimeOffset(2022, 10, 21, 0,0,0, new TimeSpan(0, -3, 0,0)),
                    Value = 200
                },
                new Operation {
                    Id = 4,
                    OperationType = OperationType.Expenses,
                    Name = "Lanche",
                    Date = new DateTimeOffset(2022, 10, 21, 0,0,0, new TimeSpan(0, -3, 0,0)),
                    Value = 40
                },
            };
        }
        public void AddOperations(Operation operation)
        {
            throw new NotImplementedException();
        }
        public void DeleteOperations(Operation operation) {
            throw new NotImplementedException();
        }
    }
}
