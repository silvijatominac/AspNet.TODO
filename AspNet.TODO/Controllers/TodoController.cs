using Microsoft.AspNetCore.Mvc;
using AspNet.TODO.Models;
using AspNet.TODO.Repository;

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepository _todoList;

        public TodoController()
        {
            _todoList = new TodoRepository();
        }

        public ActionResult Index()
        {
            var todoList = _todoList;
            return View(todoList);
        }
    }
}
