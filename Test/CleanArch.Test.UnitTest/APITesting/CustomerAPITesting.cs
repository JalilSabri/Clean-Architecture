using CleanArch.API;
using CleanArch.API.Controller;
using CleanArch.Core.Application.Services.Persons;
using CleanArch.Core.Domain.Models.Persons;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Infrastructure.Data.Repositories.Persons;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Test.UnitTest.APITesting
{
    [TestClass]
    public class CustomerAPITesting
    {
        private HttpClient _client;
        CleanArchDbContext dbContext;

        public CustomerAPITesting()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = server.CreateClient();

            var optionsBuilder = new DbContextOptionsBuilder<CleanArchDbContext>();
            {

            };

            optionsBuilder.UseSqlServer("Server=DESKTOP-98REPCN\\SQL2019DEVELOPER; Database=ArchitectureDB; User ID=sa; Password=123");

            dbContext = new CleanArchDbContext(optionsBuilder.Options);

        }

        [TestMethod]
        public void GetCustomerTest()
        {
            var request = new HttpRequestMessage(new HttpMethod("Get"), "/Api/Customer");

            var response = _client.SendAsync(request).Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void AddCustomerTest()
        {
            var request = new HttpRequestMessage(new HttpMethod("Post"), "/Api/Customer");

            var response = _client.SendAsync(request).Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
