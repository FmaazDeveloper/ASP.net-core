namespace GameZone.ViewModels
{
    public class GameFormViewModel
    {
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        [Display(Name = "Supported Devices")]
        public List<int> SelectedDevicies { get; set; } = default!;
        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}
