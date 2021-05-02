using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class Version
    {
        [Key("format")]
        public int Format
        {
            get;
            set;
        }

        [Key("semantics")]
        public int Semantics
        {
            get;
            set;
        }

    }
}
