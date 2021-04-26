using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todo = new List<Todo>()
            {
                new Todo(){Discription = "Task1" , EstimatedHours = 6 , Status = status.Completed },
                new Todo(){Discription = "Task2" , EstimatedHours = 2 , Status = status.Inprogress },
                new Todo(){Discription = "Task3" , EstimatedHours = 8 , Status = status.NotStarted },
                new Todo(){Discription = "Task4" , EstimatedHours = 12 , Status = status.Deleted },
                new Todo(){Discription = "Task5" , EstimatedHours = 6 , Status = status.Inprogress },
                new Todo(){Discription = "Task6" , EstimatedHours = 2 , Status = status.NotStarted },
                new Todo(){Discription = "Task7" , EstimatedHours = 6 , Status = status.Completed },
                new Todo(){Discription = "Task8" , EstimatedHours = 8 , Status = status.Completed },
                new Todo(){Discription = "Task9" , EstimatedHours = 8 , Status = status.Inprogress },
                new Todo(){Discription = "Task10" , EstimatedHours = 8 , Status = status.Completed },
                new Todo(){Discription = "Task11" , EstimatedHours = 4 , Status = status.NotStarted },
                new Todo(){Discription = "Task12" , EstimatedHours = 10 , Status = status.Completed },
                new Todo(){Discription = "Task13" , EstimatedHours = 12 , Status = status.Deleted },
                new Todo(){Discription = "Task14" , EstimatedHours = 6 , Status = status.OnHold },
            };
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            PrintAssessment(todo);
            Console.ReadLine();
        }
        private static void PrintAssessment(List<Todo> todo)
        {
            foreach (var todos in todo)

            {
                switch (todos.Status)
                {
                    case status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case status.Inprogress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case status.OnHold:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todos.Discription);
            }
        }
    }
    class Todo
    {
        public string  Discription { get; set; }
        public int EstimatedHours { get; set; }
        public status Status { get; set; }

    }
    enum status
    {
        NotStarted,
        Inprogress,
        OnHold,
        Completed,
        Deleted
    }
}
