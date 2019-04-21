using System;

namespace CodeBlog11
{
    public class Swimmer
    {
        // Объявляю общие параметры у пловцов
        public string Name { get; private set; }
        public string SwimmingWay { get; private set; }
        public int Time { get; private set; }
        public int TimeDifference { get; set; }
        public int Skill { get; private set; }

        // Базовый конструктор класса, который проверяет входные данные
        public Swimmer(string name, string swimmingWay, int time, int timeDifference, int skill)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(swimmingWay))
            {
                throw new ArgumentNullException("Данное поле не может быть пустым");
            }
            if (time <= 0 )
            {
                throw new ArgumentException("Данный параметр не может быть равен или меньше нуля");
            }
            if (timeDifference < 0)
            {
                throw new ArgumentException("Данный параметр не может быть меньше нуля");
            }
            if (skill < 0 || skill > 100)
            {
                throw new ArgumentException("Данный параметр может принимать только значения от 0 до 100 включительно");
            }

            // Если входные данные проходят все проверки, то присваиваю значения экземпляра
            Name = name;
            SwimmingWay = swimmingWay;
            Time = time;
            TimeDifference = timeDifference;
            Skill = skill;
        }
    }
}
