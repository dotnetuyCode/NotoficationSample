using NotoficationSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotoficationSample.IService
{
    public interface INotiService
    {
        List<Noti> GetNotifications(int nToUSerId, bool bIsGetOnlyUnread);
    }
}
