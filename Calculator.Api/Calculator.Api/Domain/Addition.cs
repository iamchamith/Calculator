using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Api.Domain
{

    [Table(nameof(Addition))]
    public class Addition
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double FirstNumber { get; set; }
        [Required]
        public double SecondNumber { get; set; }
        [Required]
        public double Result { get; set; }
    }
}
