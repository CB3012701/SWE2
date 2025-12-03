using Models;

namespace WEB_SITE.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> GetUsuarioByNome(string nome); 
    }
}
