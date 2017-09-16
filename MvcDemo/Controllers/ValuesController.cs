using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcDemo.Controllers
{
    public class ValuesController : ApiController
    {
        // POST api/values
        public IHttpActionResult Post([FromBody]NumberInputModel model)
        {
            if (model == null)
                throw new ArgumentNullException("Model cannot be null");

            var result = model.FirstNumber + model.SecondNumber;
            return Ok(result);
        }

    }
}
