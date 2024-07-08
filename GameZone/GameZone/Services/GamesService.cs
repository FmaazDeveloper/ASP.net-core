namespace GameZone.Services
{
    public class GamesService : IGamesService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _imgaesPath;
        public GamesService(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _imgaesPath = $"{_webHostEnvironment.WebRootPath}{FileSettings.ImagePath}";
        }
        public async Task Create(CreateGameFormViewModel model)
        {
            var coverName = $"{Guid.NewGuid()}{Path.GetExtension(model.Cover.FileName)}";
            var path = Path.Combine(_imgaesPath, coverName);
            using var stream = File.Create(path);
            await model.Cover.CopyToAsync(stream);

            Game game = new()
            {
                Name = model.Name,
                Description = model.Description,
                CategoryId = model.CategoryId,
                Cover = coverName,
                Devices = model.SelectedDevicies.Select(d => new GameDevice { DeviceId = d}).ToList()
            };

            _context.Add(game);
            _context.SaveChanges();
        }
    }
}
