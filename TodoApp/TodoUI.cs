using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoUI
    {
        private readonly TodoService _service = new();
        public void ShowTodos()
        {
            var todos = _service.GetAll();
            Console.WriteLine("==============DANH SÁCH CÔNG VIỆC===============");
            foreach (var todo in todos)
            {
                Console.WriteLine(todo.ToString());
            }
            if (todos.Count <= 0)
            {
                Console.WriteLine("Chưa có công việc !");
            }
        }
        public void ShowMenu()
        {
            Console.WriteLine("\n Chức năng : ");
            Console.WriteLine("1. Thêm công việc");
            Console.WriteLine("2. Đánh dấu công việc đã hoàn thành");
            Console.WriteLine("3. Sửa công việc");
            Console.WriteLine("4. Xóa công việc");
            Console.WriteLine("0. Thoát");
        }
        private void AddTodo()
        {
            Console.Write("Nhập nội dung công việc: ");
            var input = Console.ReadLine();
            _service.AddTodo(input);
        }
        private void DeleteTodo()
        {
            Console.Write("Nhập Id công việc muốn xóa : ");
            int id = int.Parse(Console.ReadLine());
            _service.DeleteTodo(id);
        }
        private void ToggleTodo()
        {
            Console.Write("Nhập Id công việc đánh dấu: ");
            int id = int.Parse(Console.ReadLine());
            _service.ToggleTodo(id);
        }
        private void UpdateTodo()
        {
            Console.Write("Nhập Id công việc đánh dấu: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nhập nội dung mới : ");
            string content = Console.ReadLine();
            _service.UpdateTodo(id, content);
        }
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                ShowTodos();
                ShowMenu();
                Console.Write("Chọn: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddTodo();
                        break;
                    case "2":
                        ToggleTodo();
                        break;
                    case "3":
                        UpdateTodo();
                        break;
                    case "4":
                        DeleteTodo();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
                Console.WriteLine("Nhấn Enter để tiếp tục.....");
                Console.ReadLine();
            }
        }
    }
}
