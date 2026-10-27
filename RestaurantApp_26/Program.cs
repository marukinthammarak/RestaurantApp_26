using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Quanjude Roast Duck", Type = "Beijing Cuisine", Rating = 4.5 },
                new Restaurant { Id = 2, Name = "Donglaishun Hot Pot", Type = "Hot Pot", Rating = 4.6 },
                new Restaurant { Id = 3, Name = "Din Tai Fung", Type = "Taiwanese Cuisine", Rating = 4.7 },
                new Restaurant { Id = 4, Name = "Huguosi Snacks", Type = "Snacks", Rating = 4.2 },
                new Restaurant { Id = 5, Name = "Haidilao Hot Pot", Type = "Hot Pot", Rating = 4.8 },
                new Restaurant { Id = 6, Name = "Siji Minfu", Type = "Beijing Cuisine", Rating = 4.6 }
            };

        }
    }
}
