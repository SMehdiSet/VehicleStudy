using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    abstract class Vehicle
    {
        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        private int topSpeed;

        public int TopSpeed
        {
            get { return topSpeed; }
            set { topSpeed = value; }
        }
        private int torque;

        public int Torque
        {
            get { return torque; }
            set { torque = value; }
        }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private int passengerCount;

        public int PassengerCount
        {
            get { return passengerCount; }
            set { passengerCount = value; }
        }
        private string bodyColore;

        public string BodyColore
        {
            get { return bodyColore; }
            set { bodyColore = value; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

    }


    abstract class Land : Vehicle
    {
        public enum NumberOfWheels
        {
            fourWheel = 4,
            threeWheel = 3,
            twoWheel = 2
        }
        public enum NumberOfDoors
        {
            twoDoor = 2,
            fourDoor = 4
        }
    }
    class FourWheel : Land 
    {
        NumberOfWheels WheelCount = NumberOfWheels.fourWheel;
    }
    class ThreeWheel : Land
    {
        NumberOfWheels WheelCount = NumberOfWheels.threeWheel;
    }
    class TwoWheel : Land
    {
        NumberOfWheels WheelCount = NumberOfWheels.twoWheel;
    }
    abstract class Sea : Vehicle
    {
        public enum SeaType
        {
            boat,
            ship,
            fighter,
            icebreaker,
            cargo
        }
    }
    abstract class Air : Vehicle
    {
        public enum AirType
        {
            commercial,
            fighter,
            Propeller,
            acrobat,
            cargo
        }
    }
}
