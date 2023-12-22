using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForecastingApplication.Models
{
    public class ForecastModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public string? AgeGroup { get; set; }
        public string? Year { get; set; }
        public int Value { get; set; }
    }

 
}
