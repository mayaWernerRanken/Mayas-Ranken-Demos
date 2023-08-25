using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesTransaction
{
    public class SalesTransaction
    {
        //Instance Fields
        private string _name;
        private decimal _salesAmount;
        private decimal _commissionAmount;


        //A readonly field can only be set in a constructor
        private readonly double _commissionRate;
        

        //The default constructor
        public SalesTransaction() {}


        //Constructor used to set all the values
        public SalesTransaction(string name, decimal saleAmount, double commissionRate)
        {
            _name = name;
            _salesAmount = saleAmount;
            _commissionRate = commissionRate;
            _commissionAmount = (decimal)_commissionRate * _salesAmount;
        }

        public SalesTransaction(string name, decimal saleAmount)
        {
            _name = name;
            _salesAmount = saleAmount;
            _commissionRate = 0;
            _commissionAmount = 0;

        }


        //Overridden ToString() method to read all the values
        public override string ToString()
        {
            return $"{_name} sold {_salesAmount:C} worth of inventory at a commission " +
                $"rate of {_commissionRate:p} for a total commission of {_commissionAmount:C}\n";
        }


    }
}
