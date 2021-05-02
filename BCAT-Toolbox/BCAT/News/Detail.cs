using System.Collections.Generic;
using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class Detail : Entry
    {
        [Key("latest_news_urls")]
        public List<string> LatestNewsUrls
        {
            get;
            set;
        }
        
    }
}