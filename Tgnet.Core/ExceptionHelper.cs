using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tgnet.Core
{
    public static class ExceptionHelper
    {
        public static void ThrowIfNull<T>(T param, string paramName, string message = null)
            where T : class
        {
            if (param == null)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentNullException(message, paramName);
                else
                    throw new ArgumentNullException("参数错误", paramName);
        }

        public static void ThrowIfNullOrEmpty(string param, string paramName, string message = null)
        {
            if (String.IsNullOrEmpty(param))
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }

        public static void ThrowIfNullOrEmpty<T>(T[] param, string paramName, string message = null)
        {
            if (param == null || param.Length == 0)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }

        public static void ThrowIfNullOrEmpty<TKey, TValue>(IDictionary<TKey, TValue> param, string paramName, string message = null)
        {
            if (param == null || param.Count == 0)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }

        public static void ThrowIfNullOrEmpty<T>(IEnumerable<T> param, string paramName, string message = null)
        {
            if (param == null || param.Count() == 0)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }

        public static void ThrowIfNullOrEmptyIds(ref IEnumerable<long> param, string paramName, string message = null)
        {
            if (param == null || (param = param.Where(id => id > 0).Distinct()).Count() == 0)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }

        public static void ThrowIfNullOrEmptyIds(ref long[] param, string paramName, string message = null)
        {
            if (param == null || (param = param.Where(id => id > 0).Distinct().ToArray()).Length == 0)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }

        public static void ThrowIfNullOrWhiteSpace(string param, string paramName, string message = null)
        {
            if (String.IsNullOrWhiteSpace(param))
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }

        public static void ThrowIfNotId(long id, string paramName, string message = null)
        {
            if (id <= 0)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException(paramName + " 必须大于 0", paramName);
        }

        public static void ThrowIfNotId(long? id, string paramName, string message = null)
        {
            if (!id.HasValue || id.Value <= 0)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException(paramName + " 必须大于 0", paramName);
        }

        public static void ThrowIfTrue(bool result, string paramName, string message = null)
        {
            if (result)
                if (!String.IsNullOrEmpty(message))
                    throw new ArgumentException(message, paramName);
                else
                    throw new ArgumentException("参数错误", paramName);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="paramName">参数名称</param>
        /// <exception cref="Tgnet.ArgumentNullException"></exception>
        [Obsolete("使用ThrowIfNull代替", true)]
        public static void ArgumentNull<T>(T param, string message = null, string paramName = null)
            where T : class
        {
            if (param == null)
            {
                throw GetArgumentException<ArgumentNullException>(message, paramName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        /// <exception cref="Tgnet.ArgumentException"></exception>
        [Obsolete("使用ThrowIfNullOrEmpty代替", true)]
        public static void ArgumentStringNullOrEmpty(string param, string message = null, string paramName = null)
        {
            if (String.IsNullOrEmpty(param))
            {
                throw GetArgumentException<ArgumentException>(message, paramName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        /// <exception cref="Tgnet.ArgumentException"></exception>
        [Obsolete("使用ThrowIfNullOrWhiteSpace代替", true)]
        public static void ArgumentStringNullOrWhiteSpace(string param, string message = null, string paramName = null)
        {
            if (String.IsNullOrWhiteSpace(param))
            {
                throw GetArgumentException<ArgumentException>(message, paramName);
            }
        }

        [Obsolete("不再建议使用，会让异常堆栈混乱", true)]
        public static void WhenTrue<EX>(bool throwEx, string message = null)
            where EX : Exception, new()
        {
            if (throwEx)
            {
                if (String.IsNullOrEmpty(message))
                    throw new EX();
                else
                    throw (EX)Activator.CreateInstance(typeof(EX), (object)message);
            }
        }

        private static EX GetArgumentException<EX>(string message, string paramName)
            where EX : Exception, new()
        {
            if (String.IsNullOrEmpty(message))
            {
                return new EX();
            }
            else
            {
                if (String.IsNullOrEmpty(paramName))
                    return (EX)Activator.CreateInstance(typeof(EX), (object)message);
                else
                    return (EX)Activator.CreateInstance(typeof(EX), message, paramName);
            }
        }
    }
}
