using Bunit;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Data.Interfaces;
using NUnit;

namespace MyBlog.Shared.Tests.Pages
{
    public class IndexTest : Bunit.TestContext
    {
        public IndexTest()
        {
            Services.AddScoped<IMyBlogApi, MyBlogApiMock>();
        }
        [Test]
        public void Shows10Blogposts()
        {
            var cut = RenderComponent<MyBlog.Shared.Pages.Index>();
            Assert.AreEqual(10, cut.FindAll("article").Count);
        }
    }
}
