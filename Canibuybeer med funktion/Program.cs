using System;

namespace Canibuybeer_med_funktion
{
    class Program
    {
       
        static bool CanIBuyBeer ( int age, string location, decimal promille, string legg)
        {
            if (legg != "J")
                return false;
                    if (promille > 1.0m)
                return false;
            if (age > 17 && location == "krogen")
                return true;
            if (age > 19 && location == "systemet")
                return true;
            return false;
        }

    }
}
