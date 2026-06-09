using System.ComponentModel.DataAnnotations;

namespace CadastroAlunosApp.Models
{
    public class ImcModel
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O peso é obrigatório.")]
        [Range(10, 300, ErrorMessage = "Por favor, insira um peso válido entre 10kg e 300kg.")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "A altura é obrigatória.")]
        [Range(0.5, 2.5, ErrorMessage = "Por favor, insira uma altura válida entre 0.5m e 2.5m.")]
        public double Altura { get; set; }

        public double? ResultadoImc { get; set; }
        public string Classificacao { get; set; }
    }
}