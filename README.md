# Backmap — памятка C# backend программиста

## Оглавление

### Начальные знания  

• C# 1  
    • LINQ  
    • События  
    • Обобщения  
    • Интерфейсы  
    • Делегаты  
    • Исключения  
    • Garbage collector  
    • Nullable  
    • Атрибуты  
• Структуры данных  
    • Массив  
    • О-о-о! Большое!  
    • Динамический массив  
    • Односвязный список  
    • Двусвязный список  
    • Хэш-таблица  
        • Решение проблем вычисления хеша  
    • Бинарное дерево  
    • Б-дерево  
    • Красно-черное дерево  
    • АВЛ-дерево  
    • Префиксное дерево  
• Алгоритмы 1  
    • [FizzBuzz](#fizzbuzz)  
    • Сортировка  
        • Пузырьковая (Bubble)  
        • Быстрая (Quick)  
        • Слиянием (Merge)  
        • Пирамидальная (Heap)  
        • Вставками (Insertion)  
        • Timsort  
        • Introsort  
        • Поразрядная (Radix)  
    • Поиск  
        • Линейный поиск  
        • Бинарный поиск  
        • Поиск в глубину (DFS)  
        • Поиск в ширину (BFS)  
        • Алгоритм Дейкстры  
        • Алгоритм Беллмана-Форда  
    • Представление графов  
        • Матрица смежности  
        • Матрица инцидентности  
        • Список смежности  
        • Список инцидентности  
    • Конечные автоматы  
    • ДПФ/БПФ  
• SQL 1  
    • Зачем нужен SQL?  
    • Create  
    • Update  
    • Delete  
    • Select  
    • Where  
    • Insert  
    • Drop  
    • Show  
    • Join  
• MS SQL 1  
• Entity Framework 1  
    • Code First  
    • Миграция  
    • Change tracker API  
• Профилирование 1  
    • BenchmarkDotNet  
        • Сравнение двух вариантов FizzBuzz  
        • Сравнение восьми вариантов сортировок  
• C# 2  
    • Асинхронное программирование (docs.microsoft.com/ru-ru/dotnet/standard/async)  
        • await/async  
        • Асинхронные потоки и каналы (System.IO.Pipelines, System.Threading.Channels)  
        • Синхронизация потоков  
    • Параллельное программирование (docs.microsoft.com/ru-ru/dotnet/standard/parallel-programming/)  
        • Структуры данных для параллельного программирования  
    • 2/4 ядра/потока  
    • FizzBuzz на стероидах  
    • IQueryable  
    • Кеширование  
    • AutoMapper  
    • HangFire  
• Архитектурные паттерны 1  
    • Какой код лучше?  
    • Выделение интерфейсов  
    • IoC/DI  
        • Microsoft.Extensions.DependencyInjection  
        • Autofac  
    • SOLID  
        • SRP  
        • OCP  
        • LSP  
        • ISP  
        • DIP  
• Паттерны проектирования 1  
    • Singleton  
    • CQRS  
    • Strategy  
    • Observer  
• Логгирование 1  
    • Serilog  
        • Вывод логов в консоль  
        • Запись логов в файл  
        • Анализ логов  
• NUnit 1  
    • Простые тесты  
    • Моки  
    • Стабы  
    • Moq  
• Git flow 2  
    • Минимальный вариант  
    • Ветвление  
    • Слияние  
    • Чистка веток  

### Сеть  

• HTTP/HTTPS  
• HTML 1 (DOM)  
• CSS 1  
• TypeScript 1  
• React 1  
• Отладка в браузере 1  
• API  
    • REST  
    • gRPC  
• ASP.NET Core Web API 1  
    • Конфигурирование  
    • Аутентификация  
• ASP.NET Core MVC 1  
    • Фильтры  
    • Атрибуты  
    • Middleware  
• Razor 1  
    • Razor Pages  
    • Razor Components  
• FluentValidation  
• Polly  
• Selenium  

### Облака

• Azure  
    • Azure CosmosDB  
    • Azure Functions  

### Продвинутые опции  

• SQL 2  
    • Хранимые процедуры  
    • Триггеры  
    • Ограничения  
• NoSQL  
    • Key-Value хранилища (Redis)  
    • JSON (MongoDB)  
• Entity Framework 2  
    • кеш второго уровня  
    • Lazy loading  
    • Eager Loading  
    • Explicit Loading  
    • TPT  
    • TPH  
• Архитектурные паттерны 2  
    • DI Life Cycles  
        • Scoped  
        • Transient  
        • Singleton  
• Паттерны проектирования 2  
    • Builder  
    • Decorator  
    • Facade  
    • Factory  
    • Mediator/MediatR  
• ASP.NET Core Web API 2  
    • Swagger  
• ASP.NET Core MVC 2  
• Razor 2  
• Blazor 1  
• Профилирование 2  
    • dotTrace  
    • dotTrace + SQL  
    • dotTrace + HTTP  
    • Анализ IL-кода  
    • Sharplab  
• Логгирование 2  
    • ELK Stack  
• Алгоритмы 2  
    • Операции со строками  
        • алгоритм Ахо-Корасик  
    • P vs NP  
    • Операции с графами  
    • Вычислительная геометрия  
    • Алгоритм Джея Кадана (Jay Kadane)  
    • Фильтр Калмана  
    • Жадные алгоритмы  
    • Динамическое программирование  
    • Сжатие данных  
    • Криптография  
    • Синтез и оценка алгоритмов  
    • LeetCode  
• NUnit 2  
    • FluentAssertions  
    • GenFu  
    • TDD? DDD?

### Системный подход  

• Системный дизайн 1  
• Микросервисная архитектура  
    • RabbitMQ  
    • MassTramsit  
    • Ocelot  
    • Docker  
    • Kubernetes  
• CD/CI  
    • GitHub Actions (docs.microsoft.com/ru-ru/dotnet/devops/github-actions-overview)  
• Системный дизайн 2  

### Pet-проекты  

• Игра 2048  
• Syncro, программа резервного копирования  
• Mikeslist, API сайта объявлений  
• Tuppum, прототип блог-платформы  
• Tradercad, сервис технического анализа

### Soft skills  

• Английский язык A2 (грамматика, чтение, письмо, слушание, говорение A2)  
• Amazon: Leadership Principles (amazon.jobs/en/principles)  
• Facebook: Core Values (facebook.com/careers/facebook-life/)  
• Google: Ten Things We Know to Be True (about.google/philosophy/)  
• Методика STAR  
• Английский язык B1 (грамматика, чтение, письмо, слушание, говорение B1)  
• IELTS  
• TOEFL  

### Что почитать  

• C#  
• Алгоритмы и структуры данных  
• Паттерны проектирования  
• Архитектурные паттерны  
• Сеть  
• SQL  
• Тестирование  
• Английский язык  

## Содержание

### FizzBuzz  

Почему нужно просить выполнить столь простое задание — «[FizzBuzz, или почему программисты не умеют программировать](https://habr.com/ru/post/298134/)».  

Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», а вместо чисел, кратных пяти — слово «Buzz». Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».  

Самый простой вариант:  
```cs
const int Max = 100;

for (var i = 1; i <= Max; i++)
{
   if ((i % 3 == 0) && (i % 5 == 0))
   {
      Console.WriteLine("FizzBuzz");
   }
   else if (i % 3 == 0)
   {
      Console.WriteLine("Fizz");
   }
   else if (i % 5 == 0)
   {
      Console.WriteLine("Buzz");
   }
   else
   {
      Console.WriteLine(i);
   }
}
```

или чуточку улучшенный вариант:  
```cs
const int Max = 100;

for (var i = 1; i <= Max; i++)
{
   if (i % 3 == 0)
   {
      if (i % 5 == 0)
      {
         Console.WriteLine("FizzBuzz");
      }
      else
      {
         Console.WriteLine("Fizz");
      }
   }
   else if (i % 5 == 0)
   {
      Console.WriteLine("Buzz");
   }
   else
   {
      Console.WriteLine(i);
   }
}
```

Больше подробностей про оптимизацию задачи FizzBuzz — «[FizzBuzz по-сениорски](https://habr.com/ru/post/540136/)».  

[ECMA-334](https://www.ecma-international.org/wp-content/uploads/ECMA-334_5th_edition_december_2017.pdf)  

Документация на сайте Microsoft и опция «Загрузить pdf»  
