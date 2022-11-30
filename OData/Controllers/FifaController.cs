using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData.Data;
using OData.Models;
using OData.Services;

namespace OData.Controllers
{
    [ODataRouteComponent("api/v2")]
    public class FifaController : ODataController
    {
        private readonly IFIFAWorldCupService iFifaService;
        private readonly IMapper iMapper;

        public FifaController(IFIFAWorldCupService iFifaService,
            IMapper iMapper)
        {
            this.iFifaService = iFifaService;
            this.iMapper = iMapper;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<CountryDTO>> Get()
        {
            var country = this.iFifaService.GetCountries();
            return Ok(this.iMapper.ProjectTo<CountryDTO>(country).AsQueryable());

        }
    }
}
