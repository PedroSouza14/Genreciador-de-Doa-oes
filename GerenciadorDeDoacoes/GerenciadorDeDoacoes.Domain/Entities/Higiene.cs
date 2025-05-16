using System.ComponentModel.DataAnnotations;
namespace Higiene.cs;

public class Higiene
{
	[Key]
	public int Id { get; set; }

	[ForeignKey]
	[MaxLenght(255)]
	public string Ong_Cnpj { get; set; }

	public int Quantidade { get; set; }


}