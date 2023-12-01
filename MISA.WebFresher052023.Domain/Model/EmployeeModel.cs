using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public class EmployeeModel : BaseAuditEntity, IHasKey
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
       
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
       
        public string EmployeeCode { get; set; } = string.Empty;

        /// <summary>
        /// Tên nhân viên
        /// </summary>
       
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Ngày sinh
        /// </summary>
       
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính (0 - nam, 1 - nữ, 2 - khác)
        /// </summary>
       
        public Gender? Gender { get; set; }

        /// <summary>
        /// Số Chứng minh nhân dân
        /// </summary>
       
        public string? IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp Chứng minh nhân dân
        /// </summary>
       
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi cấp Chứng minh nhân dân
        /// </summary>
       
        public string? IdentityPlace { get; set; }

        /// <summary>
        /// Là khách hàng
        /// </summary>
        
        public bool? IsCustomer { get; set; }

        /// <summary>
        /// Là nhà cung cấp
        /// </summary>
        
        public bool? IsSupplier { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
       
        public string? Address { get; set; }

        /// <summary>
        /// Số điện thoại di động
        /// </summary>
       
        public string? MobilePhoneNumber { get; set; }

        /// <summary>
        /// Số điện thoại cố định
        /// </summary>
       
        public string? LandlineNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
       
        public string? Email { get; set; }

        /// <summary>
        /// Tài khoản ngân hàng
        /// </summary>
       
        public string? BankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng
        /// </summary>
       
        public string? BankName { get; set; }

        /// <summary>
        /// Chi nhánh ngân hàng
        /// </summary>
       
        public string? BankBranch { get; set; }

        /// <summary>
        /// Mã đơn vị (khoá ngoại)
        /// </summary>
       
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Tên đơn vị
        /// </summary>
       
        public string DepartmentName { get; set; } = string.Empty;

        /// <summary>
        /// Mã vị trí (khoá ngoại)
        /// </summary>
       
        public Guid? PositionId { get; set; }

        /// <summary>
        /// Tên vị trí
        /// </summary>
       
        public string? PositionName { get; set; }

        /// <summary>
        /// Lấy Id của đối tượng
        /// </summary>
        /// <returns>Id</returns>
       
        public Guid GetKey()
        {
            return EmployeeId;
        }
    }
}
