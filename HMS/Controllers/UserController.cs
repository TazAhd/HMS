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
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("api/user/save")]
        public HttpResponseMessage createUser(UserDTO model)
        {
            var data = UserService.createUser(model);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/user/all")]

        public HttpResponseMessage Get()
        {
            var data = UserService.GetAllUsers();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            var data = UserService.UsersById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
