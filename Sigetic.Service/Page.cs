using Desyco.Abstractions;
using System.Collections.Generic;

namespace Sigetic.Service
{
    public class Page
    {
        public Page(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public Page() : this(1,10)
        {

        }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
    }
    public class JiraParams
    {
        public JiraParams()
        {
            Page = new Page(1, 10);
            //ExtendedAttributes = new Dictionary<string, object>();
            Filters = new List<DesycoFilter>();
        }
        public Page Page { get; set; }
        public List<DesycoFilter> Filters { get; set; }
        //public Dictionary<string, object> ExtendedAttributes { get; set; }
    }
}
