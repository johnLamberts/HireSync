using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace HireSync.Application;

public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
    var assembly = typeof(DependencyInjection).Assembly;

    services.AddMediatR(options => 
      options.RegisterServicesFromAssembly(assembly));

    services.AddValidatorsFromAssembly(assembly);
    
    return services;
  }
}
