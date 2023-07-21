using System.Diagnostics.CodeAnalysis;

using Dapper;

using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Entity;
using MISA.WEBFresher042023.DEMO.Core.Interface.Repository;
using MISA.WEBFresher042023.DEMO.Core.Interface.Service;
using MISA.WEBFresher042023.DEMO.MISAException;
using MySqlConnector;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.WEBFresher042023.DEMO.Controllers
{
    private readonly IEmployeeService employeeService;

    public EmployeesController(IEmployeeService employeeService)
        : base(employeeService)
    {
        _employeeService = employeeService;
    }
}
