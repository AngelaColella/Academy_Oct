using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class RandomArgumentsException : Exception
    {
        public override string Message // se si va sulla definition di Exception, si nota che il Message è virtual, quidni se ne può fare l'override
        {
            get
            {
                return "Min range is greater then max range";
            }
        }
    }

}

