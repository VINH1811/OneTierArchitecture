using System.ComponentModel.DataAnnotations;

namespace TodoApp
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsSuccess { get; set; }

        public override string ToString()
        {
            return $"[{(IsSuccess ? "x" : " ")}] {Id}: {Title}";
        }
    }
}