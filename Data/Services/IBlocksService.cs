using ARD.Controllers;
using ARD.Models;

namespace ARD.Data.Services
{
    public interface IBlocksService
    {
       Task<IEnumerable<WatchedPosition>> GetAll();
       WatchedPosition GetById(int id);
       void Add(WatchedPosition watchedPosition);

       WatchedPosition Update(int id,WatchedPosition newWatchedPosition);
       void Delete(int id);
    }
}