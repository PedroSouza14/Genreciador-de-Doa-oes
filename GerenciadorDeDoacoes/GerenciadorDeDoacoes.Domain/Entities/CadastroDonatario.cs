using System.ComponentModel.DataAnnotations;
namespace CaixaDeEntrada.cs;

public class CadastroDonatario {
    [Key]
    public int Cpf {  get; set; }

    [MaxLenght(20)]
    [ForeignKey]
    public string  Ong_Cnpj { get; set; }

    [MaxLenght(100)]
    public string Nome { get; set; }

    [MaxLength(255)]
    public string Endereço { get; set; }

    public int Cep { get; set; }

    [MaxLength(100)]
    public string Email { get; set; }

    public int Telefone { get; set; }
} 