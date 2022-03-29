using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurumbia_11883.DAL
{
    public class RegionPaymentList
    {
        public List<RegionPayment> GetRegionPayments()
        {
            return new RegionPaymentManager().GetAll();
        }

    }
}
