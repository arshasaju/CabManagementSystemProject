using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CabManagementSystem.Models
{
    public enum VehicleType
    {
        AutoRikshaw,
        Car
    }
    public class Cab
    {
        public int Id { get; set; }
        public string VehicleNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public string VehicleModel { get; set; }

    }
}
