using System;

namespace HRLibrary
{
    public enum StudentDirectionOfPreparation
    {
        Specialist,
        Bachelor,
        Magistracy
    }

    public class Student
    {

        
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string NumberGradebook { get; private set; }
        public string Group { get; set; }
        public string Institute { get; set; }
        public StudentDirectionOfPreparation DirectionOfPreparation { get; set; }

         
        public Student(string name, string surname, string numberGradebook)
        {
            Name = name;
            Surname = surname;
            NumberGradebook = numberGradebook;
        }

       
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

       
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var directionOfPreparation = " ";

            switch (DirectionOfPreparation)
            {
                case StudentDirectionOfPreparation.Bachelor:
                    directionOfPreparation = "Бакалавриат";
                    break;
                case StudentDirectionOfPreparation.Specialist:
                    directionOfPreparation = "Специалитет";
                    break;
                case StudentDirectionOfPreparation.Magistracy:
                    directionOfPreparation = "Магистратура";
                    break;
            }
            
            Console.WriteLine($"Институт {Institute}, Направление подготовки: {directionOfPreparation}," +
                $" Номер группы: {Group}, Номер зачетной книжки: {NumberGradebook}.");
        }
    }
}
