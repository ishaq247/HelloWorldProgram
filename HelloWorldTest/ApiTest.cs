using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedAPI;
using SharedAPI.Interfaces;
using SharedAPI.Applications;
using System.Threading.Tasks;
using Moq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HelloWorldTest
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void ServiceApi_UnitTest()
        {
            ServiceApi app = new ServiceApi();
            var task = app.GetMessage();
            task.Wait();
            var response = task.Result;
            Assert.AreEqual(response.ToString(), "\"Hello World\"");
        }

        [TestMethod]
        public void GetUri_UnitTest()
        {
            var mockResponse = new Mock<IGetMessage>();
            mockResponse.Setup(x => x.GetUri()).Returns(new Uri("http://localhost:49313/api/Home/GetText"));

            ServiceApi api = new ServiceApi();
            Assert.IsNotNull(mockResponse.Object.GetUri());
            Assert.AreEqual(api.GetUri(), mockResponse.Object.GetUri());

        }

    }
}
