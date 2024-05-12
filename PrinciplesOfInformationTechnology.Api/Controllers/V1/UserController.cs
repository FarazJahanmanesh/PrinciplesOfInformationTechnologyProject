using Domain;
using Microsoft.AspNetCore.Mvc;
using PrinciplesOfInformationTechnology.Api.Dtos;

namespace PrinciplesOfInformationTechnology.Api.Controllers.V1;

public class UserController : BaseController
{
	private readonly IUserService service;
    public UserController(IUserService service)
	{
		this.service = service;
	}
	[HttpGet]
	public async Task<IActionResult> GetUser()
	{
		var response = new ActionResponse<GetUserResponse>();
		var users = await service.GetUser();
		if(users is not null)
		{
			response.Data = new GetUserResponse(users);
			//response.Data.Users = users;
            response.Status = 200;
			response.State =ResponseStateEnum.SUCCESS;
			response.Message = StaticStrings.User_Get_Successfully;
			return Ok(response);
        }
        response.Status = 404;
        response.State = ResponseStateEnum.FAILED;
        response.Message = StaticStrings.NotFound;
		return NotFound(response);
    }
	[HttpPost]
    public async Task<IActionResult> InsUser(InsUserRequest request)
    {
        var response = new ActionResponse();
		var isIns = await service.InsUser(new Domain.User 
		{
			EntryDate =DateTime.Now,
			Id = request.Id,
			NationalCode = request.NationalCode,
			UserName = request.UserName
		});
		if (isIns)
		{
			response.Status = 200;
			response.Message = StaticStrings.User_Ins_Successfully;
			response.State = ResponseStateEnum.SUCCESS;
            return Ok(response);
        }
        response.Status = 503;
        response.Message = StaticStrings.User_Ins_Error;
        response.State = ResponseStateEnum.FAILED;
        return BadRequest(response);
    }
}
