using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
     class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Product Id=" + Id + "\nProduct Name =" + Name + "\nActual Price=" + Price;
        }
        public double CalculateDiscount(double disPer)
        {
            double DiscountAmount = Price * disPer / 100;
            double AmtAfterDisco = Price - DiscountAmount;
            return AmtAfterDisco;
        }

    }

}
