using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebAPIproject.Models.Startup))]
namespace WebAPIproject.Models
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}