using System;
using System.Collections.Generic;

namespace UrlControlProject.Models
{
    public partial class UrlControl
    {
        public UrlControl()
        {
            Responses = new HashSet<Responses>();
            Time = new HashSet<Time>();
        }

        public int Id { get; set; }
        public string UrlName { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Responses> Responses { get; set; }
        public virtual ICollection<Time> Time { get; set; }
    }
}
