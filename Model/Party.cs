using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Model
{
    internal class Party
    {
        // variables ESTATICAS
        static double FIXED_COST_PERSON  = 25.0d;  // COSTE FIJO POR PERSONA.

        static double REGULAR_DECORATION_PERSON = 7.50d;    // Adicional por persona, decoración normal
        static double REGULAR_DECORATION_FIXED = 30.0d;     // Fijo para decoración normal.
        static double LUXE_DECORATION_PERSON = 15.0d;       // Adicional por persona, decoración de lujo
        static double LUXE_DECORATION_FIXED = 50.0d;        // Fijo para decoración de lujo.


        // variables de INSTANCIA
        int NumberOfPeople = 0;
        double DecorationCost = 0d;
        bool isLuxeDecoration = false;
        



    }
}
