using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRLibrary;
using System.IO;

namespace HRUnitTests
{
    [TestClass]
    public class StudentUnitTest
    { 
       
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var student = CreateTestStudent();

            Assert.AreEqual("Иван", student.Name);
            Assert.AreEqual("Иванов", student.Surname);
            Assert.AreEqual("72183149", student.NumberGradebook);
        }

        [TestMethod]
        public void ToStringTestMethod()
        {
            var student = CreateTestStudent();
            Assert.AreEqual("Иван Иванов", student.ToString());
        }

        [TestMethod]
        public void PrintInfoTestMethod()
        {
           
            var firstStudent = CreateTestStudent();
            var secondStudent = new Student("Анастасия", "Петрова", "8234191")
            {DirectionOfPreparation = StudentDirectionOfPreparation.Magistracy, Institute = "Естественных наук",
                Group = "МТ-196004"};

            var consoleOut = new[]
            {
                "Иван Иванов",
                $"Институт Математических наук, Направление подготовки: Бакалавриат," +
                $" Номер группы: МТ-190021, Номер зачетной книжки: 72183149.",
                "Анастасия Петрова",
                $"Институт Естественных наук, Направление подготовки: Магистратура," +
                $" Номер группы: МТ-196004, Номер зачетной книжки: 8234191.",
            };

            TextWriter oldOut = Console.Out;


            using (FileStream file = new FileStream("test.txt", FileMode.Create))
            {
                using (TextWriter writer = new StreamWriter(file))
                {
                    Console.SetOut(writer);
                    firstStudent.PrintInfo();
                    secondStudent.PrintInfo();
                }
            }
            Console.SetOut(oldOut);

            var i = 0;
            foreach (var line in File.ReadLines("test.txt"))
                Assert.AreEqual(consoleOut[i++], line);

            File.Delete("test.txt");
        }


        private Student CreateTestStudent()
        {
            return new Student("Иван", "Иванов", "72183149") { DirectionOfPreparation = 
                StudentDirectionOfPreparation.Bachelor, Institute = "Математических наук",
                Group = "МТ-190021"};
        }
    }
}
