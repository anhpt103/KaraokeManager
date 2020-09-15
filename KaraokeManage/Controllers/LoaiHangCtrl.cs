using KaraokeManage.Common;
using KaraokeManage.Models;
using log4net;
using System;
using System.Collections.Generic;

namespace KaraokeManage.Controllers
{
    public class LoaiHangCtrl
    {
        private static readonly ILog log = LogManager.GetLogger(Environment.MachineName);
        public string GetDataLoaiHang(out List<LoaiHangModel> oListLoaiHang)
        {
            string msg = Exec.GetList("usp_GetLoaiHang", out oListLoaiHang);
            if (!string.IsNullOrEmpty(msg)) { log.Error(msg); return msg; }

            return "";
        }
    }
}
