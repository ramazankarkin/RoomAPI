using System.ComponentModel.DataAnnotations;

namespace RoomAPI
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(20)] public string MyProperty { get; set; } = string.Empty;   




    }
}
