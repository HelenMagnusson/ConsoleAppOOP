using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class NotInstanciatedError : UserError
    {
        public override string UEMessage()
        {
            return "You failed to instanciate the object. This resulted in an error!";
        }
    }
}
