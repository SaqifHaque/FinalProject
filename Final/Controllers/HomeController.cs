using Final.Authentication;
using Final.Models;
using Final.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final.Controllers
{
    [RoutePrefix("api/Home")]
    public class HomeController : ApiController
    {
        CourseRepository courepo = new CourseRepository();

        [Route("")]
        [BasicAuthorization]
        public IHttpActionResult Get()
        {
            return Ok(courepo.GetAll());
        }

        [Route("{id}", Name = "GetCourseById")]
        public IHttpActionResult Get(int id)
        {
            Course c = courepo.GetByID(id);
            if (c == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(c);
        }
    }
}
