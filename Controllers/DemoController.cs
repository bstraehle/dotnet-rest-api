using DemoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private static List<Demo> demoList = new List<Demo> { new Demo(1, "Object 1"), new Demo(2, "Object 2"), new Demo(3, "Object 3") };

        [HttpGet]
        [ProducesResponseType(typeof(List<Demo>), 200)]
        public ActionResult<List<Demo>> Get()
        {
            Console.Out.WriteLineAsync("Get");
            
            return demoList;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Demo), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public ActionResult<Demo> Get(int id)
        {
            Console.Out.WriteLineAsync(string.Format("Get Id=[{0}]", id));

            var obj = demoList.FirstOrDefault(x => x.Id == id);

            if (obj != null) return obj;

            return NotFound("Demo object not found");
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult Post(Demo demo)
        {
            Console.Out.WriteLineAsync(string.Format("Post {0}", demo));

            var obj = demoList.FirstOrDefault(x => x.Id == demo.Id);

            if (obj == null)
            {
                demoList.Add(demo);
                return Ok("Demo object added");
            }

            return BadRequest("Duplicate demo object id");
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public ActionResult Put(Demo demo)
        {
            Console.Out.WriteLineAsync(string.Format("Put {0}", demo));

            var obj = demoList.FirstOrDefault(x => x.Id == demo.Id);

            if (obj != null)
            {
                obj.Name = demo.Name;
                return Ok("Demo object updated");
            }

            return NotFound("Demo object not found");
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public ActionResult Delete(int id)
        {
            Console.Out.WriteLineAsync(string.Format("Delete Id=[{0}]", id));

            var obj = demoList.FirstOrDefault(x => x.Id == id);

            if (obj != null)
            {
                demoList.Remove(obj);
                return Ok("Demo object deleted");
            }

            return NotFound("Demo object not found");
        }
    }
}
