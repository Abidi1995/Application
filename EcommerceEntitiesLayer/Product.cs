using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceEntitiesLayer3
{
    public class Product :BaseEntities//Product Table
    {

   
        public decimal Price { get; set; }
        public Catagory Catagory { set; get; }//RelationShip between Product and Catagory
    }
}
