using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMS.Controllers
{
    public class DoctorController : ApiController
    {

        [HttpGet]
        [Route("api/patient/all")]

        public HttpResponseMessage Get()
        {
            var data = PatientService.GetAllpatients();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/patient/{id}")]

        public HttpResponseMessage GetById(int id)
        {
            var data = PatientService.patientById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
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
    }

    public class PrescriptionController : ApiController
    {
        [HttpGet]
        [Route("api/prescription/all")]

        public HttpResponseMessage Get()
        {
            var data = PrescriptionService.GetAllPrescriptioninf();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/prescription/{id}")]

        public HttpResponseMessage GetById(int id)
        {
            var data = PrescriptionService.PrescriptionById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
