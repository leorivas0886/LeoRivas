using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoRivas.Core.CustomExceptionsandGuardClauses
{
    public class ApiExeption : ApiResponse
    {
        public ApiExeption(int statusCode, string message, string details) : base(statusCode, message)
        {
            Details = details;
        }

        public string Details { get; set; }
    }
}
