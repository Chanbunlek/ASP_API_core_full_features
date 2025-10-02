using full_webapi_features.Model;

namespace full_webapi_features.DTO;

public class UserDTO
{
    public string Name { get; set; }

    public string Gender { get; set; }

    public DateTime CreatedDate { get; private set; }

    public UserDTO()
    {
        Name = string.Empty;
        Gender = string.Empty;
    }

    public User ToEntity()
    {
        return new()
        {
            Name = Name,
            Gender = Gender,
            CreatedDate = DateTime.Now
        };
    }

    public static UserDTO ToDto(User user)
    {
        return new()
        {
            Name = user.Name,
            Gender = user.Gender,
            CreatedDate = user.CreatedDate
        };
    }
}
