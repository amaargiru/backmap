# Backmap — памятка C# backend программиста

## Оглавление

• [Зачем нужны шпаргалки?](#whyrefresher)  

### Начальные знания  

• C# 1  
    • [Базовые знания](#basiccsharpbasic)  
    • [Классы](#basiccsharpclasses)  
    • [LINQ](#basiccsharplinq)  
    • [События](#basiccsharpevents)  
    • [Обобщения](#basiccsharpgenerics)  
    • [Интерфейсы](#basiccsharpinterfaces)  
    • [Делегаты](#basiccsharpdelegates)  
    • [Исключения](#basiccsharpexceptions)  
    • [Garbage collector](#basiccsharpgc)  
    • [Nullable](#basiccsharpnullable)  
    • [Атрибуты](#basiccsharpattributes)  
• Структуры данных  
    • [Массив](#basicarray)  
    • [О-о-о! Большое!](#basicbigo)  
    • [Динамический массив](#basicdarray)  
    • [Односвязный список](#basicslist)  
    • [Двусвязный список](#basicdlist)  
    • [Хэш-таблица](#basichashtable)  
        • [Решение проблем вычисления хеша](#basichashtableproblem)  
    • [Бинарное дерево](#basicbinarytree)  
    • [Б-дерево](#basicbtree)  
    • [Красно-черное дерево](#basicrbtree)  
    • [АВЛ-дерево](#basicavltree)  
    • [Префиксное дерево](#basictrie)  
    • [Выбор структуры данных](#basicstructselection)  
• Алгоритмы 1  
    • [FizzBuzz](#simplefizzbuzz)  
    • Сортировка  
        • [Пузырьковая (Bubble)](#basicbubblesort)  
        • [Быстрая (Quick)](#basicquicksort)  
        • [Слиянием (Merge)](#basicmergesort)  
        • [Пирамидальная (Heap)](#basicheapsort)  
        • [Вставками (Insertion)](#basicinsertionsort)  
        • [Timsort](#basictimsort)  
        • [Introsort](#basicintrosort)  
        • [Поразрядная (Radix)](#basicradixsort)  
    • Поиск  
        • [Линейный поиск](#basiclinearsearch)  
        • [Бинарный поиск](#basicbinarysearch)  
        • [Поиск в глубину (DFS)](#basicdfs)  
        • [Поиск в ширину (BFS)](#basicbfs)  
        • [Алгоритм Дейкстры](#basicdijkstras)  
        • [Алгоритм Беллмана-Форда](#basicbellmanford)  
    • Представление графов  
        • [Матрица смежности](#basicgraphadjacencymatrix)  
        • [Матрица инцидентности](#basicgraphincidencematrix)  
        • [Список смежности](#basicgraphadjacencylist)  
        • [Список инцидентности](#basicgraphincidencelist)  
    • [Конечные автоматы](#basicfinitestatemachine)  
    • [ДПФ/БПФ](#basicfastfouriertransform)  
• SQL 1  
    • [Зачем нужен SQL?](#whysql)  
    • [Create](#sqlbasiccreate)  
    • [Update](#sqlbasicupdate)  
    • [Delete](#sqlbasicdelete)  
    • [Select](#sqlbasicselect)  
    • [Where](#sqlbasicwhere)  
    • [Insert](#sqlbasicinsert)  
    • [Drop](#sqlbasicdrop)  
    • [Show](#sqlbasicshow)  
    • [Join](#sqlbasicjoin)  
• [MS SQL 1](#basicmssql)  
• Entity Framework 1  
    • [Code First](#efbasiccodefirst)  
    • [Миграция](#efbasicmigration)  
    • [Change tracker API](#efbasicctapi)  
• Профилирование 1  
    • [BenchmarkDotNet](#profilingbasicbenchmarkdotnet)  
        • [Сравнение двух вариантов FizzBuzz](#profilingbasicfizzbuzzcompare)  
        • [Сравнение восьми вариантов сортировок](#profilingbasicsortingcompare)  
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
        • [Трехстороннее слияние](#gitflowthreewaymerge)  
        • [WinMerge](#gitflowwinmerge)  
    • [Чистка веток](#gitflowcleanup)  

### Сеть  

• [Протокол HTTP/HTTPS](#nethttphttps)  
• [HTML 1](#nethtmlbasic)  
    • [DOM 1](#netdombasic)  
• [CSS 1](#netcssbasic)  
• [TypeScript 1](#nettypescript)  
• [React 1](#netreact)  
• [Отладка в браузере 1](#netbrowserdebug)  
• [ASP.NET Core MVC 1](#netaspnetcoremvc)  
    • [Подключение к БД](#netaspnetcoredatabasic)  
    • [Фильтры](#netaspnetcorefilters)  
    • [Атрибуты](#netaspnetcoreattributes)  
    • [Middleware](#netaspnetcoremiddleware)  
    • [Взаимодействие ASP.NET Core MVC и React](#netaspnetcorewithreact)  
• [API 1](#netapibasic)  
    • [REST 1](#netrestbasic)  
    • [gRPC 1](#netgrpcbasic)  
• [ASP.NET Core Web API 1](#netaspnetcorewebapi)  
    • [Minimal API](#netaspnetcorewebapiminimalapi)  
    • [Конфигурирование](#netaspnetcorewebapiconfig)  
    • [Аутентификация](#netaspnetcorewebapiauth)    
    • [Проблемы синхронной аутентификации сервер/клиент](#netaspnetcorewebapiauthsync)  
• [Razor 1](#netrazorbasic)  
    • [Razor Pages](#netrazorpagesbasic)  
    • [Razor Components](#netrazorcomponentsbasic)  
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
    • [Кеш второго уровня](#advancedefsecondlevelcash)  
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
        • [Алгоритм Кадана](#advancedalgorithmskadanealgorithm)  
    • [Фильтр Калмана](#advancedalgorithmskalmanfilter)  
    • [Жадные алгоритмы](#advancedalgorithmsgreedyalgorithms)  
    • [Динамическое программирование](#advancedalgorithmsdynamicprogramming)  
    • Сжатие данных без потерь  
        • Словарные методы  
            • [RLE](#advancedalgorithmsrle)  
            • [LZ77](#advancedalgorithmslz77)  
        • Энтропийное сжатие  
            • [Алгоритм Хаффмана](#advancedalgorithmshuffmancoding)  
            • [Арифметическое кодирование](#advancedalgorithmsarithmeticcoding)  
        • [Large Text Compression Benchmark](#advancedalgorithmsltcbenchmark)  
    • Криптография  
        • [RSA](#advancedalgorithmsrsa)  
        • [ECDSA](#advancedalgorithmsecdsa)  
    • [Задача коммивояжера](#advancedalgorithmstravellingsalesman)  
        • [NP-полнота](#advancedalgorithmstravellingsalesmannpcompleteness)  
        • [Полный перебор](#advancedalgorithmstravellingsalesmanbruteforce)  
        • [Алгоритм имитации отжига](#advancedalgorithmstravellingsalesmansimulatedannealing)  
    • [Синтез и оценка алгоритмов](#advancedalgorithmssynthesisandevaluation)  
    • [LeetCode](#advancedalgorithmsleetcode)  
• NUnit 2  
    • [FluentAssertions](#advancednunitfluentassertions)  
    • [GenFu](#advancednunitgenfu)  
    • [TDD? DDD?](#advancednunittddddd)  

### Системный подход  

• [Системный дизайн 1](#systemdesignbasic)  
• [Микросервисная архитектура](#microservicesbasic)  
    • [RabbitMQ](#microservicesrabbitmq)  
    • [MassTramsit](#microservicesmasstransmit)  
    • [Ocelot](#microservicesocelot)  
    • [Docker](#microservicesdocker)  
    • [Kubernetes](#microserviceskubernetes)  
• [CD/CI](#cdcibasic)  
    • [GitHub Actions (docs.microsoft.com/ru-ru/dotnet/devops/github-actions-overview)](#githubactionsbasic)  
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
