using System;
using Xunit;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;

namespace TestProject1
{
    public class ValuesControllerTest
    {
        private readonly ValuesController _controller;

        public ValuesControllerTest()
        {
            _controller = new ValuesController();
        }
        
        [Fact]
        public void Test_simple_get()
        {
            string result;
            var expected = new Dictionary<int, string>() {
                { 3, "fish" },
                { 5, "ships"},
                { 15, "fishchips"},
                { 7, "nofish"},
                { -3, "fish" },
                { -5, "ships"},
                { -15, "fishchips"},
                { -7, "nofish"},
                {Int32.MaxValue, "nofish" },
                {0, "fishchips" }
            };

            foreach (KeyValuePair<int, string> map in expected)
            {
                result = _controller.Get(map.Key).Value;
                Assert.Contains(map.Value, result);
            }
        }
    }
}
