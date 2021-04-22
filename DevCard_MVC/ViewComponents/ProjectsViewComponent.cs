using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"سیستم ثبت آموزشی", "مدیریت دانشجویان و کلاس ها", "project-1.jpg", "احرار"),
                new Project(2,"آروتل", "سیستم نوین مدیریت هتل", "project-2.jpg", "هتل پارمیدا"),
                new Project(3,"سیستم ثبت غذا", "سفارش غذا آنلاین و سریع", "project-3.jpg", "رستوران مریخ"),
                new Project(4,"مدیریت کتابخانه", "مدیریت کتاب های امانتی", "project-4.jpg", "کتاب حانه احرار"),
                new Project(5,"هنرجوی برتر", "مدیریت هنرجویان برای کلاس های موسیقی خصوصی", "project-5.jpg", "موسسه آوای نو"),
                new Project(6,"مدیریت حساب", "مدیریت حساب شخصی و دخل و خرج", "project-6.jpg", "درویش"),
            };
            return View("_Projects", projects);
        }
    }
}
