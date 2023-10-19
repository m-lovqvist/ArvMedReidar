using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedReidar
{
    internal class Bed : Furniture
    {
        protected int _legs, capacity;

        public Bed(decimal retailPrice, string material, decimal productionCost, string productName, int legs) : base(retailPrice, material, productName, productionCost)
        {
            _legs = legs;
        }

        public void Sleep(int people)
        {
            if (people <= capacity)
            {
                Console.WriteLine($"{people} sleep in the bed. ");
            }
            else
            {
                Console.WriteLine($"There is no room in the bed '{_productName}' for {people} people. ");
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"id: {_productId}, productName: {_productName}, material: {_material}, productionCost: {_productionCost}, retailPrice: {_retailPrice}, legs: {_legs}, capacity: {capacity}");
        }
    }

    internal class SingleBed : Bed
    {
        public SingleBed(decimal retailPrice, string material, decimal productionCost, string productName, int legs) : base(retailPrice, material, productionCost, productName, legs)
        {
            capacity = 1;
        }
    }

    internal class DoubleBed : Bed
    {
        public DoubleBed(decimal retailPrice, string material, decimal productionCost, string productName, int legs) : base(retailPrice, material, productionCost, productName, legs)
        {
            capacity = 2;
        }
    }
}
