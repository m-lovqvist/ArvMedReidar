using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedReidar
{
    internal class Conferencechair : Chairs
    {
        private int _numberOfWheels {  get; set; }
        public Conferencechair(int numberOfWheels=2, string color="marin", int numberOfLegs=4, decimal retailPrice=1500m, string material="järnstomme med manchestertyg", string productName="tage", decimal productionCost=300m) : base(color, numberOfLegs, retailPrice, material, productName, productionCost)
        {
            _numberOfWheels = numberOfWheels;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"ID:{_productId}, {_productName} är en konferensstol i färgen {_color} har {_numberOfLegs} ben. Den har {_material}.");
        }
        public override void Profit()
        {
            Console.WriteLine($"Vinsten för {_productName} är {_retailPrice - _productionCost}.");
        }
    }
}
