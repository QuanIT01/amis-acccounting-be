using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public abstract class BaseAuditEntity
    {
        /// <summary>
        /// Ngày tạo
        /// </summary>
        
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        
        [StringLength(255)]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa
        /// </summary>
        
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        
        [StringLength(255)]
        public string? ModifiedBy { get; set; }
    }
}
