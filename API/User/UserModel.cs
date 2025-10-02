namespace full_webapi_features.Model;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Gender { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastModified { get; set; }

    public User()
    {
        Name = string.Empty;
        Gender = string.Empty;
        CreatedDate = DateTime.Now;
        LastModified = DateTime.Now;
    }

    public User(string name, string gender)
    {
        Name = name;
        Gender = gender;
    }
}
