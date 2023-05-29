using System.ComponentModel.DataAnnotations;

namespace demo_project_sql.Models
{
    public class Charge
    {
        [Key, Required]
        public int Id { get; set; }

        public string ProcedureCode { get; set; }

        public string PatientName { get; set;}

        public DateTime EffectiveDate { get; set; }

        public bool isAnchor { get; set; }
    }
}
