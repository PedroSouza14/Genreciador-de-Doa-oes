using System.ComponentModel.DataAnnotations;
namespace CadastroDoador.cs;

public class CadastroDoador
{
    [Key]
    public int Cpf { get; set; }

    [MaxLenght(100)]
    public string Nome { get; set; }

    [MaxLenght(255)]
    public string Endereço { get; set; }

    [MaxLenght(100)]
    public string  Email { get; set; }

    public int Telefone { get; set; }

    [Lenght]
    public string Senha { get; set; } 
}
