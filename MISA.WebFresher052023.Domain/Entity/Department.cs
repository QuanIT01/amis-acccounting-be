using System.ComponentModel.DataAnnotations;

namespace MISA.WebFresher052023.Domain
{
    public class Department : BaseAuditEntity, IHasKey
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
       
        [Required]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Mã đơn vị
        /// </summary>
       
        [Required]
        [StringLength(20)]
        public string DepartmentCode { get; set; } = string.Empty;

        /// <summary>
        /// Tên đơn vị
        /// </summary>
       
        [Required]
        [StringLength(255)]
        public string DepartmentName { get; set; } = string.Empty;

        /// <summary>
        /// Mô tả
        /// </summary>
       
        [StringLength(255)]
        public string? Description { get; set; }

        /// <summary>
        /// Lấy Id của đơn vị
        /// </summary>
        /// <returns>Id đơn vị</returns>
       
        public Guid GetKey()
        {
            return DepartmentId;
        }
    }
}
