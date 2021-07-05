using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceEntitiesLayer3
{
    public class Catagory:BaseEntities
    {
       
        public List<Product> Products { get; set; }//Catagory has List of Products
    }
}
