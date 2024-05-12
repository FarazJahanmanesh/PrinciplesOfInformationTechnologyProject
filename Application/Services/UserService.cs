using Domain;

namespace Application.Services;
public class UserService: IUserService
{
    private readonly List<User> _users;
    public UserService()
    {
        _users = new List<User>();
    }
    public async Task<List<User>> GetUser()
    {
        if (_users.Count > 0)
            return _users;
        else
        {
            _users.Remove(_users.Where(I => I.Id == 1).FirstOrDefault());
            User user = new User()
            {
                Id = 1,
                EntryDate = DateTime.Now,
                NationalCode = "0482587865",
                UserName = "Test"
            };
            _users.Add(user);
        }
        await Task.Delay(2000);
        return _users;
    }
    public async Task<bool> InsUser(User user)
    {
        await Task.Delay(2000);
        try
        {
            _users.Add(user);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
