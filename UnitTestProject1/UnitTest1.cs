using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication8;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly HttpClient _client;

        public UnitTest1()
        {
            _client = (new WebApplicationFactory<Startup>()).CreateClient();
        }

        [TestMethod]
        public async Task TestCoverge()
        {
            var req = await _client.GetAsync("WeatherForecast");
            var resp = await req.Content.ReadAsStringAsync();

            Assert.IsFalse(string.IsNullOrEmpty(resp), "should be not empty");
        }
    }
}
