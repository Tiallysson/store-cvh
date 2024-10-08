using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models 
{
    [Table("tb_credenciais")]
    public class Credencial
    {
        [Column("id_credencial")]
        [Key]
        public long Id {get; set;}

        // Mapeia suas propriedades para colunas em uma tabela de banco de dados.
        [Column("email")]
        public required string Email {get; set;}

        [Column("senha")]
        [MaxLength(10)]
        public required string Senha {get; set;}
        
        [ForeignKey("UsuarioId")]
        [Column("id_usuario")]
        public long UsuarioId {get; set;}

        public Usuario Usuario {get; set;}
    }
}