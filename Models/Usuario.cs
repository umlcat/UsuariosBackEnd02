using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsuariosBackEnd02.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public int Edad {  get; set; }
    } // usuario

    // ...

} // nmaespace
