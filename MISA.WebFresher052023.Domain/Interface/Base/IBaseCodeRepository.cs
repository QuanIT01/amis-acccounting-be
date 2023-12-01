﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public interface IBaseCodeRepository<TEntity, TModel> : IBaseRepository<TEntity, TModel>
    {
        /// <summary>
        /// Lấy đối tượng theo mã
        /// </summary>
        /// <param name="entityCode">Mã</param>
        /// <returns>Đối tượng (trả về null nếu không tìm thấy)</returns>
        
        Task<TEntity?> FindByCodeAsync(string entityCode);

        /// <summary>
        /// Lấy mã mới
        /// </summary>
        /// <returns>Mã mới</returns>
        
        Task<string?> FindNewCodeAsync();
    }
}
