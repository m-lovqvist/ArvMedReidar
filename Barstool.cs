using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedReidar
{
    internal class Barstool : Chairs
    {

        public Barstool(string color="svart", int numberOfLegs=3, decimal retailPrice=899m, string material="järnstomme med skinnklädd sits", string productName="torbjörn", decimal productionCost=160m) : base(color, numberOfLegs, retailPrice, material, productName, productionCost)
        {

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"ID: {_productId}, {_productName} är en barstol i färgen {_color} har {_numberOfLegs} ben. Den har {_material}. ");
        }
        public override void Profit()
        {
            Console.WriteLine($"Vinsten för {_productName} är {_retailPrice - _productionCost}. ");
        }
}
}
