using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Models
{
    class Meals
    {
        public int MealId { get; set; }
        public string MealDay { get; set; }
        public string MealItem { get; set; }
        public string MealImage { get; set; }
        public Meals(int _mealId,string _mealDay, string _mealItem, string _mealImage)
        {
            this.MealId = _mealId;
            this.MealDay = _mealDay;
            this.MealItem = _mealItem;
            this.MealImage = _mealImage;
        }
    }
}
