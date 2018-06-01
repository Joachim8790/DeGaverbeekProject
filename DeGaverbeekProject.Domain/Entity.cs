using System.ComponentModel.DataAnnotations;

namespace DeGaverbeekProject.Domain
{
    public abstract class Entity
    {
        [Key]
        public int ID { get; set; }
    }
}