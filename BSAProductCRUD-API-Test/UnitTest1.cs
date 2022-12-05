using BSAProductCRUD_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSAProductCRUD_API_Test
{
    [TestFixture]
    public class Tests : ControllerBase
    {
        private BSAProductCRUD_API.Controllers.ProductController controller;

        [SetUp]
        public void Setup()
        {
            controller = new BSAProductCRUD_API.Controllers.ProductController(null);
        }

        [Test]
        public void GetAllProductController()
        {
            var result = controller.Index().Result;
            Assert.Equals(5, result.Count);
        }
    }
}