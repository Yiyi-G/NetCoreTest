using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tgnet;

namespace Tgnet.ServiceModel
{
    /// <summary>
    /// wcf客户端帮助类
    /// </summary>
    public static class ClientHelper
    {
        /// <summary>
        /// 管道提供者扩展方法
        /// </summary>
        /// <typeparam name="TChannel"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="provider"></param>
        /// <param name="executeFunc">要执行的调用</param>
        /// <returns></returns>
        public static T Execute<TChannel, T>(this IChannelProviderService<TChannel> provider, Func<TChannel, T> executeFunc)
            where TChannel : class
        {
            ExceptionHelper.ThrowIfNull(provider, "provider");
            ExceptionHelper.ThrowIfNull(executeFunc, "executeFunc");

            using (var channelService = provider.NewChannelProvider())
            {
                return executeFunc(channelService.Channel);
            }
        }

        /// <summary>
        /// 使用默认配置初始化wcf，并执行调用
        /// </summary>
        /// <typeparam name="TChannel"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="executeFunc">要执行的调用</param>
        /// <returns></returns>
        public static T Execute<TChannel, T>(Func<TChannel, T> executeFunc)
            where TChannel : class
        {
            return Execute(new ChannelProviderService<TChannel>(), executeFunc);
        }

        /// <summary>
        /// 管道提供者扩展方法
        /// </summary>
        /// <typeparam name="TChannel"></typeparam>
        /// <param name="provider"></param>
        /// <param name="executeAction">要执行的调用</param>
        public static void Execute<TChannel>(this IChannelProviderService<TChannel> provider, Action<TChannel> executeAction)
            where TChannel : class
        {
            ExceptionHelper.ThrowIfNull(provider, "provider");
            ExceptionHelper.ThrowIfNull(executeAction, "executeAction");

            using (var channelService = provider.NewChannelProvider())
            {
                executeAction(channelService.Channel);
            }
        }

        /// <summary>
        /// 使用默认配置初始化wcf，并执行调用
        /// </summary>
        /// <typeparam name="TChannel"></typeparam>
        /// <param name="executeAction">要执行的调用</param>
        public static void Execute<TChannel>(Action<TChannel> executeAction)
            where TChannel : class
        {
            Execute(new ChannelProviderService<TChannel>(), executeAction);
        }
    }
}
