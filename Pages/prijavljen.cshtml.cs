using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _4fit.Pages
{
    [Authorize(Roles="k,t")]
    public class prijavljenModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
