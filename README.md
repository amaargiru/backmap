# Backmap — памятка C# backend программиста

## Оглавление

### Начальные знания  

• C# 1  
    • [LINQ](#basecsharplinq)  
    • [События](#basecsharpevents)  
    • [Обобщения](#basecsharpgenerics)  
    • [Интерфейсы](#basecsharpinterfaces)  
    • [Делегаты](#basecsharpdelegates)  
    • [Исключения](#basecsharpexceptions)  
    • [Garbage collector](#basecsharpgc)  
    • [Nullable](#basecsharpnullable)  
    • [Атрибуты](#basecsharpattributes)  
• Структуры данных  
    • [Массив](#basearray)  
    • [О-о-о! Большое!](#basebigo)  
    • [Динамический массив](#basedarray)  
    • [Односвязный список](#baseslist)  
    • [Двусвязный список](#basedlist)  
    • [Хэш-таблица](#basehashtable)  
        • [Решение проблем вычисления хеша](#basehashtableproblem)  
    • [Бинарное дерево](#basebitree)  
    • [Б-дерево](#basebtree)  
    • [Красно-черное дерево](#baserbtree)  
    • [АВЛ-дерево](#baseavltree)  
    • [Префиксное дерево](#basetrie)  
    • [Выбор структуры данных](#basestructselection)  
• Алгоритмы 1  
    • [FizzBuzz](#simplefizzbuzz)  
    • Сортировка  
        • [Пузырьковая (Bubble)](#basebubblesort)  
        • [Быстрая (Quick)](#basequicksort)  
        • [Слиянием (Merge)](#basemergesort)  
        • [Пирамидальная (Heap)](#baseheapsort)  
        • [Вставками (Insertion)](#baseinsertionsort)  
        • [Timsort](#basetimsort)  
        • [Introsort](#baseintrosort)  
        • [Поразрядная (Radix)](#baseradixsort)  
    • Поиск  
        • [Линейный поиск](#baselinearsearch)  
        • [Бинарный поиск](#basebinarysearch)  
        • [Поиск в глубину (DFS)](#basedfs)  
        • [Поиск в ширину (BFS)](#basebfs)  
        • [Алгоритм Дейкстры](#basedijkstras)  
        • [Алгоритм Беллмана-Форда](#basebellmanford)  
    • Представление графов  
        • [Матрица смежности](#basegraphadjacencymatrix)  
        • [Матрица инцидентности](#basegraphincidencematrix)  
        • [Список смежности](#basegraphadjacencylist)  
        • [Список инцидентности](#basegraphincidencelist)  
    • [Конечные автоматы](#basefinitestatemachine)  
    • [ДПФ/БПФ](#basefastfouriertransform)  
• SQL 1  
    • [Зачем нужен SQL?](#whysql)  
    • [Create](#sqlbasecreate)  
    • [Update](#sqlbaseupdate)  
    • [Delete](#sqlbasedelete)  
    • [Select](#sqlbaseselect)  
    • [Where](#sqlbasewhere)  
    • [Insert](#sqlbaseinsert)  
    • [Drop](#sqlbasedrop)  
    • [Show](#sqlbaseshow)  
    • [Join](#sqlbasejoin)  
• [MS SQL 1](#basemssql)  
• Entity Framework 1  
    • [Code First](#efbasecodefirst)  
    • [Миграция](#efbasemigration)  
    • [Change tracker API](#efbasectapi)  
• Профилирование 1  
    • [BenchmarkDotNet](#profilingbasebenchmarkdotnet)  
        • [Сравнение двух вариантов FizzBuzz](#profilingbasefizzbuzzcompare)  
        • [Сравнение восьми вариантов сортировок](#profilingbasesortingcompare)  
• C# 2  
    • Асинхронное программирование (docs.microsoft.com/ru-ru/dotnet/standard/async)  
        • [await/async](#csharpawaitasync)  
        • [Асинхронные потоки и каналы (System.IO.Pipelines, System.Threading.Channels)](#csharppipelinesandchannels)  
        • [Синхронизация потоков](#csharpsyncchannels)  
    • Параллельное программирование (docs.microsoft.com/ru-ru/dotnet/standard/parallel-programming/)  
        • [Структуры данных для параллельного программирования](#csharpdatastructuresforparallelprogramming)  
    • [2/4 ядра/потока](#csharp24threads)  
    • [Параллельная версия FizzBuzz](#csharpparallelfizzbuzz)  
    • [IQueryable](#csharpiqueryable)  
    • [Кеширование](#csharpcashing)  
    • [AutoMapper](#csharpautomapper)  
    • [HangFire](#csharphangfire)  
• Архитектурные паттерны 1  
    • Какой код лучше?  
    • Выделение интерфейсов  
    • IoC/DI  
        • Microsoft.Extensions.DependencyInjection  
        • Autofac  
    • SOLID  
        • [SRP](#archsolidsrp)  
        • [OCP](#archsolidocp)  
        • [LSP](#archsolidlsp)  
        • [ISP](#archsolidisp)  
        • [DIP](#archsoliddip)  
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
• ASP.NET Core MVC 1  
    • Фильтры  
    • Атрибуты  
    • Middleware  
    • Взаимодействие ASP.NET Core MVC и React  
• API  
    • REST  
    • gRPC  
• ASP.NET Core Web API 1  
    • Конфигурирование  
    • Аутентификация  
    • Проблемы синхронной аутентификации сервер/клиент  
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
        • Elasticsearch  
            • OpenSearch  
        • Logstash  
        • Kibana  
• Алгоритмы 2  
    • Операции со строками  
        • Алгоритм Ахо-Корасик  
        • Алгоритм Рабина-Карпа  
    • P vs NP  
    • Операции с графами  
        • Минимальное остовное дерево  
        • Алгоритм Флойда-Уоршолла  
        • Максимальные потоки  
    • Вычислительная геометрия  
        • Пара ближайших точек  
        • Построение выпуклой оболочки  
    • Алгоритм Джея Кадана (Jay Kadane)  
    • Фильтр Калмана  
    • Жадные алгоритмы  
    • Динамическое программирование  
    • Сжатие данных без потерь  
        • Словарные методы  
            • RLE  
            • LZ77  
        • Энтропийное сжатие  
            • Алгоритм Хаффмана  
            • Арифметическое кодирование  
        • Large Text Compression Benchmark  
    • Криптография  
        • RSA  
        • ECDSA  
    • Задача коммивояжера  
        • NP-полнота  
        • Полный перебор  
        • Алгоритм имитации отжига  
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
• Архитектурные паттерны  
• Паттерны проектирования  
• Сеть  
• SQL  
• Системный дизайн  
• Тестирование  
• Английский язык  

## Содержание

### FizzBuzz <a name="simplefizzbuzz"></a>  

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

### Пузырьковая сортировка <a name="bubblesort"></a>

[ECMA-334](https://www.ecma-international.org/wp-content/uploads/ECMA-334_5th_edition_december_2017.pdf)  

Документация на сайте Microsoft и опция «Загрузить pdf»  
