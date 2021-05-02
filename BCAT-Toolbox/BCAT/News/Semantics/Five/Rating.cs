using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class Rating
    {
        [Key("name")]
        public string Name
        {
            get;
            set;
        }

        [Key("age")]
        public int Age
        {
            get;
            set;
        }

    }
}
