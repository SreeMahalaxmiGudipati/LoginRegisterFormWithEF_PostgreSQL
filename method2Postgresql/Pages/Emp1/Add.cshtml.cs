using method2Postgresql.Data;
using method2Postgresql.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace method2Postgresql.Pages.Emp1
{
    public class AddModel : PageModel
    {
        private readonly APIDbContext dbContext;

        public AddModel(APIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public Employee AddEmployeeRequest { get; set; }

        /*[BindProperty]
        public AddEmployeeViewModel AddEmployeeRequest { get; set; }*/
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            //Convert ViewModel to Domain Model
            var employeeDomainModel = new Employee
            {
                Name = AddEmployeeRequest.Name,
                PhoneNo = AddEmployeeRequest.PhoneNo,
                EmailID = AddEmployeeRequest.EmailID,
                Password = AddEmployeeRequest.Password
            };

            employeeDomainModel.Password = BCrypt.Net.BCrypt.HashPassword(employeeDomainModel.Password);
            dbContext.Employees.Add(employeeDomainModel);
            dbContext.SaveChanges();


            ViewData["Message"] = "Employee Created Successfully!!";
            return RedirectToPage("./Login1");
        }

    }
}
