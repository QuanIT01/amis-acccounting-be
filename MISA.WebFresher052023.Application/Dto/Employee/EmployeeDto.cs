using MISA.WebFresher052023.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Application
{
    public class EmployeeDto
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        /// CreatedBy: 
        [Required]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        /// CreatedBy: 
        [Required]
        [StringLength(20)]
        public string EmployeeCode { get; set; } = string.Empty;

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        /// CreatedBy: 
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Ngày sinh
        /// </summary>
        /// CreatedBy: 
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính (0 - nam, 1 - nữ, 2 - khác)
        /// </summary>
        /// CreatedBy: 
        public Gender? Gender { get; set; }

        /// <summary>
        /// Số Chứng minh nhân dân
        /// </summary>
        /// CreatedBy: 
        [StringLength(25)]
        public string? IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp Chứng minh nhân dân
        /// </summary>
        /// CreatedBy: 
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi cấp Chứng minh nhân dân
        /// </summary>
        /// CreatedBy: 
        [StringLength(255)]
        public string? IdentityPlace { get; set; }

        /// <summary>
        /// Là khách hàng
        /// </summary>
        /// CreatedBy: 
        public bool? IsCustomer { get; set; }

        /// <summary>
        /// Là nhà cung cấp
        /// </summary>
        /// CreatedBy: 
        public bool? IsSupplier { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        /// CreatedBy: 
        [StringLength(255)]
        public string? Address { get; set; }

        /// <summary>
        /// Số điện thoại di động
        /// </summary>
        /// CreatedBy: 
        [StringLength(50)]
        public string? MobilePhoneNumber { get; set; }

        /// <summary>
        /// Số điện thoại cố định
        /// </summary>
        /// CreatedBy: 
        [StringLength(50)]
        public string? LandlineNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// CreatedBy: 
        [StringLength(100)]
        public string? Email { get; set; }

        /// <summary>
        /// Tài khoản ngân hàng
        /// </summary>
        /// CreatedBy: 
        [StringLength(25)]
        public string? BankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        /// CreatedBy: 
        [StringLength(255)]
        public string? BankName { get; set; }

        /// <summary>
        /// Chi nhánh ngân hàng
        /// </summary>
        /// CreatedBy: 
        [StringLength(255)]
        public string? BankBranch { get; set; }

        /// <summary>
        /// Mã đơn vị
        /// </summary>
        /// CreatedBy: 
        [Required]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Tên đơn vị
        /// </summary>
        /// CreatedBy: 
        public string? DepartmentName { get; set; }

        /// <summary>
        /// Mã vị trí
        /// </summary>
        /// CreatedBy: 
        public Guid? PositionId { get; set; }

        /// <summary>
        /// Tên vị trí
        /// </summary>
        /// CreatedBy: 
        public string? PositionName { get; set; }
    }
}
