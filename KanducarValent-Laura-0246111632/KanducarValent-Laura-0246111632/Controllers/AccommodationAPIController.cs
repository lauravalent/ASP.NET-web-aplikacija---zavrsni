using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rad.DAL;
using Rad.Model;

namespace KanducarValent_Laura_0246111632.Controllers
{
    [Route("api/acc")]
    [ApiController]
    public class AccommodationAPIController : Controller
    {
        private GuestManagerDbContext _dbContext;
        public AccommodationAPIController(GuestManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Get()
        {
            var clients = _dbContext.Accommodations.Select(c => new AccommodationDTO
            {
                ID = c.ID,
                Name = c.Name,
                Capacity = (int)c.Capacity,
                Size = (int)c.Size

            })
            .ToList();

            return Ok(clients);
        }

        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var client = _dbContext.Accommodations
                .Where(c => c.ID == id)
                .Select(c => new AccommodationDTO
                {
                    ID = c.ID,
                    Name = c.Name

                })
            .FirstOrDefault();

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [Route("pretraga/{q}")]
        public IActionResult Get(string q)
        {
            var client = _dbContext.Accommodations
                .Where(c => c.Name.Contains(q))
                .Select(c => new AccommodationDTO
                {
                    ID = c.ID,
                    Name = c.Name
                })
            .ToList();

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccommodationDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            this._dbContext.Accommodations.Add(new Accommodation()
            {
                Name = model.Name,
                Capacity = model.Capacity,
                Size = model.Size
            });


            this._dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        [Consumes("application/json")]
        public IActionResult Put(int id, [FromBody] AccommodationDTO model)
        {
            var clientDBO = this._dbContext.Accommodations.First(c => c.ID == id);

            clientDBO.Name = model.Name;
            clientDBO.Capacity = model.Capacity;
            clientDBO.Size = model.Size;
            this._dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var model = this._dbContext.Accommodations.FirstOrDefault(c => c.ID == id);
            if (model == null)
            {
                return NotFound();
            }
            this._dbContext.Remove(model);
            this._dbContext.SaveChanges();
            var clients = _dbContext.Accommodations.Select(c => new AccommodationDTO
            {
                ID = c.ID,
                Name = c.Name,
                Capacity = (int)c.Capacity,
                Size = (int)c.Size

            })
           .ToList();
            return Ok(clients);
        }
    }
}
