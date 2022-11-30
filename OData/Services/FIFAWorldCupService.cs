using OData.Data;

namespace OData.Services
{
    public class FIFAWorldCupService : IFIFAWorldCupService
    {
        private readonly FIFAWorldCupApiContext context;

        public FIFAWorldCupService(FIFAWorldCupApiContext context)
        {
            this.context = context;
        }

        public IQueryable<Country> GetCountries()
        {
            return this.context.Countries.AsQueryable();
        }
    }
}
