using System.Reflection;

namespace NetworkSystemShopping.Extensions
{
    public static class WebApplicationBuilder
    {
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);

            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            Type[] implementationTypes = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type implementationType in implementationTypes)
            {
                Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException(
                        $"No interface is provided for the service with name: {implementationType.Name}");
                }

                services.AddTransient(interfaceType, implementationType);
            }
        }
    }
}
