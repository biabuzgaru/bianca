using System.ComponentModel.DataAnnotations;

namespace proiect.Models
{
    public class Floare
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Nume { get; set; }
     
    }
}
