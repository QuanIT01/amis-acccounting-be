using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Application
{
    public interface IExcelCore<TEntityDto>
    {
        /// <summary>
        /// Xử lý xuất file Excel
        /// </summary>
        /// <returns>Mảng bytes của file Excel</returns>
        
        byte[] ExportToExcelAsync(IEnumerable<TEntityDto> entityDtos, IEnumerable<string> columns);

        /// <summary>
        /// Xử lý nhập file Excel
        /// </summary>
        /// <returns>Mảng bytes của file Excel</returns>
        
        void ImportFromExcelAsync();
    }
}
