using MessagePack;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BcatToolbox
{
    [MessagePackObject]
    public class Topic
    {
        [Key("topic_id")]
        public string TopicId
        {
            get;
            set;
        }

        [Key("service_status")]
        public string ServiceStatus
        {
            get;
            set;
        }

        [Key("na_required")]
        public bool NaRequired
        {
            get;
            set;
        }

        [Key("required_application_version")]
        public int RequiredAppVersion
        {
            get;
            set;
        }

        [Key("directories")]
        public List<DirectoryN> Directories
        {
            get;
            set;
        }

        [Key("topic_description")]
        public string TopicDescription
        {
            get;
            set;
        }

        [Key("topic_image")]
        public byte[] TopicImage
        {
            get;
            set;
        }

        [Key("topic_name")]
        public string TopicName
        {
            get;
            set;
        }

        [Key("topic_publisher")]
        public string TopicPublisher
        {
            get;
            set;
        }

        [Key("published_at")]
        public int PublishedAt
        {
            get;
            set;
        }
    }
}
