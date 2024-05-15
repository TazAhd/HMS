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

        //[HttpPost]
        //[Route("api/medicalhistory/update")]
        //public HttpResponseMessage UpdateDoctor(DoctorDTO model)
        //{
        //    var data = MedicalHistoryService.UpdateDoctor(model);
        //    return Request.CreateResponse(HttpStatusCode.OK, data);
        //}

    }



}
