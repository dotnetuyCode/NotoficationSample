using Common;
using Dapper;
using NotoficationSample.IService;
using NotoficationSample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NotoficationSample.Service
{
    public class NotiService:INotiService
    {
        List<Noti> _oNotifications = new List<Noti>();

        public List<Noti> GetNotifications(int nToUSerId, bool bIsGetOnlyUnread)
        {
            _oNotifications = new List<Noti>();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                var oNotis = con.Query<Noti>("SELECT * FROM View_Notification WHERE ToUserID=" + nToUSerId).ToList();

                if (oNotis != null && oNotis.Count() > 0)
                {
                    _oNotifications = oNotis;
                }

                return _oNotifications;
            }
        }
    }
}
