using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedReidar
{
    internal class Rockingchair : Chairs
    {
        private string _movement {  get; set; }

        public Rockingchair(string movement="gungar", string color="svart", int numberOfLegs=0, decimal retailPrice=2500m, string material="trästomme med tygklädd sits och ryggstöd", string productName="tjomme", decimal productionCost=500) : base(color, numberOfLegs, retailPrice, material, productName, productionCost)
        {
            _movement = movement;
        }
        public void Rocking()
        {
            Console.Write("Gungstolen gungar. ");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"ID: {_productId}, {_productName} är en gungstol i färgen {_color} har {_numberOfLegs} ben. Den har {_material}. ");
        }
        public override void Profit()
        {
            Console.WriteLine($"Vinsten för {_productName} är {_retailPrice - _productionCost}. ");
        }
}
}
