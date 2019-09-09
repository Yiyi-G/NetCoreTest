using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tgnet.Core
{
    [Serializable]
    public class Exception : System.Exception
    {
        protected Exception() { }
        public Exception(string message) : base(message) { }
        public Exception(string message, System.Exception innerException) : base(message, innerException) { }
        public Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class ArgumentException : Exception
    {
        public ArgumentException() : base() { }
        public ArgumentException(string message) : base(message) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="paramName">参数名</param>
        public ArgumentException(string message, string paramName) : base(message + "参数名称：" + paramName) { }
    }

    [Serializable]
    public class ArgumentNullException : ArgumentException
    {
        public ArgumentNullException() : base() { }
        public ArgumentNullException(string message) : base(message) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="paramName">参数名</param>
        public ArgumentNullException(string message, string paramName) : base(message, paramName) { }
    }

    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, System.Exception innerException) : base(message, innerException) { }
        public NotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException() : base("用户不存在") { }
        public UserNotFoundException(string username) : base("帐号：“" + username + "”不存在。") { }
    }

    [Serializable]
    public class AuthorizationException : Exception
    {
        public AuthorizationException(string message) : base(message) { }
        public AuthorizationException(string message, System.Exception innerException) : base(message, innerException) { }
        public AuthorizationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class LockException : Exception
    {
        public LockException(string message) : base(message) { }
        public LockException(string message, System.Exception innerException) : base(message, innerException) { }
        public LockException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class NotAllowException : Exception
    {
        public NotAllowException(string message) : base(message) { }
        public NotAllowException() : base() { }
    }
}
