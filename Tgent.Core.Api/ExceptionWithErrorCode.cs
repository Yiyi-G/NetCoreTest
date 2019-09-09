using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tgnet.Core.Api
{

    public class ExceptionWithErrorCode : Tgnet.Core.Exception
    {
        public readonly ErrorCode ErrorCode;

        public ExceptionWithErrorCode(ErrorCode code)
            : this(code, code.Message)
        {

        }

        public ExceptionWithErrorCode(ErrorCode code, string message)
            : base(message)
        {
            this.ErrorCode = new ErrorCode(code.Code, message);
        }
    }

    //public class FaultExceptionWithErrorCode : System.ServiceModel.FaultException<ErrorCode>
    //{
    //    public FaultExceptionWithErrorCode(ErrorCode code)
    //        : base(code, code.Message) { 
    //    }

    //    public FaultExceptionWithErrorCode(ErrorCode code, string messgae)
    //        : base(String.IsNullOrWhiteSpace(messgae) ? code : new ErrorCode(code.Code, messgae), messgae ?? code.Message) { }
    //}
}
