using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;
[Table("Laches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }
    [Required(ErrorMessage ="O nome do lanche é obrigatório")]//o error mensage é para evitar da msg saia no idioma ingles
    [Display(Name ="Nome do lanche")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "A Descrição Curta é obrigatória")]
    [Display(Name = "Nome do lanche")]
    [MinLength(2, ErrorMessage = "Não pode ser menor que 2 caracteres")]
    [MaxLength(100, ErrorMessage = "Não pode ser maior que 100 caracteres")]
    public string DescricaoCurta { get; set; }
    public string DescricaoDetalhada { get; set; }
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public bool IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }
    //Propriedade de Navegação
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}

