# Backmap — памятка C# backend программиста

## Оглавление

• Зачем нужны шпаргалки?

### Начальные знания  

• C# 1  
    • [Базовые знания](#basecsharpbasic)  
    • [Классы](#basecsharpclasses)  
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
    • [Бинарное дерево](#basebinarytree)  
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
    • [Какой код лучше?](#archwhatbest)  
    • [Выделение интерфейсов](#archinterfaces)  
    • [IoC/DI](#archiocdi)  
        • [Microsoft.Extensions.DependencyInjection](#archmicrosoftextensionsdependencyInjection)  
        • [Autofac](#archautofac)  
    • SOLID  
        • [SRP](#archsolidsrp)  
        • [OCP](#archsolidocp)  
        • [LSP](#archsolidlsp)  
        • [ISP](#archsolidisp)  
        • [DIP](#archsoliddip)  
• Паттерны проектирования 1  
    • [Singleton](#designpatternssingleton)  
    • [CQRS](#designpatterncqrs)  
    • [Strategy](#designpatternstrategy)  
    • [Observer](#designpatternobserver)  
• Логгирование 1  
    • [Serilog](#loggingserilog)  
        • [Вывод логов в консоль](#loggingconsole)  
        • [Запись логов в файл](#loggingfile)  
        • [Анализ логов](#logginganalize)  
• NUnit 1  
    • [Простые тесты](#nunitsimpletests)  
    • [Архитектура, пригодная для тестирования](#nunittestarch)  
    • [Моки](#nunitmocks)  
    • [Стабы](#nunitstubs)  
    • [Moq](#nunitmoq)  
• Git flow 2  
    • [Минимальный вариант](#gitflowminimum)  
    • [Ветвление](#gitflowfork)  
    • [Слияние](#gitflowmerge)  
    • [Чистка веток](#gitflowcleanup)  

### Сеть  

• [Протокол HTTP/HTTPS](#nethttphttps)  
• [HTML 1](#nethtmlbase)  
    • [DOM 1](#netdombase)  
• [CSS 1](#netcssbase)  
• [TypeScript 1](#nettypescript)  
• [React 1](#netreact)  
• [Отладка в браузере 1](#netbrowserdebug)  
• [ASP.NET Core MVC 1](#netaspnetcoremvc)  
    • [Подключение к БД](#netaspnetcoredatabase)
    • [Фильтры](#netaspnetcorefilters)  
    • [Атрибуты](#netaspnetcoreattributes)  
    • [Middleware](#netaspnetcoremiddleware)  
    • [Взаимодействие ASP.NET Core MVC и React](#netaspnetcorewithreact)  
• [API 1](#netapibase)  
    • [REST 1](#netrestbase)  
    • [gRPC 1](#netgrpcbase)  
• [ASP.NET Core Web API 1](#netaspnetcorewebapi)  
    • [Minimal API](#netaspnetcorewebapiminimalapi)  
    • [Конфигурирование](#netaspnetcorewebapiconfig)  
    • [Аутентификация](#netaspnetcorewebapiauth)    
    • [Проблемы синхронной аутентификации сервер/клиент](#netaspnetcorewebapiauthsync)  
• [Razor 1](#netrazorbase)  
    • [Razor Pages](#netrazorpagesbase)  
    • [Razor Components](#netrazorcomponentsbase)  
• [FluentValidation](#netfluentvalidation)  
• [Polly](#netpolly)  
• [Selenium](#netselenium)  

### Облака

• Azure  
    • [Azure CosmosDB](#azurecosmosdb)  
    • [Azure Functions](#azurefunctions)  

### Продвинутые опции  

• SQL 2  
    • [Хранимые процедуры](#advancedsqlstoredprocedures)  
    • [Триггеры](#advancedsqltriggers)  
    • [Ограничения](#advancedsqlconstraints)  
• [NoSQL](#advancednosql)  
    • [Key-Value хранилища (Redis)](#advancednosqlkvsredis)  
    • [JSON (MongoDB)](#advancednosqljsonmongodb)  
• Entity Framework 2  
    • [кеш второго уровня](#advancedefsecondlevelcash)  
    • [Lazy loading](#advancedeflazyloading)  
    • [Eager loading](#advancedefeagerloading)  
    • [Explicit loading](#advancedefexplicitloading)  
    • [TPT](#advancedeftpt)  
    • [TPH](#advancedeftph)  
• Архитектурные паттерны 2  
    • [DI Life Cycles](#advancedarchpatternsdilifecycles)  
        • [Scoped](#advancedarchpatternsdilifecyclesscoped)  
        • [Transient](#advancedarchpatternsdilifecyclestransient)  
        • [Singleton](#advancedarchpatternsdilifecyclessingleton)  
• Паттерны проектирования 2  
    • [Builder](#advanceddesignpatternsbuilder)  
    • [Decorator](#advanceddesignpatternsdecorator)  
    • [Facade](#advanceddesignpatternsfacade)  
    • [Factory](#advanceddesignpatternsfactory)  
    • [Mediator/MediatR](#advanceddesignpatternsmediator)  
• ASP.NET Core MVC 2  
    • [Quartz.NET](#advancedaspnetcoremvcquartznet)  
• ASP.NET Core Web API 2  
    • [Swagger](#advancedwebapiswagger)  
• [Razor 2](#advancedrazor)  
• [Blazor 1](#advancedblazorbasic)  
• Профилирование 2  
    • [dotTrace](#advancedprofilingjustdottrace)  
    • [dotTrace + SQL](#advancedprofilingdottracesql)  
    • [dotTrace + HTTP](#advancedprofilingdottracehttp)  
    • [Анализ IL-кода](#advancedprofilingilcodeanalysis)  
    • [Sharplab](#advancedprofilingsharplab)  
• Логгирование 2  
    • [ELK Stack](#advancedloggingelkstack)  
        • [Elasticsearch](#advancedloggingelasticsearch)  
            • [OpenSearch](#advancedloggingopensearch)  
        • [Logstash](#advancedlogginglogstash)  
        • [Kibana](#advancedloggingkibana)  
• Алгоритмы 2  
    • Операции со строками  
        • [Алгоритм Ахо-Корасик](#advancedalgorithmsahocorasickalgorithm)  
        • [Алгоритм Рабина-Карпа](#advancedalgorithmsrabinkarpalgorithm)  
    • [P vs NP](#advancedalgorithmspvsnp)  
    • Операции с графами  
        • [Минимальное остовное дерево](#advancedalgorithmsminimumspanningtree)  
            • [Алгоритм Прима](#advancedalgorithmsprimalgorithm)  
            • [Алгоритм Краскала](#advancedalgorithmskruskalalgorithm)  
        • [Алгоритм Флойда-Уоршолла](#advancedalgorithmsfloydwarshallalgorithm)  
        • [Максимальный поток en.wikipedia.org/wiki/Maximum_flow_problem#Algorithms](#advancedalgorithmsmaximumflowproblem)  
            • [Алгоритм Эдмондса — Карпа](#advancedalgorithmsedmondskarpalgorithm)  
    • Вычислительная геометрия  
        • [Пара ближайших точек](#advancedalgorithmsclosestpairofpoints)  
            • [Рекурсивное решение](#advancedalgorithmslineartimerandomizedalgorithm)  
        • [Построение выпуклой оболочки](#advancedalgorithmsconvexhull)  
            • [Обход Грэхэма](#advancedalgorithmsgrahamscan)
    • [Поиск подмассива с максимальной суммой](#advancedalgorithmsmaximumsubarray)
        • [Алгоритм Кадана (Jay Kadane)](#advancedalgorithmskadanealgorithm)  
    • [Фильтр Калмана](#advancedalgorithmskalmanfilter)  
    • [Жадные алгоритмы](#advancedalgorithmsgreedyalgorithms)  
    • [Динамическое программирование](#advancedalgorithmsdynamicprogramming)  
    • Сжатие данных без потерь  
        • Словарные методы  
            • [RLE](#advancedalgorithmsrle)  
            • [LZ77](#advancedalgorithmslz77)  
        • Энтропийное сжатие  
            • [Алгоритм Хаффмана](#advancedalgorithmshuffmancoding)  
            • [Арифметическое кодирование](#advancedalgorithms)  
        • [Large Text Compression Benchmark](#advancedalgorithms)  
    • Криптография  
        • [RSA](#advancedalgorithms)  
        • [ECDSA](#advancedalgorithms)  
    • [Задача коммивояжера](#advancedalgorithms)  
        • [NP-полнота](#advancedalgorithms)  
        • [Полный перебор](#advancedalgorithms)  
        • [Алгоритм имитации отжига](#advancedalgorithms)  
    • [Синтез и оценка алгоритмов](#advancedalgorithms)  
    • [LeetCode](#advancedalgorithms)  
• NUnit 2  
    • [FluentAssertions](#advancednunitfluentassertions)  
    • [GenFu](#advancednunitgenfu)  
    • [TDD? DDD?](#advancednunittddddd)  

### Системный подход  

• [Системный дизайн 1](#systemdesignbase)  
• Микросервисная архитектура  
    • [RabbitMQ](#microservicesrabbitmq)  
    • [MassTramsit](#microservicesmasstransmit)  
    • [Ocelot](#microservicesocelot)  
    • [Docker](#microservicesdocker)  
    • [Kubernetes](#microserviceskubernetes)  
• [CD/CI](#cdcibase)  
    • [GitHub Actions (docs.microsoft.com/ru-ru/dotnet/devops/github-actions-overview)](#githubactionsbase)  
• [Системный дизайн 2](#systemdesignadvanced)  

### Pet-проекты  

• [Игра 2048](#petprojects2048)  
• [Syncro, программа резервного копирования](#petprojectssyncro)  
• [Mikeslist, API сайта объявлений](#petprojectsmikeslist)  
• [Tuppum, прототип блог-платформы](#petprojectstuppum)  
• [Tradercad, сервис технического анализа](#petprojectstradercad)

### Soft skills  

• [Английский язык A2 (грамматика, чтение, письмо, слушание, говорение A2)](#softskillsenglisha2)  
• [Amazon: Leadership Principles (amazon.jobs/en/principles)](#softskillsamazonlp)  
• [Facebook: Core Values (facebook.com/careers/facebook-life/)](#softskillsfacebookcv)  
• [Google: Ten Things We Know to Be True (about.google/philosophy/)](#softskillsgoogletenthings)  
• [Методика STAR](#softskillsstarmethod)  
• [Английский язык B1 (грамматика, чтение, письмо, слушание, говорение B1)](#softskillsenglishb1)  
• [Экзамены IELTS, TOEFL](#softskillsenglishexams)  

### Что почитать  

• [C#](#bibliographycsharp)  
• [Алгоритмы и структуры данных](#bibliographyalgorithmsanddatastructures)  
• [Архитектурные паттерны](#bibliographyarchpatters)  
• [Паттерны проектирования](#bibliographydesignpatters)  
• [Сеть](#bibliographynet)  
• [SQL](#bibliographysql)  
• [Системный дизайн](#bibliographysystemdesign)  
• [Тестирование](#bibliographytests)  
• [Английский язык](#bibliographyenglish)  

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
