using ApiTwo.Contexts;
using ApiTwo.Models;

namespace ApiTwo
{
    public interface ILinkRepository
    {
        object getRadio(LinkDbContext context);
        object getByIdRadio(LinkDbContext context, string id);
        void getFiles(LinkDbContext context, Ftp ftp);
        void PostFiles(LinkDbContext context, Input radio);
    }
}
