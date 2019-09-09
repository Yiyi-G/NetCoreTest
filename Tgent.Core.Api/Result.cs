using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tgnet.Core.Api
{
    public class Result
    {
        public static Result UnResponse = new Result();

        public string state_code { get; set; }
        public string message { get; set; }
        public string help_link { get; set; }
    }

    public class Result<T> : Result
    {
        public T data { get; set; }
    }
}
