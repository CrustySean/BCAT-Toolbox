using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class Subject
    {
        [Key("caption")]
        public int Caption
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
