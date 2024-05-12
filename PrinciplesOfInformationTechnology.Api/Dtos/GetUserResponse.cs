using Domain;

namespace PrinciplesOfInformationTechnology.Api.Dtos;
//public record GetUserResponse
//{
//    public List<User> Users;
//    public GetUserResponse()
//    {
//        Users = new List<User>();
//    }
//}
public record GetUserResponse(List<User> Users);