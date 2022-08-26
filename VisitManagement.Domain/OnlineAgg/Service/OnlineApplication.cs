using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitManagement.Domain.OnlineAgg.Service
{
    public static class OnlineApplication
    {
        private static List<Online> onlines = new List<Online>();


        public static void Add(Online online) => onlines.Add(online);


        private static void Remove()
        {
            var quit = onlines.Where(x => x.Time < DateTime.Now);

            if (quit != null)
            {
                foreach (var item in quit)
                {
                    onlines.Remove(item);
                }
            }
        }


        public static int GetOnlineCount()
        {
            Remove();
            return onlines.Count();
        }

        public static void Update(string key)
        {
            var online = onlines.SingleOrDefault(x => x.Key == key);
            onlines.Remove(online);
            online.Time = DateTime.Now.AddMinutes(10);
            onlines.Add(online);     
        } 


    }
}
