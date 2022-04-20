using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Model
{
    public class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid;
        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            //to be implemented
            throw new NotImplementedException();
        }
    }
}
