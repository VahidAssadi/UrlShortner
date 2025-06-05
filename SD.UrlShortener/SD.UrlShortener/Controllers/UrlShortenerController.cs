using Microsoft.AspNetCore.Mvc;
using SD.UrlShortener.Models;

namespace SD.UrlShortener;

[Route("api/v1/urls")]
public class UrlShortenerController : Controller
{
    // POST
    [HttpPost]

    public IActionResult Shorten([FromBody] UrlShorteningRequest request)
    {
        return View();
    }

    [HttpGet]
    [Route("{shortcode}")]
    public ActionResult RedirectToOriginal()
    {
        return Ok(new UrlShorteningResponse(string.Empty));
    }
}