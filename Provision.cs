using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProvision
{
    public enum FoodClassType { Protein, Vitamin, Fat, Carbohydrate}
    public abstract class Provision
    {
        public int Weight { set; get; }
        public FoodClassType FoodClass { set; get; }
       
    }
}
