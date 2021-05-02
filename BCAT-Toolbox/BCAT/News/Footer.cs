using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class Footer
    {
        [Key("text")]
        public string Text
        {
            get;
            set;
        }

    }
}
