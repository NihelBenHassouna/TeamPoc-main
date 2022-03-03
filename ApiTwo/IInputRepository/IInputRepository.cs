using ApiTwo.Contexts;
using ApiTwo.Models;

namespace ApiTwo
{
    public interface IInputRepository
    {
       
        object getAllInput(InputDbContext context);
        object GetByInputByNeId(InputDbContext context, string id);
        void getFilesFromFtp(InputDbContext context, Ftp ftp);
        void PostInput(InputDbContext context, Link inputpower);
 
    }
}
