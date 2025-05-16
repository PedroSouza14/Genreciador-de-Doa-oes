using System.ComponentModel.DataAnnotations;
namespace Ong.cs;
public class ONG
{
    [Key]
    [MaxLength(20)]
    public string Cnpj { get; set; }

    [MaxLength(255)]
    public string Nome { get; set; }

    [MaxLength(100)]
    public string Endereço { get; set; }

    public int Cep { get; set; }

    [MaxLength(11)]
    public string Telefone { get; set; }

    [MaxLength(255)]
    public string Email { get; set; }

    [Length]
    public string Senha { get; set; }

    public string Logo { get; set; }

    [MaxLength(150)]
    public string Instagram { get; set; }

    [MaxLength(150)]
    public string Facebook { get; set; }

    [MaxLength(150)]
    public string Site { get; set; }
}

