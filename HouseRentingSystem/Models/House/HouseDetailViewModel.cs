namespace HouseRentingSystem.App.Models.House
{
    public class HouseDetailViewModel : HousesViewModel
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CreatedBy { get; set; }
    }
}
