using Microsoft.AspNetCore.Mvc;
using PetHealth.Dtos;

namespace PetHealth.Services.Abstracts
{
    public interface IFornecedoresServices
    {
        Task<ActionResult> Cadastrar(FornecedorDto fornecedorDto);
        Task<ActionResult> ObterPelaId(long idFornecedor);
    }
}
