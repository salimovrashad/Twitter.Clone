using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Twitter.Business.DTOs.TopicDTOs;
using Twitter.Business.Repositories.Interfaces;
using Twitter.Business.Services.Interfaces;

namespace Twitter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        ITopicService _service { get; }

        public TopicsController(ITopicService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> Post(TopicCreateItemDTO dto)
        {
            await _service.CreateAsync(dto);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
