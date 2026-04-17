using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Domain
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } 
        public DateTime DeletedAt { get; set; } 
    }
}
