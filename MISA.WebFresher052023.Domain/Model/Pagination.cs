using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public class Pagination
    {
        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        
        public object? Data { get; set; }

        /// <summary>
        /// Tổng số bản ghi
        /// </summary>
        
        public int? TotalRecords { get; set; }
    }
}
