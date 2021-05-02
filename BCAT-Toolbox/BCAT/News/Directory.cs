using MessagePack;
using System.Collections.Generic;

namespace BcatToolbox
{
    [MessagePackObject]
    public class DirectoryN
    {
        [Key("name")]
        public string Name
        {
            get;
            set;
        }

        [Key("mode")]
        public string Mode
        {
            get;
            set;
        }

        [Key("by_country_group")]
        public bool ByCountryGroup
        {
            get;
            set;
        }

        [Key("digest")]
        public string Digest
        {
            get;
            set;
        }

        [Key("data_list")]
        public List<Data> Data
        {
            get;
            set;
        }

    }
}
