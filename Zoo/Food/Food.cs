using System;

namespace Zoo
{
    class Food
    {
        private int _caloriesPerKilogram;
        public int CaloriesPerKilogram
        {
            get { return _caloriesPerKilogram; }
            set
            {
                if (value > 0)
                {
                    _caloriesPerKilogram = value;
                }
                else throw new MyException("The calories must be greater then 0",MessageType.Error);
            }
        }
        public int TotalCalories { get; set; }
        public FoodType FoodType { get; set; }
        public Food(int calories,FoodType foodType)
        {
            CaloriesPerKilogram = calories;
            FoodType = foodType;
        }

        public override string ToString()
        {
            return $"{CaloriesPerKilogram} calories";
        }
    }
}
