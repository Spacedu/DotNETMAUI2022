using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public OperationType OperationType { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public double Value { get; set; }
    }

    public enum OperationType
    {
        Income,
        Expenses
    }
}
