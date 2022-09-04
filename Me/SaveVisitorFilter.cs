using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;
using UAParser;
using VisitManagement.ApplicationContracts.Visitor;

namespace Me
{
    public class SaveVisitorFilter : IAsyncPageFilter
    {
        private readonly IVisitorApplication _visitorApplication;
        public SaveVisitorFilter(IVisitorApplication visitorApplication)
        {
            _visitorApplication = visitorApplication;
        }
        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            return Task.CompletedTask;
        }

        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            string visitorID;
            if (string.IsNullOrWhiteSpace(context.HttpContext.Request.Cookies["VisitorID"]))
            {
                visitorID = Guid.NewGuid().ToString();
                context.HttpContext.Response.Cookies.Append("VisitorID", visitorID,
                    new CookieOptions { Expires = DateTime.Now.AddYears(10) });
            }
            else
                visitorID = context.HttpContext.Request.Cookies["VisitorID"];

            if (Check(context.HttpContext))
            {
                string ip = context.HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
                var userAgent = context.HttpContext.Request.Headers["User-Agent"];
                var uaParser = Parser.GetDefault();
                ClientInfo clientInfo = uaParser.Parse(userAgent);
                var referer = context.HttpContext.Request.Headers["Referer"].ToString();

                _visitorApplication.Execute(new CreateVisitor
                {
                    Ip = ip,
                    FamilyOS = clientInfo.UA.Family,
                    Version = $"{clientInfo.UA.Major}.{clientInfo.UA.Minor}.{clientInfo.UA.Patch}",
                    Brand = clientInfo.Device.Brand,
                    FamilyDevice = clientInfo.Device.Family,
                    Model = clientInfo.Device.Model,
                    IsSpider = clientInfo.Device.IsSpider,
                    ReferrerLink = referer,
                    VisitID = visitorID,
                });
            }
            await next.Invoke();
        }

        public static bool Check(HttpContext context)
        {
            if (string.IsNullOrWhiteSpace(context.Request.Cookies["VisitorUser"]))
            {
                string key = Guid.NewGuid().ToString();
                context.Response.Cookies.Append("VisitorUser", key,
                    new CookieOptions { Expires = DateTime.Now.AddMinutes(10) });
                return true;
            }
            else
                return false;


        }

    }
}
