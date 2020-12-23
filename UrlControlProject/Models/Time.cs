using System;
using System.Collections.Generic;

namespace UrlControlProject.Models
{
    public partial class Time
    {
        public int Id { get; set; }
        public int? UrlControlId { get; set; }

        public virtual UrlControl UrlControl { get; set; }
    }
}
