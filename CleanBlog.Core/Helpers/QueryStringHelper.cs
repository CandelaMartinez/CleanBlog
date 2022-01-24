
using System.Web;

namespace CleanBlog.Core.Helpers
{
    //static asi la puedo usar sin instanciarla
    public static class QueryStringHelper
    {
        public static int GetIntFromQueryString(HttpRequestBase request,string key, int fallbackValue = 0)
        {
            var stringValue = request.QueryString[key];

            //si no es null, si no esta en blanco y al tratar de parsearlo a int se puede entonces: crea la var numericValue y metelo alli
            if(stringValue !=null && !string.IsNullOrWhiteSpace(stringValue)
                && int.TryParse(stringValue, out var numericValue))
            {
                return numericValue;
            }
            //sino 
            return fallbackValue;
        }

    }
}
