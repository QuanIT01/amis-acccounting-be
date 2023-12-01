using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public interface IEmployeeRepository : IBaseCodeRepository<Employee, EmployeeModel>
    {
        /// <summary>
        /// Tìm kiếm, filter và phân trang
        /// </summary>
        /// <param name="search">Search theo tên hoặc mã nhân viên</param>
        /// <param name="currentPage">trang hiện tại</param>
        /// <param name="pageSize">Số phần tử trên trang</param>
        /// <returns>Danh sách nhân viên đã được filter và phân trang</returns>
        /// CreatedBy:
        Task<Pagination> FilterAsync(string search, int currentPage, int pageSize);
    }
}
