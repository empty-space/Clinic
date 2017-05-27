using Clinic.Domain.Commands.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Clinic.Web.Extensions
{
    public static class RegisterCommandsExtension
    {
        //NOTE: В .NET Core изменен синтаксис при рабобе с рефлексией. Именно по-этому используется метод-расширение GetTypeInfo()
        public static IServiceCollection RegisterCommands(this IServiceCollection services, Assembly assembly)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (assembly == null)
                throw new ArgumentNullException(nameof(assembly));

            foreach (var type in assembly.GetTypes())
            {
                var typeInfo = type.GetTypeInfo();
                if (typeInfo.BaseType != typeof(object) && !typeInfo.IsAbstract && typeof(ICommand).IsAssignableFrom(type))
                {
                    services.AddScoped(type);
                }
            }

            return services;
        }
    }
}
