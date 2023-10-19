using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedReidar
{
    internal class Chairs : Furniture
    {
        protected string _color {  get; set; }
        protected int _numberOfLegs { get; set; }

        public Chairs(string color ="oxblod", int numberOfLegs=4, decimal retailPrice=599m, string material="trästomme med skinnklädsel", string productName="evert", decimal productionCost=180m) : base(retailPrice, material, productName, productionCost)
        {
            _color = color;
            _numberOfLegs = numberOfLegs;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"ID: {_productId}, {_productName} i färgen {_color} har {_numberOfLegs} ben. Den har {_material}");
        }
        public override void Profit()
        {
            Console.WriteLine($"Vinsten för {_productName} är {_retailPrice - _productionCost}");
        }
    }
}
