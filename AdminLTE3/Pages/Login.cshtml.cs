using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminLTE3.Pages
{
    public class LoginModel : PageModel
    {
        public string FootScript { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPostLogon(string email, string pass)
        {
           
            FootScript = "<script>toastr.success('Hello ,"+email+ "');</script>";
            FootScript += "<script>setTimeout(function(){location.href='Dashboard'},2000);</script>";
            return Page();
        }
    }
}
