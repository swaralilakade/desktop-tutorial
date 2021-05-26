using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace simpleWeb.Pages
{
    public class AboutusModel : PageModel
    {
        private readonly ILogger<AboutusModel> _logger;

        public AboutusModel(ILogger<AboutusModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
