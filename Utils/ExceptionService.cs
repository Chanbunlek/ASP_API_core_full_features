using full_webapi_features.Utils;

namespace full_webapi_features.Config;

public class ExceptionService(ErrorCodePattern error) : Exception(error.Message)
{
    public ErrorCodePattern Error { get; set; } = error;
}
