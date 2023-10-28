using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase1.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<string> Profesiones { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var list = new List<string>();
        
        list.Add("vendedor");
        list.Add("Analista");
        list.Add("Administrativo");
        list.Add("Profesor");
        list.Add("Empresario");

        Profesiones = list;
        
    }
}
