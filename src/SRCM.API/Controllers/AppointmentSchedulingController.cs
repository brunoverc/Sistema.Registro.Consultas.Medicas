﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SRCM.Services.AppService.Interfaces;
using SRCM.Services.AppService.Services;
using SRCM.Services.AppService.ViewModel;

namespace SRCM.API.Controllers
{
    [Route("api/appointmentScheduling")]
    [ApiController]
    public class AppointmentSchedulingController : ControllerBase
    {
        protected readonly IAppointmentSchedulingAppServices _appointmentSchedulingAppServices;

        public AppointmentSchedulingController(IAppointmentSchedulingAppServices appointmentSchedulingAppServices)
        {
            _appointmentSchedulingAppServices = appointmentSchedulingAppServices;
        }
        [HttpGet]
        public ActionResult<IEnumerable<AppointmentSchedulingViewModel>> Get()
        {
            var result = _appointmentSchedulingAppServices.Search(a => true);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public ActionResult<AppointmentSchedulingViewModel> Get(Guid id)
        {
            var result = _appointmentSchedulingAppServices.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public ActionResult Post([FromBody] AppointmentSchedulingViewModel appointmentSchedulingViewModel)
        {
            var result = _appointmentSchedulingAppServices.Add(appointmentSchedulingViewModel);
            return Ok(result);
        }
        [HttpPut]
        public ActionResult Put(AppointmentSchedulingViewModel appointmentSchedulingViewModel)
        {
            var result = _appointmentSchedulingAppServices.Update(appointmentSchedulingViewModel);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _appointmentSchedulingAppServices.Remove(id);
            return Ok();
        }
    }
}
