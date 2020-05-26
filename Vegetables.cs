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
        public Vegetables(int weight, VegetableName vegetableName)
        {
            Weight = weight;
            Vegetable = vegetableName;
           
        }

        public void SaladPreparation(int weight, VegetableName vegetableName)
        {
            if(weight < 50 && VegetableName.Onion) // weight is in grams
            {
                Info?.Invoke("You should add more gramms of Cilantro!");
            }
            else if(weight > 100  && VegetableName.Onion)
            { 
                Info?.Invoke("The amount of Cilantro in the salad you are making can't be used in ONE PORTION!!!");
            }
            else if(weight < 5 && VegetableName.Cucumber) // weight is in grams
            {
                Info?.Invoke("You should add more Cucumber!");
            }
            else if(weight > 10  && VegetableName.Cucumber)
            { 
                Info?.Invoke("The amount of Cucumber in the salad you are making can't be used in ONE PORTION!!!");
            }
            else
            {
                Info?.Invoke("For the rest you can use as many");
            }
        }
        


    }
}
