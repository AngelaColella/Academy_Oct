using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Device : IPrintLetter
    {
        public void StampaLettera(string testo)
        {
            string txt = testo.ToUpper();
            Console.WriteLine(txt);
        }
    }
}
