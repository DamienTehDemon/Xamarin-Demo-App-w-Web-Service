﻿using Microsoft.Owin;
using Newtonsoft.Json;
using Owin;
using System.Web.Http;

[assembly: OwinStartupAttribute(typeof(BookYoPlanesWebService.Startup))]
namespace BookYoPlanesWebService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        { 
            ConfigureAuth(app);
        }
    }
}
