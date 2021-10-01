using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE3.Pages
{
    public class IndexModel : PageModel
    {


        public void OnGet()
        {
            Response.Redirect("Login");
        }
    }
}
