using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Commen
{
   public  class ConfigurationManager
    {
        public static IConfiguration Configuration { get; internal set; }
        static ConfigurationManager() {
            //ReloadOnChange = true 当appsettings.json被修改时重新加载
        }

        public static void Init()
        {
            Configuration = new ConfigurationBuilder()
           .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
           .Build();
        }

        public static void Init(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
           .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
           .AddJsonFile($"appsettings.{env.EnvironmentName}.json",optional:true,reloadOnChange:true)
           //.AddEnvironmentVariables()
           .Build();
        }
    }
}
