using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantCore.BLL
{
    public class RestaurantData
    {
        private RestaurantData() { }

        private static RestaurantData _singleton;

        public static RestaurantData Instance
        {
            get
            {
                if (_singleton == null)
                {
                    _singleton = new RestaurantData();
                }

                return _singleton;
            }
              
        }

        private List<string> Restaurants()
        {
            List<string> output = new List<string>();
            output.Add("Araya");
            output.Add("Jimmy Johns");
            output.Add("Sarducci");
            output.Add("Chipotle");
            output.Add("A Burger Place");
            output.Add("Trinity Market");
            output.Add("Qdoba");
            output.Add("Cultivate");
            output.Add("Guanaco's Taqueria");
            output.Add("Korean Tofu House");
            output.Add("Noodle Nation");
            output.Add("Jewel of India");
            output.Add("Pagliacci");
            output.Add("Thai 65");
            output.Add("Pho Tran");
            output.Add("Than Vi");
            output.Add("Ban Mi Unwrapped");
            output.Add("Subway");
            output.Add("Teriyaki Plus");
            output.Add("Nasai Teriyaki");
            output.Add("Best of Bento");
            output.Add("MOD Pizza");
            output.Add("Schultzy's");
            output.Add("Big Time");
            output.Add("China First");
            output.Add("Flowers");
            output.Add("Cedars of Lebanon");
            output.Add("Cedars");
            output.Add("Samir's");
            output.Add("Aladdin Gyrocery");
            output.Add("U Don");
            output.Add("Samurai Noodle");
            output.Add("Shalimar");
            output.Add("University Teriyaki");
            output.Add("Henry's Tawain");
            output.Add("Orange King");
            output.Add("Taco del Mar");

            return output;

        }

        public string GetRandomRestaurant()
        {
            var restaurants = Restaurants();

            int randomNum = new Random().Next(0, restaurants.Count - 1);

            return restaurants[randomNum];

        }
    }
}
