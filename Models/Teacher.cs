using System.ComponentModel.DataAnnotations;

namespace ENIS.Models
{
    public class Teacher
    {

        [Key]
        public int Id { get; set; }
        
        public string Nom { get; set; }
       

        public string Prenom { get; set; }

        
    }
}
