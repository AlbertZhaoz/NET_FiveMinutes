using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_FiveMinutes_002_CrawlZhihu.Interfaces
{
    public interface IBaseCrawl
    {
        string DownloadUrl(string url);
    }
}
