using System.ComponentModel.DataAnnotations;

namespace report_project.Models
{
    public class report
    {
        [Key]
        public int reportID { get; set; }

        public string reportTitle { get; set; }

        public string StartDate { get; set; }

        public string FinishDate { get; set; }

        public string ReportSubject { get; set; }

        public string Employee { get; set; }
    }
}
