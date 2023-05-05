using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages.ItemTemplates
{
    public class TrackIslandModel : PageModel
    {
       
        public void OnGet()
        {
            ViewData["artist"] = "timer";
            ViewData["trackname"] = "€ рон€ю KFU";
        }
    }
}
