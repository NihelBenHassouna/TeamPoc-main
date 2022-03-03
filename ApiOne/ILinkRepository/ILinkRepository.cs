using ApiOne.Models;

namespace ApiOne
{
    public interface ILinkRepository
    {
        void generateFileLink (Ftp ftp);
    }
}
