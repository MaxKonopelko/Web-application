using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Charts.DAL;

namespace Charts.Web.Controllers
{
    [RoutePrefix("api/ajax")]
    public class AjaxController : ApiController
    {
        private Repository _repository;

        public AjaxController()
        {
            _repository = new Repository();
        }

        [HttpGet]
        [Route("test")]
        public List<Transaction> Test()
        {
            var transactions = _repository.GetAllTransaction();

            return transactions;
        }
    }
}
