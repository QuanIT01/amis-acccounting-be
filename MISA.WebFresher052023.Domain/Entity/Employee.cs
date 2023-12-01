using System.ComponentModel.DataAnnotations;

namespace MISA.WebFresher052023.Domain
{
    public class Employee : BaseAuditEntity, IHasKey
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
       
        [Required]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
       
        [Required]
        [StringLength(20)]
        public string EmployeeCode { get; set; } = string.Empty;

        /// <summary>
        /// Tên nhân viên
        /// </summary>
       
        [Required]
        [StringLength(100)]
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
       
        [StringLength(25)]
        public string? IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp Chứng minh nhân dân
        /// </summary>
       
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi cấp Chứng minh nhân dân
        /// </summary>
       
        [StringLength(255)]
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
       
        [StringLength(255)]
        public string? Address { get; set; }

        /// <summary>
        /// Số điện thoại di động
        /// </summary>
       
        [StringLength(50)]
        public string? MobilePhoneNumber { get; set; }

        /// <summary>
        /// Số điện thoại cố định
        /// </summary>
       
        [StringLength(50)]
        public string? LandlineNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
       
        [StringLength(100)]
        public string? Email { get; set; }

        /// <summary>
        /// Tài khoản ngân hàng
        /// </summary>
       
        [StringLength(25)]
        public string? BankAccount { get; set; }

        /// <summary>
        /// Tên ngân hàng
        /// </summary>
       
        [StringLength(255)]
        public string? BankName { get; set; }

        /// <summary>
        /// Chi nhánh ngân hàng
        /// </summary>
       
        [StringLength(255)]
        public string? BankBranch { get; set; }

        /// <summary>
        /// Mã đơn vị (khoá ngoại)
        /// </summary>
       
        [Required]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Mã vị trí (khoá ngoại)
        /// </summary>
       
        [StringLength(36)]
        public Guid? PositionId { get; set; }

        /// <summary>
        /// Lấy Id của đối tượng
        /// </summary>
        /// <returns>Id của đối tượng</returns>
       
        public Guid GetKey()
        {
            return EmployeeId;
        }
    }
}
