using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2.Models
{
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CLI_CODIGON {get; set;}
        public string? CLI_CGC {get; set;}
        public string? CLI_NOME {get; set;}
        
    }
}