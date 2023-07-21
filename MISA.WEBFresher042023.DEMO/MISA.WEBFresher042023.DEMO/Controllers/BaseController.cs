using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Interface.Service;

namespace MISA.WEBFresher042023.DEMO.Controllers
{
    
    [ApiController]

    public class BaseController<TEntityDto, TEntityCreateDto, TEntityUpdateDto> : ControllerBase
    {
        protected readonly IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto> _baseService;
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var entityDto = await _baseService.GetAsync(id);

            return StatusCode(StatusCodes.Status200OK, entityDto);
        }

        /// <summary>
        /// Phân trang va tìm kiếm
        /// </summary>
        /// <param name="page">Số trang</param>
        /// <param name="pageSize">Tổng số bản ghi trong 1 trang</param>
        /// <param name="employeeFilter">Thông tin để tìm kiếm nhân viên</param>
        /// <returns>Những nhân viên liên quan</returns>
        /// Created by: dbkhang 18/06/2023
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10, string? employeeFilter = "")
        {

            var employees = await _baseService.GetListAsync(page, pageSize, employeeFilter);

            return StatusCode(StatusCodes.Status200OK, employees);
        }

        /// <summary>
        /// Tạo một nhân viên mới
        /// </summary>
        /// <param name="employee">Thông tin của nhân viên đó</param>
        /// <returns>Tạo được nhân viên</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeCreateDto employee)
        {
            int result = await _baseService.InsertAsync(employee);

            if (result > 0)
            {
                return StatusCode(201, employee);
            }
            else
            {
                return BadRequest(result.ToString());
            }
        }

        /// <summary>
        /// Chỉnh sửa thông tin nhân viên
        /// </summary>
        /// <param name="id">Id của nhân viên cần sửa</param>
        /// <param name="employee">Thông tin cần sửa </param>
        /// <returns>Thông tin nhân viên được cập nhật </returns>
        /// Created by: dbkhang 18/06/2023
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] EmployeeUpdateDto employee)
        {
            int result = await _employeeService.UpdateEmployeeAsync(id, employee);

            return StatusCode(204);
        }

        /// <summary>
        /// Xoá nhân viên theo Id
        /// </summary>
        /// <param name="id">Id của nhân viên cần xoá</param>
        /// <returns>xoá thahf công</returns>
        /// Created by: dbkhang 18/06/2023
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            int result = await _employeeService.DeleteEmployeeAsync(id);

            return StatusCode(204, result);
        }
    }
}
