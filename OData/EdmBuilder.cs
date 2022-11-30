using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OData.Data;

namespace OData
{
    public class EdmBuilder
    {

        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Country>("Fifa");
            return builder.GetEdmModel();
        }


    }
}
