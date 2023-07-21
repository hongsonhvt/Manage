using MISA.WEBFresher042023.DEMO.Core.Enum;

using System.ComponentModel.DataAnnotations;

namespace MISA.WEBFresher042023.DEMO.Core.Entity
{
   
    /// <summary>
    /// Thực thể của Employee
    /// </summary>
    /// Created By: nhson (13/06/2023)
    /// 
    public class Employee
    {
        /// <summary>
        /// khóa chính
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }
        /// <summary>
        /// tên đầy đủ
        /// </summary>

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
        /// <summary>
        /// là nhà cung cấp hay khách hàng
        /// </summary>
        public int? CustomerOrProvider { get; set; }
        /// <summary>
        /// ngày tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// tạo bơi
        /// </summary>
        public string? CreatedBy { get; set; }
        /// <summary>
        /// ngày sửa
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// người sửa
        /// </summary>
        public string? ModifiedBy { get; set; }
    }

}
