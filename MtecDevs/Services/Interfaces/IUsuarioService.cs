using MtecDevs.ViewModels;

namespace MtecDevs.Services.Interfaces;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();
}