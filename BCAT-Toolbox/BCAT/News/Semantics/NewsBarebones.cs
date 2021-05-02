using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class NewsBarebones
    {
        [Key("version")]
        public Version Version
        {
            get;
            set;
        }

    }
}
