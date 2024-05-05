using AspNet.TODO.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace AspNet.TODO.Repository
{
    public class TodoRepository
    {
        private static List<Todo> todoList;

        public TodoRepository()
        {
            if (todoList == null)
            {
                todoList = new List<Todo>();
                SimulateDatabase();
            }
        }

        private void SimulateDatabase()
        {
            Todo todo1 = new Todo()
            {
                Id = 1,
                Description = "Oprati veš",
                DueDate = new DateTime(2024, 5, 5)
            };
            todoList.Add(todo1);

            Todo todo2 = new Todo()
            {
                Id = 2,
                Description = "Riješiti parcijalni ispit",
                DueDate = new DateTime(2024, 5, 6)
            };
            todoList.Add(todo2);

            Todo todo3 = new Todo()
            {
                Id = 3,
                Description = "Registrirati automobil",
                DueDate = new DateTime(2024, 5, 15)
            };
            todoList.Add(todo3);

            Todo todo4 = new Todo()
            {
                Id = 4,
                Description = "Riješiti završni ispit",
                DueDate = new DateTime(2024, 7, 15)
            };
            todoList.Add(todo4);

            Todo todo5 = new Todo()
            {
                Id = 5,
                Description = "Otići na more",
                DueDate = new DateTime(2024, 8, 17)
            };
            todoList.Add(todo5);
        }
    }
}
