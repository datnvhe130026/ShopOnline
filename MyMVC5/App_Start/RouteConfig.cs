 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMVC5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Trang xem danh sach sach
            routes.MapRoute(
               name: "List of book",
               url: "tim-sach",
               defaults: new { controller = "Book", action = "List"}
           );
            //Trang xem  thong tin mot cuon sach
           
            //trang1
            routes.MapRoute(
                name: "Trang 1",
                url: "trang_1",
                defaults: new { controller = "TVLT", action = "Index" }
            );
            //trang 2
            routes.MapRoute(
               name: "Trang 2",
               url: "trang_2",
               defaults: new { controller = "TVLT", action = "Index2" }
           );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
