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
    public class MedicalHistoryController : ApiController
    {
        [HttpGet]
        [Route("api/medicalhistory/all")]

        public HttpResponseMessage Get()
        {
            var data = MedicalHistoryService.GetAllMedicalHistories();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/medicalhistory/patient/{id}")]

        public HttpResponseMessage GetByPatientId(int id)
        {
            var data = PrescriptionService.GetAllPrescriptioninfoByPatientId(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/medicalhistory/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            var data = MedicalHistoryService.MedicalHistoryById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/medicalhistory/save")]
        public HttpResponseMessage createMedicalHistory(MedicalHistoryDTO model)
        {
            var data = MedicalHistoryService.createMedicalHistory(model);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/medicalhistory/update")]
        public HttpResponseMessage updateMedicalHistory(MedicalHistoryDTO model)
        {
            var data = MedicalHistoryService.updateMedicalHistory(model);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/doctor/delete/{id}")]
        public HttpResponseMessage DeleteMedicalHistoryr(int id)
        {
            var data = MedicalHistoryService.DeleteMedicalHistory(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
