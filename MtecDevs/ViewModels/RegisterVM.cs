using System.ComponentModel.DataAnnotations;

namespace MtecDevs.ViewModels;

public class RegisterVM
{
    [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }

    public string Nome { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "Informe sua Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;
    public string UrlRetorno { get; set; }
    public DateTime DataNascimento { get; set; }
    public byte TipoDevId { get; set; }
    public string Foto { get; set; }
}
