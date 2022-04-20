using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Model
{
    public abstract class ReturnProcessTemplate 
    { 
        protected abstract void GenerateReturnTransactionFor(ReturnOrder returnOrder); 
        protected abstract void CalculateRefundFor(ReturnOrder returnOrder); 
        public void Process(ReturnOrder returnOrder) 
        { 
            GenerateReturnTransactionFor(returnOrder);
            CalculateRefundFor(returnOrder); 
        } 
    }
}
