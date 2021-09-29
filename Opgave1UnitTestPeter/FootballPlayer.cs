using System;

namespace Opgave1UnitTestPeter
{
    public class FootballPlayer
    {

        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentException("name length has to be longer than 4 characters");
                _name = value;
            }
        }

        /// <summary>
        /// price has to be greater than 0
        /// </summary>
        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("price has to be larger than 0");
                _price = value;
            }
        }

        /// <summary>
        /// The ShirtNumber has to be inbetween 1 and 100, if its greater the method won't work.
        /// </summary>
        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value <= 1 || value >= 100) throw new ArgumentException("ShirtNumber has to be between 1 or 100");
                _shirtNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

