using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMS.Controllers
{
    public class AdminController : ApiController
    {
        [HttpGet]
        [Route("api/doctor/all")]
        public HttpResponseMessage Get()
        {
            var data = DoctorService.GetAlldoctors();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/doctor/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            var data = DoctorService.doctorById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
