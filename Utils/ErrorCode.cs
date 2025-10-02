namespace full_webapi_features.Utils;

public class ErrorCode
{
    public static ErrorCodePattern NotFound(string message = "") {
        return new (404, message ?? "Not found!");
    }
}

public class ErrorCodePattern(int code, string message)
{
    public int Code { get; set; } = code;

    public string Message { get; set; } = message;
}
