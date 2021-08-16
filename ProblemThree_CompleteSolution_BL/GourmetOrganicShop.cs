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

        

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int,double> iPrice) { }

        public override double PayPerPiece(int quantity)
        {
            throw new NotImplementedException();
        }

        public override double PayPerWeight(int weight)
        {
            throw new NotImplementedException();
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }
    }
}
