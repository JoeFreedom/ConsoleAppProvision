using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProvision
{
    public enum VegetableName { Cucumber, Corn, Onion, Cilantro, Parsley, Carrot }
    public class Vegetables : Provision, IProvision
    {
        public VegetableName Vegetable { set; get; }
        public event CookingHint Info;
        public event CookingHint Error;

        public Vegetables(){}
        public Vegetables()
        {
        }

        public SaladPreparation()
        {

        }
        


    }
}
