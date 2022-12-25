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
    [StringLength(80, MinimumLength =2, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "A Descrição Curta é obrigatória")]
    [Display(Name = "Descrição do lanche")]
    [MinLength(2, ErrorMessage = "A descrição deve ter no mínimo {1}")]
    [MaxLength(100, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
    public string DescricaoCurta { get; set; }

    [Required(ErrorMessage = "O descrição detalhada do lanche deve ser informada")]
    [Display(Name = "Descrição detalhada do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
    public string DescricaoDetalhada { get; set; }

    [Required(ErrorMessage = "O preço deve ser informado! :>")]
    [Display(Name ="Preço")]
    [Column(TypeName ="decimal(10,2)")]
    [Range(1, 999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
    public decimal Preco { get; set; }

    [Display(Name ="Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage ="o {0} deve ter no máximo {1} caracteres")]
    public string ImagemUrl { get; set; }

    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage = "o {0} deve ter no máximo {1} caracteres")]
    public string ImagemThumbnailUrl { get; set; }

    [Display(Name ="Preferido?")]
    public bool IsLanchePreferido { get; set; }
    
    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }
    //Propriedade de Navegação
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}

