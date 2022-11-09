﻿using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void NavigateToDetails(Employee selectedEmployee)
        {
            NavigationManager.NavigateTo($"/employeedetail/{selectedEmployee.EmployeeId}");
        }
    }
}
