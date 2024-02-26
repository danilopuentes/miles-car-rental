using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilesCarRentalApi.Models;
using MilesCarRentalApi.Services;
using System;
using System.Collections.Generic;

namespace MilesCarRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public  VehicleController (IVehicleService vehicleService)
        {
            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(vehicleService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var vehicles = _vehicleService.GetVehicles();
                return Ok(vehicles);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { ErrorMessage = ex.Message });
            }
        }



        // GET api/<VehicleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var vehicle = _vehicleService.GetVehicle(id);
                if (vehicle == null)
                {
                    return NotFound();
                }
                return Ok(vehicle);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<VehicleController>
        [HttpPost]
        public IActionResult Post([FromBody] Vehicle vehicle)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _vehicleService.CreateVehicle(vehicle);

                return CreatedAtAction(nameof(Get), new { id = vehicle.Id }, vehicle);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
            try
            {
                if (id != vehicle.Id)
                {
                    return BadRequest();
                }

                _vehicleService.UpdateVehicle(vehicle);

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
                var existingVehicle = _vehicleService.GetVehicle(id);
                if (existingVehicle == null)
                {
                    return NotFound();
                }

                _vehicleService.DeleteVehicle(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
