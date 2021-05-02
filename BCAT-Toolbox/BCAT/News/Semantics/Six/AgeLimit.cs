using MessagePack;
using System.Collections.Generic;

namespace BcatToolbox
{
    [MessagePackObject]
    public class AgeLimitSix
    {
        [Key("ratings")]
        public List<Rating> Ratings
        {
            get;
            set;
        }

    }
}
