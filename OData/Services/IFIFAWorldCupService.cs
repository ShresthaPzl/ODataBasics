using OData.Data;

namespace OData.Services
{
    public interface IFIFAWorldCupService
    {
        IQueryable<Country> GetCountries();
    }
}