using MessagePack;
using System.Collections.Generic;

namespace BcatToolbox
{
    [MessagePackObject]
    public class NewsSix : NewsR
    {
        [Key("age_limits")]
        public List<AgeLimitFive> AgeLimits
        {
            get;
            set;
        }

        [Key("body")]
        private List<Body> _Bodies
        {
            get;
            set;
        }

        [Key("rating_information")]
        public List<RatingInformation> RatingInformation
        {
            get;
            set;
        }

        [IgnoreMember]
        public override List<Body> Bodies
        {
            get
            {
                return _Bodies;
            }
            set
            {
                _Bodies = value;
            }
        }

    }
}
