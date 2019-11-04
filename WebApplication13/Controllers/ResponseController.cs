using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.Models;
using WebApplication13.Service;

namespace WebApplication13.Controllers
{
    [Route("api/response")]
    [ApiController]
    public class ResponseController : Controller
    {
        private IRepository _repository;
        public ResponseController(IRepository repository)
        {
            _repository = repository;

        }
        [HttpGet("list")]
        public List<Response> Students()
        {
            return _repository.responses();

        }
        [HttpGet("list/{Id}")]
        public List<Response> StudentsById(int Id)
        {
            return _repository.getById(Id);
            
        }
    }
}
