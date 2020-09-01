namespace Shindows.Models
{
    public class ModelModel
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public ManufacturerModel Manufacturer { get; internal set; }
        public EngineModel Engine { get; set; }
    }
}