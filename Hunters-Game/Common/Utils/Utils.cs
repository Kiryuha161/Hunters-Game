using Microsoft.IdentityModel.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System;
using System.ComponentModel;

namespace Hunters_Game.Common.Utils
{
    public class Utils
    {
        public static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max);
        }

        public static float GetFloatRandomNumber(double min, double max)
        {
            Random random = new Random();

            double randomFloat = random.NextDouble() * (max - min) + min;
            double roundedFloat = Math.Round(randomFloat, 2);

            return (float)roundedFloat;
        }

        public static string GetName(string lang, string gender)
        {
            List<string> namesList;
            string name;

            if (lang == "rus")
            {
                if (gender == "male")
                {
                    namesList = new List<string>
                    {
                        "Александр", "Алексей", "Андрей", "Антон", "Борис", "Владимир", "Валентин",
                         "Геннадий", "Григорий", "Георгий", "Иван", "Константин"
                    };

                    name = namesList[Utils.GetRandomNumber(0, namesList.Count)];
                    return name;
                }
                else
                {
                    namesList = new List<string>
                    {
                        "Александра", "Аксинья", "Валентина", "Вероника", "Галина", "Евгения", "Екатерина", "Елизавета", "Ирина", "Инна",
                        "Инга", "Кристина"
                    };

                    name = namesList[Utils.GetRandomNumber(0, namesList.Count)];
                    return name;
                }
            }

            if (lang == "foreign")
            {
                if (gender == "male")
                {
                    namesList = new List<string>
                    {
                        "Алекс", "Боб", "Грегори", "Денис", "Джон", "Дерек", "Кевин", "Леонард", "Майкл", "Николас", "Томас", "Кевин"
                    };

                    name = namesList[Utils.GetRandomNumber(0, namesList.Count)];
                    return name;
                }
                else
                {
                    namesList = new List<string>
                    {
                        "Алекса", "Алиса", "Бритни", "Джесси", "Кейли", "Кристи", "Моника", "Натали", "Ронда", "Рейчел", "Эрика", "Фиби"
                    };

                    name = namesList[Utils.GetRandomNumber(0, namesList.Count)];
                    return name;
                }
            }

            return null;
        }

        public static string GetSurname(string lang, string gender)
        {
            List<string> surnameList;
            string surname;

            if (lang == "rus")
            {
                if (gender == "male")
                {
                    surnameList = new List<string>
                    {
                        "Александров", "Алексеев", "Андреев", "Антонов", "Борисов", "Баранов", "Валентинов", "Григорьев", "Иванов",
                        "Петров", "Иванов", "Константинов"
                    };

                    surname = surnameList[Utils.GetRandomNumber(0, surnameList.Count)];
                    return surname;
                }
                else
                {
                    surnameList = new List<string>
                    {
                        "Александрова", "Алексеева", "Андреева", "Антонова", "Борисова", "Валентонова", "Григорьева", "Иванова", "Петрова", 
                        "Константинова", "Баранова", "Иринина", "Кристинина"
                    };

                    surname = surnameList[Utils.GetRandomNumber(0, surnameList.Count)];
                    return surname;
                }
            }

            if (lang == "foreign")
            {
                surnameList = new List<string>
                    {
                        "Андерс", "Болдуин", "Джонсон", "Костнер", "Кокс", "Спирс", "Смитт", "Шелби", "Хоган", "Пэрри", "Фокс", "Энистон"
                    };

                surname = surnameList[Utils.GetRandomNumber(0, surnameList.Count)];
                return surname;
            }

            return null;
        }

        public static DateTime GetRandomDate(int startYear, int endYear)
        {
           Random random = new Random();
            
            int year = random.Next(startYear, endYear + 1);
            int month = random.Next(1, 13);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int day = random.Next(1, daysInMonth + 1); 

            return new DateTime(year, month, day);
        }

        public static int СalculateDateDifference(DateTime targetDate, DateTime dateNow)
        {
            int age = dateNow.Year - targetDate.Year;
            if (dateNow < targetDate.AddYears(age))
            {
                age--;
            }

            return age;
        }

        public static DateTime GetCurrentDate()
        {
            DateTime currentDate = new DateTime(2025, 1, 1);

            return currentDate;
        }

        public static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
