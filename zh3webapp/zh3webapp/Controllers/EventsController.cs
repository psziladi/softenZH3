using Microsoft.AspNetCore.Mvc;
using zh3webapp.EventModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zh3webapp.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // GET: api/events
        [HttpGet]
        public IActionResult Get()
        {
            EventsContext context = new EventsContext();
            return Ok(context.Rendezveny.ToList());
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            EventsContext context = new EventsContext();
            var kiválasztottEvent = (from x in context.Rendezveny where x.RendezvenyId == id select x).FirstOrDefault();
            return Ok(kiválasztottEvent);
        }

        // POST api/events
        [HttpPost]
        public IActionResult Post([FromBody] Rendezveny újEvent)
        {
            EventsContext context = new EventsContext();
            context.Rendezveny.Add(újEvent);
            context.SaveChanges();
            return Ok(újEvent);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/events/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            EventsContext context = new EventsContext();
            var törEvent = (from x in context.Rendezveny where x.RendezvenyId == id select x).FirstOrDefault();
            context.Remove(törEvent);
            context.SaveChanges();
        }
    }
}
