using Common.EventBus.Abstractions;
using Common.EventBus.RabbitMQ;
using BTCsalman.Web.Infrastructure.JwtUtil;
using BTCsalman.Web.Infrastructure.RazorUtils;
using BTCsalman.Web.Infrastructure.Services;

namespace BTCsalman.Web.Infrastructure;

public static class RegisterDependencyServices
{
    public static IServiceCollection RegisterWebDependencies(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();

        services.AddSingleton<IEventBus, EventBusRabbitMQ>();
        services.AddTransient<IRenderViewToString, RenderViewToString>();
        services.AddAutoMapper(typeof(RegisterDependencyServices).Assembly);
        services.AddScoped<IHomePageService, HomePageService>();

        return services;
    }
}