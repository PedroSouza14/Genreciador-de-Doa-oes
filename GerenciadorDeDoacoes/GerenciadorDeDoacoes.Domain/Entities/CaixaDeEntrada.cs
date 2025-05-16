using System.ComponentModel.DataAnnotations;
namespace CaixaDeEntrada.cs;

public class CaixaDeEntrada
{
    [Key]
    public int Id { get; set; }

    [MaxLength(20)]
    [ForeignKey]
    public string Ong_Cnpj { get; set; }

    [ForeignKey]
    public int CadastroDoador_Cpf { get; set; }

    [MaxLenght(100)]
    public string Assunto { get; set; }

    [MaxLength(255)]
    public string Texto { get; set; }

    public DateTime Registro { get; set; } 

    public bool Aceito { get; set; }
}