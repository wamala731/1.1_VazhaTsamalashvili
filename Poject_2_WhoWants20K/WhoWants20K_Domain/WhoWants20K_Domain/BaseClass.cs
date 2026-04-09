using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Domain
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        DateTime CreatedAt { get; set; } = DateTime.Now;
        DateTime LastUpdatedAt { get; set; } 
        DateTime DeletedAt { get; set; } 
    }
}
