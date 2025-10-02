using full_webapi_features.Config;
using full_webapi_features.Model;

namespace full_webapi_features.Repository;

public class UserRepository
{
    private readonly DbConnection db;

    public UserRepository(DbConnection _db)
    {
        db = _db;
    }

    public List<User> GetAll()
    {
        return [.. db.Users];
    }

    public User? Get(int id)
    {
        return db.Users.Find(id);
    }

    public User Create(User user)
    {
        db.Users.Add(user);
        db.SaveChanges();

        return user;
    }

    public User Update(User user)
    {
        db.Users.Update(user);
        db.SaveChanges();

        return user;
    }

    public User Delete(User user)
    {
        db.Users.Remove(user);
        db.SaveChanges();

        return user;
    }
}
