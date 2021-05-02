using MessagePack;
using System.Collections.Generic;

namespace BcatToolbox
{
    [MessagePackObject]
    public class AgeLimitFive
    {
        [Key("ratings")]
        public List<Rating> Ratings
        {
            get;
            set;
        }

    }
}
