using System.ComponentModel.DataAnnotations;

namespace MISA.WebFresher052023.Domain
{
    public class Position : BaseAuditEntity, IHasKey
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        
        [Required]
        public Guid PositionId { get; set; }

        /// <summary>
        /// Mã vị trí
        /// </summary>
        
        [Required]
        [StringLength(20)]
        public string PositionCode { get; set; } = string.Empty;

        /// <summary>
        /// Tên vị trí
        /// </summary>
        
        [Required]
        [StringLength(255)]
        public string PositionName { get; set; } = string.Empty;

        /// <summary>
        /// Mô tả
        /// </summary>
        
        [StringLength(255)]
        public string? Description { get; set; }

        /// <summary>
        /// Lấy id của vị trí
        /// </summary>
        /// <returns>Id của vị trí</returns>
       
        public Guid GetKey()
        {
            return PositionId;
        }
    }
}
