using AnimePlayerBack.Contracts;
using AnimePlayerBack.Data;
using AnimePlayerBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimePlayerBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SliderController : ControllerBase
    {
        private readonly PlayerDbContext _dbContext;
        public SliderController(PlayerDbContext dbContext)
        {
            _dbContext = dbContext;   
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateSliderItem([FromBody] CreateSliderItemRequest request, CancellationToken ct) 
        //{
        //    var sliderItem = new SliderItem(request.Title, request.Description);

        //    await _dbContext.SliderItems.AddAsync(sliderItem, ct);
        //    await _dbContext.SaveChangesAsync(ct);

        //    return Ok();
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetSliderItem()
        //{
        //    var sliderItems = await _dbContext.SliderItems.ToListAsync();
        //    return Ok(sliderItems);
        //}

    }
}
