﻿using System;
using DeTai.ThucTap.Data;
using DeTai.ThucTap.Data.CustomEntites;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DeTai.ThucTap.Api.Areas.Identity.IdentityHostingStartup))]
namespace DeTai.ThucTap.Api.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
              
            });
        }
    }
}