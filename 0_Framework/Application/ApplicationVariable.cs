using Microsoft.AspNetCore.Http;

namespace _0_Framework.Application
{
    public class ApplicationVariable
    {
        private readonly RequestDelegate _next;

        public ApplicationVariable( RequestDelegate next)
        {
            _next = next;
        }
    }
}
