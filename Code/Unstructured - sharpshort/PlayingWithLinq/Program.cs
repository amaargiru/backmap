using Linq;
using System;
using System.Linq;

namespace PlayingWithLinq
{
    class Program
    {
        static void Main()
        {
            const int WorkersNum = 100;

            var staffA = GenerateRandomStaff.Get(WorkersNum);
            var staffB = GenerateRandomStaff.Get(WorkersNum);

            // Сумма положительных переработок A
            var SumPositiveOvertimeA = staffA
                .Where(worker => worker.Value > 0)
                .Sum(worker => worker.Value);

            // Средняя переработка A
            var AverageOvertimeA = staffA
                .Average(worker => worker.Value);

            // Средняя переработка A и B // (сначала объединить, потом посчитать)
            var AverageOvertimeAB = staffA
                .Concat(staffB)
                .Average(worker => worker.Value);

            // Разницу в днях переработки между A и B
            var DiffOvertimeAB =
                staffA.Sum(worker => worker.Value)
                - staffB.Sum(worker => worker.Value);

            // Список сотрудников A, переработавших не менее 22 дней
            var OvertimeLimit = 22;
            var OvertimeOverLimit = staffA
                .Where(worker => worker.Value >= OvertimeLimit)
                .ToDictionary(worker => worker.Key, worker => worker.Value);

            // Список сотрудников, работающих в обоих компаниях
            var WorkersAB = staffA
                .Where(worker => staffB.ContainsKey(worker.Key))
                .ToDictionary(worker => worker.Key, worker => worker.Value);

            // Устранение выбросов A
            var OvertimeLimitMin = -5;
            var OvertimeLimitMax = 80;

            bool isMatchesLimits(int x) => (x > OvertimeLimitMin) && (x < OvertimeLimitMax);

            var ApplyOvertimeLimits = staffA
                .Where(worker => isMatchesLimits(worker.Value))
                .ToDictionary(worker => worker.Key, worker => worker.Value);

            // Список тех, чья первая буква от 'a' до 'j'
            var startChar = 'a';
            var endChar = 'j';

            bool isMatchesCharRange(char c) => (c >= startChar) && (c <= endChar);

            var ApplyNameRange = staffA
                .Where(worker => isMatchesCharRange(worker.Key[0]))
                .ToDictionary(worker => worker.Key, worker => worker.Value);

            // Количество тех, чьё имя содержит сочетание "go"
            var searchPhrase = "go";

            var ApplyNameFiler = staffA
                .Where(worker => worker.Key.Contains(searchPhrase))
                .Count();

            // Средняя переработка тех, у кого в имени 2 буквы 'x'
            var searchChar = 'x';
            var searchNumber = 2;

            bool isMatchesCharNumber(string s) => s.Count(ch => ch == searchChar) == searchNumber;

            var ApplyNameFiler2 = staffA
                .Where(worker => isMatchesCharNumber(worker.Key))
                .Average(worker => worker.Value);

            Console.ReadKey();
        }
    }
}
