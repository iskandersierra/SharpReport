using System.IO;
using System.Reflection;
using System.Web;

namespace SharpReport.WebApi
{
    public static class WebApiHelpers
    {
        public static string GetXmlCommentsPath()
        {
            return Path.Combine(HttpRuntime.BinDirectory, Assembly.GetExecutingAssembly().GetName().Name + ".xml");
        }
    }
}
