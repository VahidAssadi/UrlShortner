namespace SD.UrlShortener.Models;

public class UrlShorteningRequest
{
    public UrlShorteningRequest(string url)
    {
        Url = url;
    }

    public string Url { get; set; }
}

public class UrlShorteningResponse
{
    public UrlShorteningResponse(string url)
    {
        Url = url;
    }

    public string Url { get; set; }
}