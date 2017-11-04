using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingSystem.Core.Entities
{
    public class AgoReport
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public int OpeningStock { get; set; }

        public int QuantityDelivered { get; set; }

        public int ClosingStock { get; set; }

        public int TotalSales { get; set; }
        
        public Guid StationId { get; set; }

        public virtual Station Station { get; set; }
    }
}
