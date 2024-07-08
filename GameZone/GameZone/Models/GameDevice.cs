namespace GameZone.Models
{
    public class GameDevice
    {
        public int GameId { get; set; }
        public int Game { get; set; } = default!;
        public int DeviceId { get; set; }
        public int Device { get; set; } = default!;
    }
}
