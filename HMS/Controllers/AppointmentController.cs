using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMS.Controllers
{
    public class AppointmentController : ApiController
    {
        [HttpGet]
        [Route("api/appointment/all")]
        public HttpResponseMessage Get()
        {
            var data = AppointmentService.GetAllappointments();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/appointment/{id}")]

        public HttpResponseMessage GetById(int id)
        {
            var data = AppointmentService.appointmentById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/appointment/delete/{id}")]
        public HttpResponseMessage DeleteAppoinment(int id)
        {
            var data = AppointmentService.DeleteAppoinment(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
