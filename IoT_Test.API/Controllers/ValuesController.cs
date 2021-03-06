﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoT_Test.API.Controllers
{
    public class ValuesController : ApiController
    {
        private AppDatabase dbContext;

        public ValuesController()
        {
            dbContext = new AppDatabase();
        }


        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Get()
        {
            var messages = dbContext.Messages.AsEnumerable();
            var c = dbContext.Messages.Count();
            var message = messages.LastOrDefault();

            return Ok(message);
        }

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post(Message message)
        {
            dbContext.Messages.Add(message);
            dbContext.SaveChanges();

            var m = dbContext.Messages.Count();
            return Created(new Uri(Request.RequestUri + "/" + message.Id), message);
        }


    }
}
