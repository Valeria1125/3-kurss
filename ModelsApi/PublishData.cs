using System;

namespace couse_work_web.ModelsApi
{
    public class PublishData : ApiBaseType
    {
        public string Date { get; set; }
        public PublishingApi Publish { get; set; }
    }
}