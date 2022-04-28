using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace couse_work_web.ModelsApi
{
    public class BookApi : ApiBaseType
    {
        public string TitleBook { get; set; }

        public List<AuthorApi> Authors { get; set; }
        public List<GenreApi> Genres { get; set; }
        public List<PublishData> Publishes { get; set; }
    }
}
