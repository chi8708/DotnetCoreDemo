using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
namespace aspnetcoreapp.Pages
{
    public class IndexModel3 : PageModel
    {
        public string Message { get; set; } = "pageModel in C#";

        public void OnGet()
        {
            Message+=$"server Time is { DateTime.Now }";
        }
    }
}