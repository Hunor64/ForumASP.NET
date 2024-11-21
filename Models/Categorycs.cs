using System.ComponentModel;

namespace ForumASP.NET.Models
{
    public class Categorycs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
    }
}
