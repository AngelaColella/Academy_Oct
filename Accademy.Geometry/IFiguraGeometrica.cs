using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Geometry
{
    public interface IFiguraGeometrica
    {
        double GetArea();
        double GetPerimetro();

        // NON potrei inserire un metodo GetDiagonale perchè non si potrebbe usare per Cerchio 
        // e quando una classe eredita un'interfaccia, essa deve NECESSARIAMENTE implementarne tutti i metodi
    }
}
