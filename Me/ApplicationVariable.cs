//using Microsoft.AspNetCore.Http;
//using System;
//using System.Threading.Tasks;
//using VisitManagement.Domain.OnlineAgg;
//using VisitManagement.Domain.OnlineAgg.Service;


//namespace Me
//{
//    public class ApplicationVariable
//    {
//        private readonly RequestDelegate _next;

//        public ApplicationVariable(RequestDelegate next)
//        {
//            _next = next;
//        }


//        public async Task Invoke(HttpContext context)
//        {

//            if (Check(context))
//            {
//                string key = Guid.NewGuid().ToString();
//                OnlineApplication.Add(new Online() { Key = key, Time = DateTime.Now.AddMinutes(5) });

//                context.Response.Cookies.Append("OnlineUser", key,
//                    new CookieOptions { Expires = DateTime.Now.AddMinutes(5) });
//                //context.Session.SetString("OnlineUser", key);
//            }
//            else
//            {
//                string key = GetKey(context);
//                OnlineApplication.Update(key);
//                context.Response.Cookies.Delete("OnlineUser",
//                    new CookieOptions { Expires = DateTime.Now.AddMinutes(5) });
//                //context.Session.Remove("OnlineUser");
//                //context.Session.SetString("OnlineUser", key);
//            }

//            await _next.Invoke(context);

//        }

//        public static bool Check(HttpContext context)
//        {
//            if (string.IsNullOrWhiteSpace(context.Request.Cookies["OnlineUser"]))
//            {
//                //if (string.IsNullOrWhiteSpace(context.Session.GetString("OnlineUser")))
//                //{
//                    return true;
//                //}
//            }
//            return false;
//        }


//        public static string GetKey(HttpContext context)
//        {
//            //if (!string.IsNullOrWhiteSpace(context.Request.Cookies["OnlineUser"]))
//                return context.Request.Cookies["OnlineUser"];
//            //return context.Session.GetString("OnlineUser");
//        }

//    }

//}
