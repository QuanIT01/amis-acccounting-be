﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public interface IBaseRepository<TEntity, TModel> : IBaseReadOnlyRepository<TEntity, TModel>
    {
        /// <summary>
        /// Tạo đối tượng mới
        /// </summary>
        /// <param name="entity">Data của đối tượng</param>
        /// <returns>Số bản ghi được thêm</returns>
       
        Task<int> InsertAsync(TEntity entity);

        /// <summary>
        /// Cập nhật đối tượng
        /// </summary>
        /// <param name="entity">Data của đối tượng</param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
       
        Task<int> UpdateAsync(TEntity entity);

        /// <summary>
        /// Xoá đối tượng theo Id
        /// </summary>
        /// <param name="entity">Thông tin đối tượng</param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
       
        Task<int> DeleteByIdAsync(TEntity entity);

        /// <summary>
        /// Xoá nhiều đối tượng
        /// </summary>
        /// <param name="entities">Danh sách đối tượng cần xoá</param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
      
        Task<int> DeleteAsync(IEnumerable<TEntity> entities);
    }
}
