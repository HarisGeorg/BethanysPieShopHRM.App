using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; } // (1) Gets the EmployeeId value from   @page "/employeedetail/{EmployeeId}"   of .razor

        public Employee Employee { get; set; } = new Employee();

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees
                .FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));    // (2) Gets the employee obj with Id == (1)

            return base.OnInitializedAsync();
        }
    }
}
