using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.ActionFilters
{
    public class LoggerActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string logMessage = formatLogMessage(filterContext.RouteData);
            string path = "./Logger/logger.txt";
            using var sw = new StreamWriter(path, File.Exists(path));
            sw.WriteLine(logMessage);
            
        }

        public string formatLogMessage(RouteData routeData)
        {
            var mealType = routeData.Values["type"];
            var message = String.Format("{0} - {1}", mealType, DateTime.Now.ToString());
            return message;
        }

      


    }
}
