using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace simpleWeb.Pages
{
    public class ShoppingCartModel : PageModel
    {
        private readonly ILogger<ShoppingCartModel> _logger;

        public ShoppingCartModel(ILogger<ShoppingCartModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
