using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_for_lesson_1
{
    abstract class Vehicle : ISelling
    {
        private string _typeOfVehicle;

        protected internal Vehicle(string type)
        {
            _typeOfVehicle = type;
        }
        public void GetTypeOfVehicle() => Console.WriteLine($"The type of vehicle is {_typeOfVehicle}");
        public void UseVehicle() { }
        public void Sell(string reason, double price){}
        public void Buy(string purpose, double price){}
    }
}
