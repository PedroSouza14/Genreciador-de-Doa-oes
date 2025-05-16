namespace Alimentos.cs;
public class Alimento
{
    [Key]
    public int id { get; set; }

    [ForeignKey]
    [MaxLenght(20)]
    public string Ong_Cnpj { get; set; }

    [MaxLenght(255)]
    public string Nome { get; set; }

    public DateTime DataValidade { get; set; }

    public int Quantidade { get; set; }
}