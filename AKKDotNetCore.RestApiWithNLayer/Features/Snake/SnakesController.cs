using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AKKDotNetCore.RestApiWithNLayer.Features.Snake
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnakesController : ControllerBase
    {
        private async Task<Snakes> GetDataAsync()
        {
            string jsonStr = await System.IO.File.ReadAllTextAsync("snakes.json");
            var model = JsonConvert.DeserializeObject<Snakes>(jsonStr);
            return model;
        }

        [HttpGet("snakes")]
        public async Task<IActionResult> Snakes()
        {
            var model = await GetDataAsync();
            return Ok(model.snakes);
        }

        [HttpGet("snakes/{id}")]
        public async Task<IActionResult> Snake(int id)
        {
            var model = await GetDataAsync();
            var snake = model.snakes.FirstOrDefault(x => x.Id == id);
            if (snake is null) return NotFound("No data found");
            return Ok(snake);
        }

        [HttpGet("snakes/burmese/{name}")]
        public async Task<IActionResult> SnakesByName(string name)
        {
            var model = await GetDataAsync();
            var snakesByMMName = model.snakes.Where(x => x.MMName.Contains(name)).ToList();
            if (snakesByMMName.Count == 0) return NotFound("no data found");
            return Ok(snakesByMMName);
        }
    }
}

public class Snakes
{
    public Snake[] snakes { get; set; }
}

public class Snake
{
    public int Id { get; set; }
    public string MMName { get; set; }
    public string EngName { get; set; }
    public string Detail { get; set; }
    public string IsPoison { get; set; }
    public string IsDanger { get; set; }
}
