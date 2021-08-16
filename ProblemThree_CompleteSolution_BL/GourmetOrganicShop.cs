using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double TotalBillValue { get; set; }

        

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int,double> iPrice):base(iCode,iName) { ItemPrice = iPrice; }

        public override double PayPerPiece(int quantity)
        {
            double total = 0;
            int count;
            if (quantity == 1)
            {
                return ItemPrice[quantity];
            }
            else
            {
                count = quantity;
                while (count != 0)
                {   
                    total += ItemPrice[quantity];
                    count--;
                }return total;
            }
        }

        public override double PayPerWeight(int weight)
        {
            return ItemPrice[weight];
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }
    }
}
