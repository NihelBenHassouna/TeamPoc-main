using ApiThree.Contexts;
using ApiThree.Models;

namespace ApiThree
{
    public interface IRadioRepository
    {
        object getRadio(RadioDbContext context);
        object getByIdRadio(RadioDbContext context, string id);
        void getFiles(RadioDbContext context, Ftp ftp);
        void PostFiles(RadioDbContext context, Input radio);
    }
}
