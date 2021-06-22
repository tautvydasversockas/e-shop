using EShop.Api.DataStore;
using EShop.Api.Graph;
using EShop.Api.Messaging;
using GraphQL;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EShop.Api
{
    public sealed class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton<EShopSchema>()
                .AddSingleton<IDocumentExecuter, SubscriptionDocumentExecuter>()
                .AddGraphQL(options =>
                {
                    options.UnhandledExceptionDelegate = context =>
                        Console.WriteLine(context.OriginalException.Message);
                })
                .AddGraphTypes()
                .AddDataLoader()
                .AddSystemTextJson()
                .AddWebSockets();

            services.AddSingleton<BrandRepository>();
            services.AddSingleton<ProductRepository>();
            services.AddSingleton<ProductReviewRepository>();
            services.AddSingleton<UserRepository>();
            services.AddSingleton<ProductReviewMessageService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();

            app.UseWebSockets();

            app.UseGraphQLPlayground();
            app.UseGraphQLWebSockets<EShopSchema>();
            app.UseGraphQL<EShopSchema>();
        }
    }
}
