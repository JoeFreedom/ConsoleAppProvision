using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProvision
{
    public enum SteakType { Beef, Pork, Chicken, Rabbit}
    public enum DonenessType { Rare, Medium, Well_Done }
    public class MeatAndSteak : Provision, IProvision
    {
        public SteakType Steak { set; get; }
        public DonenessType Doneness { set; get; }

        public event CookingHint Info;
        public event CookingHint Error;

        public MeatAndSteak()
        {           
        }
        public MeatAndSteak(int weight, FoodClassType foodClass, SteakType steakType, DonenessType doneness )
        {
            Weight = weight;
            FoodClass = foodClass;
            Steak = steakType;
            Doneness = doneness;
        }

        public void SteakPreparation(SteakType steakType, DonenessType doneness, int weight) 
        {
          
            if(steakType == SteakType.Beef)
            {
                Info?.Invoke("-------------THIS IS A HINT----------------");
                Info?.Invoke("Your STEAK was made from COW");
                Info?.Invoke("");
            }
            else if(steakType == SteakType.Chicken)
            {
                Info?.Invoke("-------------THIS IS A HINT----------------");
                Info?.Invoke("Your STEAK was made from A BIRD");
                Info?.Invoke("");
            }
            else if(steakType == SteakType.Pork)
            {
                Info?.Invoke("-------------THIS IS A HINT----------------");
                Info?.Invoke("Your STEAK was made from PIG");
                Info?.Invoke("");
            }
            else
            {
                Info?.Invoke("-------------THIS IS A HINT----------------");
                Info?.Invoke("You are eating a STEAK from RABBIT");
                Info?.Invoke("");
            }

                if (weight < 300)
            {
                Info?.Invoke("----------------------------OOOOPPPS-------------------------------");
                Error?.Invoke("Unfortunately, you need a weight above 300 gram to make a portion!");
                Info?.Invoke("----------------------------OOOOPPPS-------------------------------");
            }
            else
            {
                if (doneness == DonenessType.Rare)
                {
                    Info?.Invoke("*******READY*****READY**********READY********");
                    Info?.Invoke("Your steak Doneness is Rare!!!");
                    Info?.Invoke("*********************************************");
                }
                else if (doneness == DonenessType.Medium)
                {
                    Info?.Invoke("********READY******READY*******READY**********");
                    Info?.Invoke("Your steak Doneness is Medium!!!");
                    Info?.Invoke("**********************************************");
                }
                else
                {
                    Info?.Invoke("******READY********READY***********READY**********");
                    Info?.Invoke("Your steak Doneness is Well-done!!!");
                    Info?.Invoke("**************************************************");
                }
            }

        }
        

    

        

        
    }
}
