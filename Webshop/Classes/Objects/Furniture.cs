using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.Classes.Objects
{
    public class Furniture
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }

        public int NumberInStock { get; set; }
        public int ItemNumber { get; set; }
    }
}