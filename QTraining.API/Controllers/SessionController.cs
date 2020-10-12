using Microsoft.AspNetCore.Mvc;
using QTraining.Data;
using QTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTraining.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class SessionController: ControllerBase
    {
        private readonly QTrainingDBContext _dbcontext;

        public SessionController(QTrainingDBContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Session>> GetSessions()
        {
            List<Session> sessions = _dbcontext.Sessions.ToList();
            return Ok(sessions);
        }
    }
}
