using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._14
{
    public enum Category
    {
        Food,
        HouseholdAppliances,
        Transport,
        Technics
    }
    internal class Product
    {
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        public override string ToString()
        {
            return NameProduct;
        }
    }
}
