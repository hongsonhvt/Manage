using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISA.WEBFresher042023.DEMO.Core.Enum;

namespace MISA.WEBFresher042023.DEMO.Core.Dto
{
    public class EmployeeUpdateDto
    {
        /// <summary>
        /// mã nhân viên
        /// </summary>
        [Required(ErrorMessage = "Mã không được để trống ")]
        public string EmployeeCode { get; set; }
        /// <summary>
        /// tên đầy đủ
        /// </summary>
        [Required(ErrorMessage = "Tên không được để trống ")]

        public string FullName { get; set; }
        /// <summary>
        /// ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// giới tính
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// khóa ngoại id của phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// tên phòng ban
        /// </summary>
        public String? DepartmentName { get; set; }
        /// <summary>
        /// chứng minh thư nhân dân
        /// </summary>
        public string? IdentityNumber { get; set; }
        /// <summary>
        /// ngày cấp
        /// </summary>
        public DateTime? IdentityDate { get; set; }
        /// <summary>
        /// nơi cấp
        /// </summary>
        public string? IdentityAddress { get; set; }
        /// <summary>
        /// chức danh
        /// </summary>
        public string? PositionName { get; set; }
        /// <summary>
        /// địa chỉ
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// số điện thoại
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// số điện thoại bàn
        /// </summary>
        public string? PhoneLandline { get; set; }
        /// <summary>
        /// email
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// số tài khoản ngân hàng
        /// </summary>
        public string? BankAccount { get; set; }
        /// <summary>
        /// tên ngân hàng
        /// </summary>
        public string? BankName { get; set; }
        /// <summary>
        /// chi nhánh
        /// </summary>
        public string? BankBranch { get; set; }
    }
}
