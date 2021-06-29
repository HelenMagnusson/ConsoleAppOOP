using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class DivideByZeroError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to divide by zero which is not allowed. This resulted in an error!";
        }
    }
}
