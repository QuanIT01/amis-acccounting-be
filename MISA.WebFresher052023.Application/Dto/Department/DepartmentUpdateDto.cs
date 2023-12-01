using MISA.WebFresher052023.Domain.Resources.InputValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Application
{
    public class DepartmentUpdateDto
    {
        /// <summary>
        /// Mã đơn vị
        /// </summary>
       
        [Required(ErrorMessageResourceName = nameof(InputValidation.IsRequired), ErrorMessageResourceType = typeof(InputValidation))]
        [StringLength(20, ErrorMessageResourceName = nameof(InputValidation.MaxLength), ErrorMessageResourceType = typeof(InputValidation))]
        [RegularExpression(@"[a-zA-Z]{1,}-[0-9]{4,}", ErrorMessageResourceName = nameof(InputValidation.CodeFormat), ErrorMessageResourceType = typeof(InputValidation))]
        public string DepartmentCode { get; set; } = string.Empty;

        /// <summary>
        /// Tên đơn vị
        /// </summary>
       
        [Required(ErrorMessageResourceName = nameof(InputValidation.IsRequired), ErrorMessageResourceType = typeof(InputValidation))]
        [StringLength(255, ErrorMessageResourceName = nameof(InputValidation.MaxLength), ErrorMessageResourceType = typeof(InputValidation))]
        public string DepartmentName { get; set; } = string.Empty;

        /// <summary>
        /// Mô tả
        /// </summary>
       
        [StringLength(255, ErrorMessageResourceName = nameof(InputValidation.MaxLength), ErrorMessageResourceType = typeof(InputValidation))]
        public string? Description { get; set; }
    }
}
