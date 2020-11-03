using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class RandomArgumentsException : Exception
    {
        //public int MyField;

        //public int MyProperty
        //{
        //    get
        //    {
        //        //.........
        //        return MyProperty / 2;
        //    }
        //    set 
        //    { 
        //        MyProperty = value * 100; 
        //    }
        //}
        //public override string Message => "Min range is greater then max range";
        public override string Message
        {
            get
            {
                return "Min range is greater then max range";
            }
        }
    }

}

