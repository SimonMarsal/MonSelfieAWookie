using Microsoft.AspNetCore.Builder;

namespace MonSelfieAWookie.Tools
{
    public static class RoutingMethods
    {
        public static void UseCustomRoutes(this IApplicationBuilder builder)
        {
            builder.UseEndpoints(endpoints =>
            {
                //default : comment appeler
                //pattern : url final
                //name : pour RedirectToAction

                endpoints.MapControllerRoute(
                    name:"WookiesList",
                    pattern:"wookiesList/{id:int?}",
                    defaults : new { controller = "Wookie", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
