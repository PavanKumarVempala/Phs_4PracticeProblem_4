using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeProblem_4.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public double Salary {  get; set; }
        [Required]
        [StringLength(100)]
        public string Designation {  get; set; }
    }
}
