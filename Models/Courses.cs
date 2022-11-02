using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ENIS.Models
{
    public class Courses
    {

        [Key]
        public int Id { get; set; }
        
        public string Nom { get; set; }
       
        

    }
}
