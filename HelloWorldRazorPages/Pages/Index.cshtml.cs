using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HelloWorldRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Message { get; set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Address { get; set; }

       

        [BindProperty]
        public Car Car { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            
            Car = new Car(){Name = "Toyota", Year = 2020};
            Message = "Hej fra index page model ";
            _logger = logger;
        }

        public void OnGet()
        {
            Address = "Gade 123, 4000 Roskilde";
            _name = "Velkommen GET requetil Pouls hjemmeside";
        }

        public void OnPost()
        {
            _name = "Velkommen POst request til Pouls hjemmeside";
        }
    }
}
