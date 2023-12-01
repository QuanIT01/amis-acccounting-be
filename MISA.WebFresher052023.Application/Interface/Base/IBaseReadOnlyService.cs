using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Application
{
    public interface IBaseReadOnlyService<TEntityDto>
    {
        /// <summary>
        /// Lấy tất cả đối tượng
        /// </summary>
        /// <returns>Danh sách đối tượng</returns>
       
        Task<IEnumerable<TEntityDto>> GetAllAsync();

        /// <summary>
        /// Lấy đối tượng theo Id
        /// </summary>
        /// <param name="entityId">Id của đối tượng</param>
        /// <returns>Đối tượng</returns>
       
        Task<TEntityDto> GetByIdAsync(Guid entityId);
    }
}
