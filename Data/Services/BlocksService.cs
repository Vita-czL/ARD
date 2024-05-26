
namespace ARD.Data.Services
{
    public class BlocksService : IBlocksService
    {
        private readonly AppDbContext _context;

        public BlocksService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(WatchedPosition watchedPosition)
        {
            watchedPosition.WatchedPositionCreationDate = DateTime.Now;
            _context.WatchedPositions.Add(watchedPosition);
            _context.SaveChanges();
        }

        public void Delete(int WatchedPositionId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<WatchedPosition>> GetAll()
        {
            var result = await _context.WatchedPositions.ToListAsync();
            return result;
        }

        public WatchedPosition GetById(int id)
        {
            throw new NotImplementedException();
        }

        public WatchedPosition Update(int id, WatchedPosition newWatchedPositionId)
        {
            throw new NotImplementedException();
        }
    }
}