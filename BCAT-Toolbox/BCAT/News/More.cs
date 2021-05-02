using MessagePack;

namespace BcatToolbox
{
    [MessagePackObject]
    public class More
    {
        [Key("game")]
        public GameButton GameButton
        {
            get;
            set;
        }

        [Key("shop")]
        public ShopButton ShopButton
        {
            get;
            set;
        }

    }
}
