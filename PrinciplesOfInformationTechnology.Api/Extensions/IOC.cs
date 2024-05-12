using Application.Services;
using Domain;

namespace PrinciplesOfInformationTechnology.Api.Extensions;
public static class IOC
{
    public static IServiceCollection RegisterIOC(this  IServiceCollection services)
    {
        services.RegisterSrvices();
        return services;
    }
    private static IServiceCollection RegisterSrvices(this IServiceCollection services)
    {
        services.AddSingleton<IUserService, UserService>();
        return services;
    }
}
