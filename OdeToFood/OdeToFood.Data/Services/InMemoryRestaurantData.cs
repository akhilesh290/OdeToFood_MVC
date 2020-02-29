using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Id=1,
                    Name="Red Ant",
                    Cuisine=CuisineType.Indian
                },
                new Restaurant
                {
                    Id=2,
                    Name="Hotel Spice Chilly",
                    Cuisine=CuisineType.French
                },
                new Restaurant
                {
                    Id=3,
                    Name="Rising",
                    Cuisine=CuisineType.Italian
                }

            };
        }
        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
