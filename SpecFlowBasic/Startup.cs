using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium.DevTools.V121.CSS;
using SolidToken.SpecFlow.DependencyInjection;
using SpecFlowBasic.Drivers;
using SpecFlowBasic.Pages;
using SpecFlowBasic.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic
{
    public class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateService()
        {
            var services = new ServiceCollection();
            //services.AddSingleton(new CollectClassNamesCommandResponse
            //{
            //    property = new Uri("")
            //});

            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<ILoginPage, LoginPage>();
            services.AddScoped<IHomePage, HomePage>();
            return services;
        }
    }
}
 