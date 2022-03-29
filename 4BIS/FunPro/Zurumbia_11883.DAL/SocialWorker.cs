using System;
using System.Collections.Generic;
using System.Text;

namespace Zurumbia_11883.DAL
{
    public class SocialWorker
    {

        private string _name;
        private decimal _hours;
        private int _region;
        private decimal _rate;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty");
                _name = value;
            }
        }

        public int Region
        {
            get => _region;
            set
            {
                if (value < 1 || value > 10)
                    throw new Exception("Region should be between 1 and 10");
                _region = value;
            }
        }

        public decimal Rate
        {
            get => _rate;
            set
            {
                if (value < 0)
                    throw new Exception(" Rate cannot be negative");
                _rate = value;
            }
        }

        public decimal Hours
        {
            get => _hours;
            set
            {
                if (value < 0)
                    throw new Exception("Please, write hours correct");
                _hours = value;
            }
        }

        public SocialWorker()
        { }

        public SocialWorker(string name, int region, decimal hours, decimal rate )
        {
            Name = name;
            Region = region;
            Hours = hours;
            Rate = rate;
        }
    }
}
