using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // IMPORTANT!, CHECK
        public Result(bool success, string message):this(success)
        {
            this.Message = message;
        }
        public Result(bool success)
        {
            this.Success = success;
        }
        // IMPORTANT!, CHECK
         

        public bool Success { get; }

        public string Message { get; }

    }
}
