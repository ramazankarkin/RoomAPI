using System.ComponentModel.DataAnnotations;

namespace RoomAPI
{
    public class RoomType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string RoomName { get; set; } = string.Empty;
    }
}
