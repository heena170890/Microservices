using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using UserServices.Model;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace UserServices.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet("")]
        public ActionResult GetAllUser()
        {
            return StatusCode((int)HttpStatusCode.OK, _context.Users.ToList());
        }

        [HttpGet("user/{id}")]
        public ActionResult GetUser([FromUri]int id)
        {
            return StatusCode((int)HttpStatusCode.OK, _context.Users.Find(id));
        }

    }
}
