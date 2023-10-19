using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedReidar
{
    internal class Deskchair : Chairs
    {
        private int _wheels {  get; set; }
        public Deskchair(int wheels=4, string color="isbjörnsvit", int numberOfLegs=1, decimal retailPrice=2800m, string material="järnstomme med skinnklädd sits och ryggstöd", string productName="rudolf", decimal productionCost=490m) : base(color, numberOfLegs, retailPrice, material, productName, productionCost)
        {
            _wheels = wheels;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"ID: {_productId}, {_productName} är en skrivbordsstol i färgen {_color} har {_numberOfLegs} ben. Den har {_material}.");
        }
        public override void Profit()
        {
            Console.WriteLine($"Vinsten för {_productName} är {_retailPrice - _productionCost}.");
        }
    }
}
