using Microsoft.AspNetCore.Mvc;
using QTraining.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTraining.API.Controllers
{
    [ApiController]
    [Route("api/sessions")]
    public class SessionController: ControllerBase
    {
        private readonly QTrainingDBContext _dbcontext;

        public SessionController(QTrainingDBContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public IActionResult GetSessions()
        {
            return Ok(_dbcontext.Sessions.ToList());
        }
    }
}
