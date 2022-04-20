using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Model
{
    public class ReturnOrderService
    {
        public void Process(ReturnOrder returnOrder)
        {
            ReturnProcessTemplate returnProcess = ReturnProcessFactory.CreateFrom(returnOrder.Action);
            returnProcess.Process(returnOrder);             
            // Code to refund the money back to the customer...
        }
    }
}
