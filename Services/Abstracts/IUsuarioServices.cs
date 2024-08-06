using Microsoft.AspNetCore.Mvc;
using PetHealth.Dtos;

namespace PetHealth.Services.Abstracts
{
    public interface IUsuarioServices
    {
        Task<ActionResult> RegistrarUsuario(UsuarioDTO usuarioDto);
        Task<ActionResult> ConsultarUsuario(long idUsuario);

    }
}
