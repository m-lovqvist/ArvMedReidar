using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedReidar
{
    internal class Furniture
    {
        protected decimal _retailPrice {  get; set; }
        protected string _material { get; set; }
        protected string _productName { get; set; }
        protected int _productId { get; set; }
        protected static int _referensId  = 0;
        protected decimal _productionCost { get; set; }
    public Furniture(decimal retailPrice=2500m, string material="järnstomme med skinnklädd sits och ryggstöd", string productName="olga", decimal productionCost=485m)
    {
            GetProductId();

            _productId = GetProductId();
            _referensId++;
            _retailPrice = retailPrice;
            _material = material;
            _productName = productName;
            _productionCost = productionCost;
    }
    protected int GetProductId()
        {
            return _referensId++;
        }
        public virtual void Profit()
        {
            Console.WriteLine($"The profit for {_productName} is {_retailPrice - _productionCost}");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"id: {_productId}, productName: {_productName}, material: {_material}, productionCost: {_productionCost}, retailPrice: {_retailPrice}");
        }
    }
}
