using System.ComponentModel.DataAnnotations;

namespace mvc2.Models
{
    public class ClienteModel
    {
        [Key]
        [MaxLength()]
        public string? CLI_CODIGON {get; set;}
        public string? CLI_CGC {get; set;}
        public string? CLI_NOME {get; set;}
        
    }
}