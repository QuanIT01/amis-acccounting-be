using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        DbConnection Connection { get; }
        DbTransaction? Transaction { get; }

        /// <summary>
        /// Bắt đầu một transaction
        /// </summary>
        /// CreatedBy: 
        void BeginTransaction();

        /// <summary>
        /// Bắt đầu một transaction bất đồng bộ
        /// </summary>
        /// CreatedBy: 
        Task BeginTransactionAsync();

        /// <summary>
        /// Xác nhận và thực thi
        /// </summary>
        /// CreatedBy: 
        void Commit();

        /// <summary>
        /// Xác nhận và thực thi bất đồng bộ
        /// </summary>
        /// CreatedBy: 
        Task CommitAsync();

        /// <summary>
        /// Hoàn tác transaction
        /// </summary>
        /// CreatedBy: 
        void RollBack();

        /// <summary>
        /// Hoàn tác transaction bất đồng bộ
        /// </summary>
        /// CreatedBy: 
        Task RollBackAsync();
    }
}
