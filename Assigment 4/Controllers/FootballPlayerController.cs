using Assigment_4.Managers;
using Football;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assigment_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private readonly FootballPlayersManager _manager = new FootballPlayersManager();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [EnableCors("allowAll")]

        public IEnumerable<FootballPlayer> Get()
        {
            return _manager.GetAll();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        [EnableCors("allowAll")]
        public ActionResult<FootballPlayer> Get(int id)
        {
            FootballPlayer footballplayer = _manager.GetById(id);
            if (footballplayer == null) return NotFound("No such class, id: " + id);
            return Ok(footballplayer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{value}")]
        [EnableCors("allowAll")]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value)
        {
            FootballPlayer footballplayer = _manager.Add(value);
            if (footballplayer == null) return NotFound("The server successfully processed the request, and is not returning any content.");
            return Ok(footballplayer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        [EnableCors("allowAll")]

        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
        
            return _manager.Update(id, value);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        [EnableCors("allowAll")]

        public FootballPlayer Delete (int id)
        {
            return _manager.Delete(id);
        }

    }
}
