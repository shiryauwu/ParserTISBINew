using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTISBINew
{
    internal class Menu
    {
        

        public void StartMenu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Расписание на сегодня.");
            Console.WriteLine("2. Информация для абитуриентов");

            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.Clear();
                    try
                    {
                        ScheduleParseMenu();
                    }
                    catch (Exception ex)
                    {
                        ScheduleParseMenu();
                    }
                    break;
                case "2":
                    Console.Clear();
                    
                    AbiturMenu();
                    break;
            }
        }
        public void ScheduleParseMenu()
        {
            
            Console.Clear();
            
            var isuVuzParser = new ISUVUZParser("https://isu.tisbi.ru/student/login");
            Console.WriteLine("Введите логин и пароль от аккаунта ИСУ ВУЗ:");
            isuVuzParser.LoginAndPassword();
            Console.WriteLine(isuVuzParser.ScheduleParser());
        }
        public void AbiturMenu()
        {
            var tisbiRuParser = new TisbiRuParser("https://www.tisbi.ru/postupit/");
            Console.Clear();

            Console.WriteLine("1. Информация о подаче документов.");
            Console.WriteLine("2. Перечень документов для поступления.");
            Console.WriteLine("3. Основные даты для поступления на бюджет.");
            Console.WriteLine("4. Основные даты для поступления на коммерцию.");
            Console.WriteLine("5. Схема поступления");
            Console.WriteLine("6. Вступительные испытания");
            Console.WriteLine("7. Как проходит зачисление");
            Console.WriteLine("8. Расписание онлайн-консультаций с приемной комиссией");
            Console.WriteLine("9. Расписание онлайн-консультаций с деканами факультетов");
            Console.WriteLine("0.Расписание онлайн Дней открытых дверей");
            Console.WriteLine("10. Назад в главное меню.");

            string choose = Console.ReadLine();
            
            switch (choose)
            {
                case "1":
                    Console.WriteLine(tisbiRuParser.ButtonOne());
                    break;
                case "2":
                    Console.WriteLine(tisbiRuParser.ButtonTwo());
                    break;
                case "3":
                    Console.WriteLine(tisbiRuParser.ButtonThree());
                    break;
                case "4":
                    Console.WriteLine(tisbiRuParser.ButtonFour());
                    break;
                case "5":
                    Console.WriteLine(tisbiRuParser.ButtonFive());
                    break;
                case "6":
                    Console.WriteLine(tisbiRuParser.ButtonSix());
                    break;
                case "7":
                    Console.WriteLine(tisbiRuParser.ButtonSeven());
                    break;
                case "8":
                    Console.WriteLine(tisbiRuParser.ButtonEight());
                    break;
                case "9":
                    Console.WriteLine(tisbiRuParser.ButtonNine());
                    break;
                case "0":
                    Console.WriteLine(tisbiRuParser.ButtonTen());
                    break;
                case "10":
                    StartMenu();
                    break;
            }
        }

    }
}
