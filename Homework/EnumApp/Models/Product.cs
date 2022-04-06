using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace Models
{
    public class Product
    {
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price  { get; set; }
        public ProductType Type { get; set; }
        public Product()
        {
            _no++;
            No = _no;
        }


    }
}
