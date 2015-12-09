using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using KendoUIgrid.App_Start;

namespace KendoUIgrid
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            int entitiesNumber = 5;
            Database.SetInitializer(new EventMetadataContextInit(entitiesNumber));
            Database.SetInitializer(new ContentMetadataContextInit(entitiesNumber));
            Database.SetInitializer(new UserMetadataContextInit(entitiesNumber));
            Database.SetInitializer(new PageViewMetadataContextInit(entitiesNumber));
            Database.SetInitializer(new VisitMetadataContextInit(entitiesNumber));
            Database.SetInitializer(new MapMetadataContextInit(entitiesNumber));
            Database.SetInitializer(new IssueMetadataContextInit(entitiesNumber));


            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
        }
    }
}