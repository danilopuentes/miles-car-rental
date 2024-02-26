using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilesCarRentalApi.Models;
using MilesCarRentalApi.Services;

namespace MilesCarRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService ?? throw new ArgumentNullException(nameof(locationService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var locations = _locationService.GetLocations();
                return Ok(locations);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { ErrorMessage = ex.Message });
            }
        }



        // GET api/<VehicleLocation>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var location = _locationService.GetLocation(id);
                if (location == null)
                {
                    return NotFound();
                }
                return Ok(location);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<LocationController>
        [HttpPost]
        public IActionResult Post([FromBody] Location location)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _locationService.CreateLocation(location);

                return CreatedAtAction(nameof(Get), new { id = location.Id }, location);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Location location)
        {
            try
            {
                if (id != location.Id)
                {
                    return BadRequest();
                }

                _locationService.UpdateLocation(location);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var existingLocation = _locationService.GetLocation(id);
                if (existingLocation == null)
                {
                    return NotFound();
                }

                _locationService.DeleteLocation(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
