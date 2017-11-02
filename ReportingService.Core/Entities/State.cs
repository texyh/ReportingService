using System;

namespace ReportingService.Core.Entities
{
    public class State
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Guid SalesRepId { get; set; }

        public User SalesRep { get; set; }
        
    }
}