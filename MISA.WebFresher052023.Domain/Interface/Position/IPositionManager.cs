﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Domain
{
    public interface IPositionManager
    {
        /// <summary>
        /// Check trùng mã vị trí
        /// </summary>
        /// <param name="positionCode">Mã vị trí</param>
        /// <param name="oldPositionCode">Mã vị trí cũ (trong trường hợp cập nhật mã)</param>
        /// CreatedBy: 
        Task CheckExistPositionCode(string positionCode, string? oldPositionCode = null);
    }
}
