using System.ComponentModel.DataAnnotations;

namespace RoomAPI
{
    public class Room
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(20)]
        public string Comments { get; set; } = string.Empty;
        public int RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }




    }
}
