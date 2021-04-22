using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "آموزش Asp.net Core MVC", "پکیج کامل آموزش ASP.NET Core به زبان فارسی",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2, "آموزش پیانو", "پکیج کامل آموزش ",
                    "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش Git", "پکیج کامل آموزش ",
                    "blog-post-thumb-card-3.jpg"),
                new Article(4, "آموزش C#", "پکیج کامل آموزش ",
                    "blog-post-thumb-card-4.jpg"),

            };
            return View("_LatestArticles", articles);
        }
    }
}
