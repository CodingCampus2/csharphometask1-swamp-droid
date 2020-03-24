using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                float population = Single.Parse(task.City.Population);
                float sickPercentage = Single.Parse(task.City.SickPercentage);
                float killProbability = Single.Parse(task.Virus.KillProbability);

                float sickValue = population * sickPercentage;
                float deadValue = sickValue * killProbability;

                string answer = "There are " + Math.Truncate(sickValue) + " people sick with " +
                    task.Virus.Name + " in the city of " + task.City.Name + 
                    ", " + Math.Truncate(deadValue) + " of which died";

                return answer;
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
