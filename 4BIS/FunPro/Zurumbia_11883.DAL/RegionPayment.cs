using System;
using System.Collections.Generic;
using System.Text;

namespace Zurumbia_11883.DAL
{
    public class RegionPayment
    {
        private int _region;

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int Region
        {
            get => _region; 
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Region should be between 1 and 10");
                _region = value;
            }
        }

        public int Headcount { get; set; }

        public int Limit { get; set; }

        public decimal Paid { get; set; }

        public RegionPayment()
        {
        }
        public RegionPayment(DateTime date, int region, int headcount, int limit, decimal paid)
        {
            Date = date;
            Region = region;
            Headcount = headcount;
            Limit = limit;
            Paid = paid;
        }
    }
}
