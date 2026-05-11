using System.Collections.Generic;
using System.Linq;

namespace TodoApp
{
    public class TodoRepository
    {
        private readonly AppDbContext _context = new();

        public Todo CreateTodo(string title)
        {
            var todo = new Todo
            {
                Title = title,
                IsSuccess = false
            };

            _context.Todos.Add(todo);
            _context.SaveChanges(); 

            return todo;
        }

        public bool UpdateTodo(int id, string title)
        {
            var item = _context.Todos.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                item.Title = title;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteTodo(int id)
        {
            var item = _context.Todos.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                _context.Todos.Remove(item);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Todo> GetTodos()
        {
            // Lấy danh sách từ Database
            return _context.Todos.ToList();
        }

        public bool ToggleTodo(int id)
        {
            var item = _context.Todos.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                item.IsSuccess = !item.IsSuccess;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}