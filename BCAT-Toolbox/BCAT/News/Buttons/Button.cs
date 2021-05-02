using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class Button
    {
        [Key("query")]
        public string Query
        {
            get;
            set;
        }

        [Key("text")]
        public string Text
        {
            get;
            set;
        }

    }
}
