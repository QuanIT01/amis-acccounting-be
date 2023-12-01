using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public interface IBaseReadOnlyRepository<TEntity, TModel>
    {
        /// <summary>
        /// Lấy tất cả bản ghi
        /// </summary>
        /// <returns>Danh sách bản ghi</returns>
       
        Task<IEnumerable<TModel>> GetAllAsync();

        /// <summary>
        /// Lấy bản ghi theo Id
        /// </summary>
        /// <param name="entityId">Id của bản ghi</param>
        /// <returns>Đối tượng (trả về NotFoundException nếu không tìm thấy)</returns>
       
        Task<TEntity> GetByIdAsync(Guid entityId);

        /// <summary>
        /// Lấy danh sách bản ghi theo Id
        /// </summary>
        /// <param name="entityIds">Danh sách Id</param>
        /// <returns>Danh sách bản ghi thoả mãn</returns>
        
        Task<IEnumerable<TEntity>> GetListByIdsAsync(IEnumerable<Guid> entityIds);

        /// <summary>
        /// Lấy danh sách bản ghi đầy đủ thông tin đơn vị và vị trí theo Id
        /// </summary>
        /// <param name="entityIds">Danh sách Id</param>
        /// <returns>Danh sách bản ghi thoả mãn</returns>
        
        Task<IEnumerable<TModel>> GetListInfoByIdsAsync(IEnumerable<Guid> entityIds);

        /// <summary>
        /// Tìm bản ghi theo Id
        /// </summary>
        /// <param name="entityId">Id của bản ghi</param>
        /// <returns>Đối tượng (trả về null nếu không tìm thấy)</returns>
       
        Task<TEntity?> FindByIdAsync(Guid entityId);
    }
}
