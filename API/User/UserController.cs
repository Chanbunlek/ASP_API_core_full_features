using full_webapi_features.DTO;
using full_webapi_features.Model;
using full_webapi_features.Utils;
using Microsoft.AspNetCore.Mvc;

namespace full_webapi_features.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserService userService, IHttpContextAccessor httpContext) : ControllerBase
    {
        [HttpGet("/[action]")]
        public ActionResult<Response<List<User>>> Get()
        {
            return Ok(Response<List<User>>.Ok(userService.GetAll(), httpContext.HttpContext?.Request.Path ?? "/unknown"));
        }

        [HttpPost("/[action]")]
        public ActionResult<Response<User>> Create(UserDTO createDTO)
        {
            return Ok(Response<User>.Ok(userService.Create(createDTO.ToEntity()), httpContext.HttpContext?.Request.Path ?? "/unknown"));
        }

        [HttpPatch("/[action]/{id}")]
        public ActionResult<Response<UserDTO>> Update(int id, UserDTO user)
        {
            return Ok(Response<UserDTO>.Ok(userService.Update(id, user), httpContext.HttpContext?.Request.Path ?? "/unknown"));
        }

        [HttpDelete("/[action]/{id}")]
        public ActionResult<Response<UserDTO>> Delete(int id)
        {
            return Ok(Response<UserDTO>.Ok(UserDTO.ToDto(userService.Delete(id)), httpContext.HttpContext?.Request.Path ?? "/unknown"));
        }
    }
}
