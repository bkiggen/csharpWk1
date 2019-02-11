using System;

namespace Dealership
{

    class Car
    {
        private string _makeModel;
        private int _price;
        private int _miles;
        private static List<Car> _instances = new List<Car> {};

        public static List<Car> GetAll()
        {
            return _instances;
        }
        public Car(string makeModel, int price, int miles)
        {
            _makeModel = makeModel;
            _price = price;
            _miles = miles;
            _instances.Add(this);
        }

        public string GetMakeModel()
        {
            return _makeModel;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetMiles()
        {
            return _miles;
        }

        public bool WorthBuying(int maxPrice)
        {
            return (_price < maxPrice);
        }
    }

}