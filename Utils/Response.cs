namespace full_webapi_features.Utils;

public record Response<T>(int Code, T? Data, string? Message, bool? Status, string Path, DateTime TimeStamp)
{
    public static Response<T> Ok(T data, string path)
    {
        return new(200, data, "Successful", true, path, DateTime.UtcNow);
    }

    public static Response<T> Failed(string path, string message = "")
    {
        return new(401, default, message, false, path, DateTime.UtcNow);
    }

    public static Response<T> Failed(int code, string path, string message = "", string reason = "")
    {
        return new(code, default, message, false, path, DateTime.UtcNow);
    }
}
