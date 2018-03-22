using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.Common
{
    public static class ConfigHelper<T>
    {
        public static T Init(T t)
        {

            try
            {
                ConfigurationBuilder builder = new ConfigurationBuilder();
                builder.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);
                builder.AddJsonFile("setting.json");

                var configuration = builder.Build();
                var section = configuration.GetSection(t.GetType().Name);
                return section.Get<T>();
            }
            catch(Exception ex)
            {
                return t;
            }

        }
    }
}
