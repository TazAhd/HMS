using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMS.Controllers
{
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
        [Route("api/prescription/patient/{id}")]

        public HttpResponseMessage GetByPatientId(int id)
        {
            var data = PrescriptionService.GetAllPrescriptioninfoByPatientId(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/prescription/{id}")]

        public HttpResponseMessage GetById(int id)
        {
            var data = PrescriptionService.PrescriptionById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/prescription/save")]
        public HttpResponseMessage createPrescription(PrescriptionDTO model)
        {
            var data = PrescriptionService.createPrescription(model);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/prescription/update")]
        public HttpResponseMessage updatePrescription(PrescriptionDTO model)
        {
            var data = PrescriptionService.updatePrescription(model);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/prescription/delete/{id}")]
        public HttpResponseMessage DeletePrescription(int id)
        {
            var data = PrescriptionService.DeletePrescription(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
