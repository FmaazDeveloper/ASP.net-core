namespace GameZone.Services
{
    public class DevicesService : IDevicesService
    {
        private readonly AppDbContext _context;
        public DevicesService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _context.Devices.Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).OrderBy(d => d.Text).AsNoTracking().ToList();
        }
    }
}
