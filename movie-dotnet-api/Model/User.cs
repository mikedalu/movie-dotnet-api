using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_dotnet_api.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}
