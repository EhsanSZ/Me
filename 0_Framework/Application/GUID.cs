using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Application
{
    public static class MyGUID
    {
        public static string GUID()
        {
            return (new Random().Next(1000, 1000000)).ToString() + "-" + 
                (new Random().Next(5000, 90000) * DateTime.Now.Second);
        }  
        
    }
}
