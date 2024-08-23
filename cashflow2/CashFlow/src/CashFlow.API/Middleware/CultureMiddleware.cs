using System.Globalization;

namespace CashFlow.API.Middleware;

public class CultureMiddleware
{
    private readonly RequestDelegate _next;
    
    public CultureMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var supportedLangagues = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();

        var requestedculture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

        var cultureInfo = new CultureInfo("en");      
        
        if (string.IsNullOrEmpty(requestedculture) == false 
            && supportedLangagues.Exists(language => language.Name.Equals(requestedculture)))
        {
            cultureInfo = new CultureInfo(requestedculture);
        }

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        await _next(context);
    }
}
