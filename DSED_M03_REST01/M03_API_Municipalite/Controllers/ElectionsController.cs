using M03_API_Municipalite.Models;
using M03_Svr_Municipalite;
using Microsoft.AspNetCore.Mvc;

namespace M03_API_Municipalite.Controllers
{
    [Route("api/Municipalite")]
    [ApiController]
    public class ElectionsController : ControllerBase
    {
        private ManipulationElections m_manipulationElections;

        public ElectionsController(ManipulationElections manipulationElections)
        {
            this.m_manipulationElections = manipulationElections;
        }

        //[HttpGet]
        //[ProducesResponseType(200)]
        //public ActionResult<IEnumerable<ElectionModel>> Get()
        //{
        //    return Ok(m_manipulationElections.ListerElection().Select(m => ))
        //}
    }
}
