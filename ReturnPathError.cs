using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class ReturnPathError : UserError
    {
        public override string UEMessage()
        {
            return "The method doesnt have a return on all code paths!";
        }
    }
}
