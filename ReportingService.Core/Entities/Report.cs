using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingSystem.Core.Entities
{
    public class Report
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public long AgoReportId { get; set; }

        public long PmsReportId { get; set; }

        public long DpkReportId { get; set; }

        public virtual AgoReport AgoReport { get; set; }

        public virtual DpkReport DpkReport { get; set; }

        public virtual PmsReport PmsReport { get; set; }
    }
}
