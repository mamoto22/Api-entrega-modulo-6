using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEntrega6.Models
{

    [Table("cliente")]
    public class Cliente
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Column("Idade")]
        public string Idade { get; set; } = string.Empty;

        [Column("Telefone")]
        public string Telefone { get; set; }

    }






}
