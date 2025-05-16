using System.ComponentModel.DataAnnotations;
namespace Vestes.cs;
public class Vestes
{
    [Key]
    public int Id { get; set; }

    [MaxLength(20)]
    [ForeignKey]
    public string Ong_cnpj { get; set; }

    [MaxLength(255)]
    public string Descricao { get; set; }

    [MaxLength(255)]
    public string Tamanho { get; set; }

    public int Quantidade { get; set; }

}
