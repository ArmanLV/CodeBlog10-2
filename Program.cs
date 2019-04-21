using System;

namespace CodeBlog11
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Задаю значения скилла для экземпляров
            int Skill1 = new Random().Next(0, 100);
            int Skill2 = new Random().Next(0, 100);

            // Задаю время зависимо от умений
            int Time1 = SwimTime(Skill1);
            int Time2 = SwimTime(Skill2);

            // Объявляю экземпляры класса
            Swimmer SwimmerOne = new Swimmer("Джугашвили", "кроль", Time1, 0, Skill1);
            Swimmer SwimmerTwo = new Swimmer("Шикльгрубер", "кроль", Time2, 0, Skill2);

            // Задаю значения разницы во времени (у победившего значение с +, а у проигравшего с -)
            if (Time1 < Time2)
            {
                SwimmerOne.TimeDifference = Time2 - Time1;
                SwimmerTwo.TimeDifference = -SwimmerOne.TimeDifference;
            }
            else
            {
                SwimmerTwo.TimeDifference = Time1 - Time2;
                SwimmerOne.TimeDifference = -SwimmerTwo.TimeDifference;
            }            

            // Вывожу значения
            Console.WriteLine($"{SwimmerOne.Time} {SwimmerOne.TimeDifference} {SwimmerOne.Skill}");
            Console.WriteLine($"{SwimmerTwo.Time} {SwimmerTwo.TimeDifference} {SwimmerTwo.Skill}");
            Console.ReadLine();
        }

        // Статический метод, который считает время зависимо от умений (Чем больше умения - меньше время) 
        static int SwimTime(int skill)
        {
            if (skill < 20)
            {
                return new Random().Next(80, 100);
            }
            else if (skill > 20 && skill < 50)
            {
                return new Random().Next(45, 80);
            }
            else if (skill > 50 && skill < 80)
            {
                return new Random().Next(35, 50);
            }
            else
            {
                return new Random().Next(35, 50);
            }
        }
    }
}
