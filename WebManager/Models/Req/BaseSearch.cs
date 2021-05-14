using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Models.Req
{
    public class BaseSearch
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int pagesize { get; set; }
        /// <summary>
        /// 页
        /// </summary>
        public int page { get; set; }
    }
}
