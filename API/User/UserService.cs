using full_webapi_features.Config;
using full_webapi_features.DTO;
using full_webapi_features.Model;
using full_webapi_features.Repository;
using full_webapi_features.Utils;

public class UserService(UserRepository userRepository)
{
    public List<User> GetAll()
    {
        return [.. userRepository.GetAll()];
    }

    public User? Get(int id)
    {
        return userRepository.Get(id);
    }

    public User Create(User user)
    {
        return userRepository.Create(user);
    }

    public UserDTO Update(int id, UserDTO user)
    {
        User? User = userRepository.Get(id) ?? throw new ExceptionService(ErrorCode.NotFound($"User ID {id} not found!"));

        if (user.Name is not null)
        {
            User.Name = user.Name;
        }

        if (user.Name is not null)
        {
            User.Gender = user.Name;
        }

        userRepository.Update(User);
        return UserDTO.ToDto(User);
    }

    public User Delete(int id)
    {
        User? User = userRepository.Get(id) ?? throw new ExceptionService(ErrorCode.NotFound($"User ID {id} not found!"));
        userRepository.Delete(User);

        return User;
    }
}

