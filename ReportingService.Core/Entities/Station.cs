using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingService.Core.Entities
{
    public class Station
    {
        public Guid Id { get; set; }

        public string  Name { get; set; }

        public string  Address { get; set; }
        
        public bool IsMega { get; set; }

        public long StateId { get; set; }

        public virtual State State { get; set; }
        
    }
}
