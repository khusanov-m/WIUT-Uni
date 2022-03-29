using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zurumbia_11883.DAL
{
    public class SocialWorkerList
    {
        public List<SocialWorker> GetSocialWorkers()
        {
            return new SocialWorkerManager().GetAll();
        }

        public List<SocialWorker> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetSocialWorkers().OrderBy(a => a.Name).ToList();
                case ByAttribute.Hour:
                    return GetSocialWorkers().OrderBy(a => a.Hours).ToList();
                case ByAttribute.Region:
                    return GetSocialWorkers().OrderBy(a => a.Region).ToList();
            }
            //if we are here - something went wrong
            return null;
        }

        private class ByNameComparer : IComparer<SocialWorker>
        {
            public int Compare(SocialWorker x, SocialWorker y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }

        private class ByHourComparer : IComparer<SocialWorker>
        {
            public int Compare(SocialWorker x, SocialWorker y)
            {
                return string.Compare(x.Hours.ToString(), y.Hours.ToString());
            }
        }

        private class ByRegionComparer : IComparer<SocialWorker>
        {
            public int Compare(SocialWorker x, SocialWorker y)
            {
                return string.Compare(x.Region.ToString(), y.Region.ToString());
            }
        }

        public List<SocialWorker> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Id:
                    return GetSocialWorkers().Where(a => Convert.ToInt32(a.Id) == Convert.ToInt32(value)).ToList();
                case ByAttribute.Region:
                    return GetSocialWorkers().Where(a => Convert.ToInt32(a.Region) == Convert.ToInt32(value)).ToList();
                case ByAttribute.Name:
                    return GetSocialWorkers().Where(a => a.Name.ToUpper().Contains(value.ToUpper())).ToList();
            }
            //if we are here - something went wrong
            return null;
        }
    }
}
