using System.ComponentModel;

namespace AspNet.TODO.Models
{
    public class Todo
    {
        [DisplayName("Broj zadatka")]
        public int Id { get; set; }

        [DisplayName("Opis zadatka")]
        public string Description { get; set; }

        [DisplayName("Rok za odradu zadatka")]
        public DateTime DueDate {  get; set; }
    }
}
