# Backmap — памятка программиста

## Оглавление

### Начальные знания  

• # 1  
    •+ [Базовые знания](#basiccsharpbasic)  
    • [Классы](#basiccsharpclasses)  
    •+ [LINQ](#basiccsharplinq)  
        •+ [Примеры использования](#basiccsharplinqexamples)  
    • [События](#basiccsharpevents)  
    • [Обобщения](#basiccsharpgenerics)  
    • [Интерфейсы](#basiccsharpinterfaces)  
    • [Делегаты](#basiccsharpdelegates)  
    • [Исключения](#basiccsharpexceptions)  
        • Правила обработки исключений  
        • Дополнительная информация для исключений  
    •+ [Garbage collector](#basiccsharpgc)  
    •+ [Nullable](#basiccsharpnullable)  
    •+ [Attributes](#basiccsharpattributes)  
        • Условные атрибуты  
        • Создание настраиваемых атрибутов    
        • Обращение к атрибутам при помощи отражения  
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
    •+ [Таблица выбора структуры данных](#basicstructselectiontable)  
• Алгоритмы 1  
    •+ [FizzBuzz](#simplefizzbuzz)  
    • Сортировка  
        •+ [Пузырьковая (Bubble)](#basicbubblesort)  
        • [Быстрая (Quick)](#basicquicksort)  
        • [Слиянием (Merge)](#basicmergesort)  
        • [Пирамидальная (Heap)](#basicheapsort)  
        • [Вставками (Insertion)](#basicinsertionsort)  
        • [Timsort](#basictimsort)  
        • [Introsort](#basicintrosort)  
        • [Поразрядная (Radix)](#basicradixsort)  
        •+ [Таблица сравнения методов сортировки](#basicsortingcomparisontable)  
    • Поиск  
        • [Линейный поиск](#basiclinearsearch)  
        • [Бинарный поиск](#basicbinarysearch)  
        • [Поиск в глубину (DFS)](#basicdfs)  
        • [Поиск в ширину (BFS)](#basicbfs)  
        • [Алгоритм Дейкстры](#basicdijkstras)  
        • [Алгоритм Беллмана-Форда](#basicbellmanford)  
        •+ [Таблица сравнения методов поиска](#basicfindingcomparisontable)  
    • Представление графов  
        •+ [Матрица смежности](#basicgraphadjacencymatrix)  
        •+ [Матрица инцидентности](#basicgraphincidencematrix)  
        •+ [Список смежности](#basicgraphadjacencylist)  
        •+ [Список инцидентности](#basicgraphincidencelist)  
        •+ [Сравнение структур представления графов](#basicgraphstructcomparison)  
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
        • [Асинхронные потоки и каналы (System.IO.Pipelines, System.Threading.Channels)](#csharppipelinesandch)  
        • [Синхронизация потоков](#csharpsyncchannels)  
    • Параллельное программирование (docs.microsoft.com/ru-ru/dotnet/standard/parallel-programming/)  
        • [Структуры данных для параллельного программирования](#csharpdatastructuresforparallelprog)  
            • Monitor  
            • Mutex  
            • Semaphore  
            • AutoResetEvent  
            • ReaderWriterLock  
            • Interlocked  
            • volatile  
            • slim-версии объектов  
    • [2/4 ядра/потока](#csharp24threads)  
        • [Параллельное синхронизированное выполнение в 2 потока (ping-pong)](#csharppingpong2threads)  
        • [Параллельное синхронизированное выполнение на 2 ядрах (ping-pong)](#csharppingpong2cores)  
        • [Параллельное синхронизированное выполнение в 4 потока (mummy-daddy-baby-cat)](#csharppingpong4threads)  
        • [Параллельное синхронизированное выполнение на 4 ядрах (mummy-daddy-baby-cat)](#csharppingpong4cores)  
    • [Параллельная версия FizzBuzz](#csharpparallelfizzbuzz)  
    • [IQueryable](#csharpiqueryable)  
    • [Кеширование](#csharpcashing)  
    • [AutoMapper](#csharpautomapper)  
    • [HangFire](#csharphangfire)  
    • [Stateless](#csharpstateless)  
• Архитектурные принципы и паттерны 1  
    • [Какой код лучше?](#archwhatbest)  
    • [Выделение интерфейсов](#archinterfaces)  
    • [IoC/DI](#archiocdi)  
        • [Microsoft.Extensions.DependencyInjection](#archmicrosoftextensionsdependencyInjection)  
        • [Autofac](#archautofac)  
    •+ [SOLID](#arcchsolid)  
        •+ [SRP](#archsolidsrp)  
        •+ [OCP](#archsolidocp)  
        •+ [LSP](#archsolidlsp)  
        •+ [ISP](#archsolidisp)  
        •+ [DIP](#archsoliddip)  
    •+ [KISS](#archkiss)  
    •+ [DRY](#archdry)  
    •+ [YAGNI](#archyagni)  

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
• [Мутационное тестирование](#mutationtesting)  
    • [Stryker](#mutationtestingstryker)  
• Git flow 2  
    •+ [Минимальный вариант](#gitflowminimum)  
    • [Накопление микрокоммитов с их последующим объединением](#gitflowmicrosum)  
    • [Визуализация](#gitflowvisual)  
    • [Ветвление](#gitflowfork)  
    • [Слияние](#gitflowmerge)  
        • [Простое слияние](#gitflowconflictssimple)  
        • [Разрешение конфликтов](#gitflowconflictscomplex)  
        • [Трехстороннее слияние](#gitflowthreewaymerge)  
        • [WinMerge](#gitflowwinmerge)  
    • [Чистка веток](#gitflowcleanup)  

### Pet-проекты, часть 1

•+ [Игра 2048](#petprojects2048)  
•+ [Syncro, программа резервного копирования](#petprojectssyncro)  

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
    • [sockets](#netsocketsbasic)    
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
    • [Bogus](#advancednunitbogus)  
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

### Pet-проекты, часть 2

• [Mikeslist, API сайта объявлений](#petprojectsmikeslist)  
• [Tuppum, прототип блог-платформы](#petprojectstuppum)  
• [Tradercad, сервис технического анализа](#petprojectstradercad)  
• [English for IT People, сервис изучения английского языка](#petprojectse2itp)

### Soft skills  

• [Английский язык B1 (грамматика, чтение, письмо, слушание, говорение B1)](#softskillsenglishb1)  
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

### Базовые знания <a name="basiccsharpbasic"></a>

Простейшая программа на C#:

```cs
using System;
{
    static void Main()
    {
        var x = 12 * 30;
        Console.WriteLine(x);
    }
}
```

Исходный код -> сборка = единица упаковки и развертывания = приложение или библиотека. У приложения есть точка входа Main(), у приложения нет.  
Встроенные типы = int, string и т. п.  
static - оперирует с самим типом, не static - оперирует с экземпляром типа.  
Типы значений = все числовые типы, char, bool, struct и enum.  
uint ~ 4 млрд., соответственно, int ~ ±2 млрд. (32 бита).  
ulong ~ 18 квинтиллионов (10^18), соотв. long ~ ± 9 квинтиллионов (64 бита).  
Ссылочные типы = все классы, строки, массивы, делегаты и интерфейсы.  
Операция деления на целочисленных типах отбрасывает остаток.  
Операция эквивалентности для строк следует семантике типов значений:  
string a = “test”, b = “test”;  
Console.WriteLine(a == b); // True  

Стандартные значения при инициализации переменной - результат побитового обнуления памяти. Для элементов ссылочного типа = null. Есть ключевое слово default.  
Стек = память для хранения локальных переменных.  
Куча = память для экземпляров ссылочного типа и для статических полей и констант, причем статические поля и константы не обрабатываются сборщиком мусора.  
Операции с более высоким приоритетом выполняются первыми. Если операции имеют одинаковый приоритет, то порядок вычисления определяется ассоциативностью. Порядок вычисления можно менять при помощи скобок.  
Бинарные операции (кроме присваивания, лямбда-операции и операции объединения с null) являются левоассоциативными (вычисляются слева направо).  
Операция присваивания, лямбда-операция, операция объединения с null и условная операция являются правоассоциативными (вычисляются справа налево).  

Пространство имен - область, внутри которой имена типов должны быть уникальными.  

Ссылка на объект приводится вверх неявно, вниз - явно.
as приводит вниз, в случае неудачи получаем null вместо исключения (!!! примеры).
is проверяет правильность приведения (!!! примеры).
virtual - override (!!! примеры).  

Разница между =, Equals() (стр. 104), ReferenceEquals() и GetHashCode(стр. 104) (!!! разжевать).  

Структура vs класс (стр. 105, разжевать !!!).  

Структура может быть readonly, тогда все поля автоматически становятся тоже readonly. Можно объявить readonly функцию структуры, тогда на этапе компиляции будет выдаваться ошибка при попытке изменить любое поле.  

Модификаторы доступа:  

<style>
table:nth-of-type(1) {
    display:table;
    width:100%;
}
table:nth-of-type(1) th:nth-of-type(2) {
    width:75%;
}
</style>

| Модификатор | Значение |  
| :- | :- |  
| public | Полный доступ, неявный доступ для интерфейсов и членов перечисления |  
| internal | Доступ внутри содержащей сборки и в дружественных сборках (помеченных атрибутом сборки InternalsVisibleTo), стандартный доступ для невложенного типа |  
| private | Доступ только внутри содержащего типа, стандартный доступ для членов класса или структуры |   
| protected | Доступ внутри содержащего типа и в его подклассах |  
| protected internal | Объединение доступностей protected и internal (бОльшая доступность), доступ открыт как из содержащей сборки, так и из производных типов |  
| private protected | Пересечение доступностей internal и protected (меньшая доступность), доступ могут иметь только производные типы и только в пределах содержащей сборки |  

Подкласс может иметь только такую же или меньшую доступность.  
Тип устанавливает верхний предел доступности своих членов.  

Базовые знания C# в виде компилируемой программы:

```cs
using System;
using System.Numerics;

/// Основы C# + база ООП
namespace Chapter1
{
    enum DefaultWorkDays // Перечисление с параметрами по умолчанию (int, счет с 0)
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    enum CustomWorkDays : byte // Перечисление
    {
        Monday = 1,
        Tuesday = 1,
        Wednesday = Tuesday,
        Thursday = 3,
        Friday = 50
    }

    /* +, -, !, ~, ++, --, true, false — перегружаемые унарные операторы
     * +, -, *, /, %, &, |, ^, <<, >> — перегружаемые бинарные операторы
     * +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>= — операторы присваивания не могут быть явно перегружены. Но при перегрузке соответствующего бинарного оператора неявно перегружается и оператор присваивания
     * &&, || — условные логические операторы не перегружаются, но они работают на базе & и |, которые могут быть перегружены
     * [] — оператор индексирования массива не может быть перегружен, но можно определить индексаторы.
     * (T)x	— оператор приведения типов не может быть перегружен, но можно определить новые операторы преобразования (explicit и implicit).
     * =, ., ?:, ??, ->, =>, f(x), as, checked, unchecked, default, delegate, is, new, sizeof, typeof — не перегружаемые операторы
     */

    class Program
    {
        // Однострочный комментарий

        /*
         * Многострочный комментарий
         */

        /// Комментарий для документации

        static void Main(string[] args)
        {
            sbyte a = 0; // -128 .. 127
            byte b = 0; // 0 .. 255
            short c = 0; // -32 768 .. 32 767
            ushort d = 0;
            int e = 0; // +- 2.1 млрд
            uint f = 0;
            long g = 0; // +- 9.2 квинтиллиона (9.2 * 10^18)
            ulong h = 0;
            char i = '\0'; // 16-битный символ Unicode
            float j = 0; // 32 бита. Точность 23 бита (7 десятичных)
            double k = 0; // 64 бита. Точность 52 бита (15 десятичных)
            bool l = false;
            decimal m = 0; // 128 бит. 
            string n = "";
            object o = null;
            dynamic p = null;

            byte[] bytes = { 0xAA, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xAA };
            BigInteger bi1 = new BigInteger(bytes);
            string st = "-9031583741089631207100208803714000000000000000000";
            BigInteger bi2 = BigInteger.Parse(st);

            Complex complex1 = new Complex(1, 1);

            System.Int32 q = new System.Int32(); // Четыре эквивалентных варианта инициализации переменной типа int
            System.Int32 r = 0;
            int s = new int();
            int t = 0;

            int u = 1_000_000_000; // Можно вставлять _ для удобочитаемости
            int v = 0x_ff_ff_ff; // Можно в шестнадцатеричном виде
            int w = 0b_1111_1111; // Можно в двоичном виде

            int x = 10;
            long y = x; // Приведение типа без риска потери данных можно делать неявно
            x = (int)y; // Приведение типа с риском потери данных нужно делать явно

            double z = 3.1416; // Действительный литерал по умолчанию рассматривается как double
            float a1 = 3.1416f; // Для действительного литерала float нужен суффикс f
            decimal b1 = 3.1416m; // Для действительного литерала decimal нужен суффикс m

            double doub = 3.2e3; // == 3200. Для действительных чисел можно использовать литералы в экспоненциальной форме
            decimal decim = 2E-2m; // == 0.02

            double c1 = 3.9999;
            int d1 = (int)c1; // == 3, дробная часть отбрасывается

            Console.WriteLine(999.ToString()); // Литерал является экземпляром типа, поэтому к литералу применимы экземплярные методы

            byte e1 = 200;
            e1 = (byte)(e1 + 100); // e1 == 44, т. к. произошло переполнение. + Необходимо явное приведение типов, т. к. перед операцией сложения приводятся к 32-х или 64-х разрядному типу
            //e1 = checked((byte)(e1 + 255)); // Оператор checked генерирует IL-команды с проверкой переполнения. В данном случае будет выдано исключение
            e1 = unchecked((byte)(e1 + 255)); // Оператор unchecked генерирует IL-команды без проверки переполнения, даже при опции компилятора /checked+

            checked // Кроме оператора checked, есть инструкция checked, позволяющая отделять блоки кода
            {
                // e1 += 255;
            }

            checked
            {
                //SomeMethod(500); Действие инструкции и оператора checked не распространяется на методы.

                decimal f1 = decimal.MaxValue;
                //f1 += 1; // Действие инструкции и оператора checked не распространяется на decimal, BigInteger и Complex. Переполнение будет вызвано средствами проверки, встроенными в decimal
            }

            int? n2 = 5; // Nullable-типы
            Nullable<int> o2 = 5; // Эквивалентное объявление
            bool? p2 = null;
            Nullable<bool> q2 = null;
            double? r2 = 3.3;
            Nullable<Double> s2 = 3.3;

            char g1 = '\x79'; // == 'y'. Литерал в виде кода ASCII
            char h1 = '\u2030'; // == '‰'. Литерал в виде кода ASCII
            string i1 = "Manual";
            string j1 = $"{h1} is promille"; // Интерполяция
            string j22 = new string('a', 5); // = "aaaaa"

            int k1 = 0b01010101;
            int l1 = 0b00101010;
            int m1 = k1 & l1; // Логическое умножение
            m1 = k1 | l1; // Логическое сложение
            m1 = k1 ^ l1; // Сложение по модулю 2
            m1 = ~k1; // Инверсия

            sbyte n1 = 25;
            sbyte o1 = (sbyte)(~n1 + 1); // Получаем отрицательное число в дополнительном коде

            byte p1 = 0b10101010;
            byte q1 = (byte)(p1 >> 4); // == 0b00001010. Сдвиг вправо
            q1 = (byte)(p1 << 4); // == 0b101000. Сдвиг влево

            /* Приоритет операторов
             * x.y, x?.y, x?[y], f(x), a[x], x++, x--, new, typeof, checked, unchecked, default(T), delegate, sizeof, ->
             * +x, -x, !x, ~x, ++x, --x, (T)x, await, &x, *x
             * x*y, x/y, x%y
             * x+y, x-y
             * x<<y, x>>y
             * x<y, x>y, x<=y, x>=y, is, as
             * x==y, x!=y
             * x&y
             * x^y
             * x|y
             * x&&y
             * x||y
             * x&&y
             * t&x:y
             * x=y, x+=y, x-=y, x*=y, x/=y, x%=y, x&=y, x|=y, x^=y, x<<=y, x>>=y, =>
             */

            int r1 = 0;
            int s1 = 0;

            if (r1 > s1) // Условие
            {
                // do something
            }
            else
            {
                // do something else
            }

            switch (r1) // switch
            {
                case 0:
                    // do something
                    break;
                case 1:
                    // do something else
                    break;
                default:
                    // do default
                    break;
            }

            s1 = r1 == 0 ? r - 1 : r + 1; // Тернарная операция

            string l2 = null;
            string m2 = l2 ?? "not null"; // null-объединение

            decimal? t2 = null;
            BankAccount ba4 = new BankAccount();
            BankAccount[] barray = new BankAccount[10];
            t2 = ba4?.Amount; // Оператор условного null
            BankAccount u2 = barray?[0];

            /* Виды циклов
             * for
             * foreach
             * while
             * do .. while
             */

            int[] t1 = new int[4] { 1, 2, 3, 4 }; // Четыре эквивалентных варианта объявления массива
            int[] u1 = new int[] { 1, 2, 3, 4 };
            int[] v1 = new[] { 1, 2, 3, 4 };
            int[] w2 = { 1, 2, 3, 4 };

            int[,] x1 = new int[2, 3]; // Пять эквивалентных вариантов объявления двухмерного массива
            int[,] y1 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] z1 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] a2 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] b2 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[][] c2 = new int[3][]; // Зубчатый массив (массив массивов)
            c2[0] = new int[2] { 1, 2 };
            c2[1] = new int[3] { 1, 2, 3 };
            c2[2] = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(SayHelloFull()); // Вызов метода
            Console.WriteLine(SayHelloShort());

            int d2 = SumExample(1, 2, 10, 10); //Вызов метода с необязательными параметрами
            d2 = SumExample(1, 2, 10);
            d2 = SumExample(1, 2);
            d2 = SumExample(b: 1, a: 2); // Использование именованных параметров

            int e2 = 0;
            int f2 = 0;
            int g2 = SumExampleRef(ref e2, ref f2); //Передача параметров по ссылке при помощи ключевого слова ref
            SumExampleOut(2, 2, out g2); //Передача параметров по ссылке при помощи ключевого слова out

            SumExampleParams(); // Неопределенное число входных параметров
            SumExampleParams(1);
            SumExampleParams(1, 2);
            SumExampleParams(1, 2, 20);
            int[] h2 = { 100, 200, 300 };
            SumExampleParams(h2);

            int i2 = Factorial(10); // Рекурсивный метод

            DefaultWorkDays j2 = DefaultWorkDays.Monday; // Перечисления
            CustomWorkDays k2 = CustomWorkDays.Tuesday;

            (int, int) tuple1 = (1, 2); // Кортежи
            (string, int, float) tuple2 = ("aa", 1, 1.0f);
            var tuple3 = (first: 1, second: 2);
            Console.WriteLine(tuple3.first);

            /* Принципы ООП
             * Абстрагирование: создание модели объекта, релевантной в контексте решаемой задачи
             * 
             * Инкапсуляция: объединение данных и методов их обработки + сокрытие внутренней реализации от внешнего мира
             * Наследование: наследование, перекрытие и дополнение полей и методов
             * Полиморфизм: возможность работы с объектами без одозначной идентификации их типа + собственная реализация производными классами виртуальных методов, определенных в базовом классе
             */

            /* Модификаторы
             * public Доступ к коду возможен отовсюду, даже из другой сборки
             * private Доступен только из того же класса или структуры
             * protected Доступен только из того же класса или из производного класса
             * internal Доступен внутри сборки
             * protected internal Доступен внутри сборки и из производных классов в других сборках
             * private protected Доступен внутри сборки в том же или в производных классах
             * 
             * abstract Определяет функционал для группы родственных объектов. Модификатор abstract подразумевает, что экземпляр такого базового класса создаваться не будет.
             * sealed Запрещает наследование от класса
             * static Объявление статического члена, принадлежащего собственно типу, а не конкретному объекту
             * partial Разделямый тип или метод
             * 
             * virtual Позволяет переопределять (а не перекрывать) член базового класса
             * override Для переопределения членов, помеченных virtual
             * 
             * interface Определяет функционал для группы разрозненных объектов
             * 
             * extern Объявление метода с внешней реализацией
             * volatile Для членов, которые будут изменяться из нескольких потоков
             * readonly Значение переменной задается только при объявлении или в конструкторе
             * const Не рекомендуется, т. к. при смене константы потребуется перекомпиляция всего зависимого кода
             */

            BankAccount ba1 = new BankAccount(); // Использование конструкторов
            BankAccount ba2 = new BankAccount(1000.0m);
            BankAccount ba3 = new BankAccount // Использование инициализатора
            {
                Amount = 2000.0m
            };

            ba3.DecAmount(); // Перегрузка методов
            ba3.DecAmount(10);

            BankAccount.Bonus = 999;
            Console.WriteLine(ba1.GetBonus()); // 999, переопределение статического поля сказывается на всех объектах данного типа
            Console.WriteLine(ba2.GetBonus()); // 999

            ba3 = ba1 + ba2; // Перегрузка оператора +, теперь он может суммировать наши объекты
            ba3 = ba1 + 1000;

            Console.ReadKey();
        }

        static string SayHelloFull() // Просто метод 
        {
            return "Hello World!";
        }

        static string SayHelloShort() => "Hello again!"; // Сокращенная запись однострочного метода, оператор return не требуется

        static int SumExample(int a, int b, int c = 3, int d = 4) //Метод с необязательными параметрами
        {
            return a + b + c + d;
        }

        static int SumExampleRef(ref int a, ref int b) //Передача параметров по ссылке ref
        {
            a++;
            return a + b;
        }

        static void SumExampleOut(int a, int b, out int sum) //Передача параметров по ссылке out
        {
            sum = a + b;
        }

        static int SumExampleParams(params int[] input) // Неопределенное число входных параметров
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }

        static int Factorial(int x) // Рекурсивный метод
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }

    class BankAccount
    {
        private readonly decimal DefaultAmount = 1000;
        private readonly decimal MaxAmount = 1000_000_000;

        private decimal amount; // Поле
        private static decimal bonus; // Статическое поле

        public BankAccount() // Конструктор
        {
            amount = DefaultAmount;
        }

        public BankAccount(decimal InitialAmount) // Еще один конструктор
        {
            amount = InitialAmount;
        }

        public decimal IncAmount() // Метод
        {
            amount++;
            return amount;
        }

        public decimal DecAmount()
        {
            if (amount > 1)
            {
                amount--;
            }
            return amount;
        }

        public decimal DecAmount(decimal decrement) // Перегрузка методов
        {
            if (amount > decrement)
            {
                amount -= decrement;
            }
            return amount;
        }

        public decimal Amount // Свойство, позволяет подключить дополнительную логику
        {
            get
            {
                return amount;
            }
            set
            {
                if ((value >= 0) && (value <= MaxAmount))
                {
                    amount = value;
                }
            }
        }

        public static decimal Bonus // Статическое свойство
        {
            get
            {
                return bonus;
            }
            set
            {
                if (value >= 0)
                {
                    bonus = value;
                }
            }
        }

        public decimal GetBonus()
        {
            return bonus;
        }

        public static BankAccount operator +(BankAccount bankAccount1, BankAccount bankAccount2) // Перегрузка оператора
        {
            return new BankAccount
            {
                Amount = bankAccount1.Amount + bankAccount2.Amount
            };
        }

        public static BankAccount operator +(BankAccount bankAccount1, int addSum) // Перегрузка перегруженного оператора
        {
            return new BankAccount
            {
                Amount = bankAccount1.Amount + addSum
            };
        }
    }

    class BankAccountWithCurrency : BankAccount // Наследование. Конструкторы и методы завершения не наследуются
    {

    }
}
```

### LINQ <a name="basiccsharplinq"></a>

__LINQ__ (он же Language-Integrated Query, он же интегрированный язык запросов) — технология обработки коллекций данных, встроенная в язык C#, позволяющая создавать удобочитаемые запросы, результатом которых будет новая коллекция данных, отобранных по нужному нам признаку, число или даже значение типа bool. Так что если:  
a) у вас есть некоторая __коллекция данных__ (или несколько коллекций) и вам нужно их каким-либо образом обработать (нарезать на кусочки; отделить данные, удовлетворяющие определенным требованиям; вычислить усредненные метрики; определить область пересечения двух разных коллекций);  
б) вы хотите, чтобы запросы к данным были __легко читаемыми__, создаваемыми и редактируемыми (вполне жизненная шутка «если вы решили вашу проблему при помощи регулярок, то теперь у вас две проблемы» не на пустом месте взялась; это грустная констатация факта от лица программиста, попытавшегося на следующий день перечитать свой код);  
в) и при этом вы готовы пойти на некоторые компромиссы, связанные с __быстродействием__ полученного решения;  
то использование LINQ — вариант № 1.  
  
Для работы нам понадобятся следующие ингридиенты:  
• какая-нибудь IDE, работающая с C#; я предпочитаю Visual Studio, но это, разумеется, не принципиально;  
• [исходные коды LINQ](github.com/dotnet/runtime/tree/main/src/libraries/System.Linq/src/System/Linq), которые Microsoft нам любезно предоставила (всё-таки приятно, когда корпорации, хоть и в собственных интересах, [тратят](https://www.nytimes.com/2002/02/13/business/microsoft-is-putting-its-muscle-behind-web-programming-tools.html) миллионы человеко-часов и миллиарды долларов на новые технологии, а потом дают нам на этом покататься);  
 • раз уж речь зашла о быстродействии, то чтобы не быть голословным, нужно использовать какой-нибудь перформансметр; возьмем [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet).  
  
__Малюсенькая историческая справка__  
  
Что мы обычно делаем, когда нам нужно обработать данные? Ну, например, у нас есть список сотрудников нашего предприятия, и нам нужно получить список только тех, чья переработка составила не менее 40 рабочих дней и нам нужно этого человека срочно отправить в отпуск? Как правило, пишется цикл for (или, если программист чувствует прилив Силы, то foreach), в котором перебираются все записи в некоторой коллекции данных, содержащей данные о сотрудниках, и если анализируемое поле удовлетворяет заданному нами условию, запись копируется в новую, специально для этого созданную коллекцию:

```csharp
// !!! Перепроверить
List<Employee> vacationList = new();
int vacationBorder = 40;

foreach (var employee in employees)
{
  if (employee.overtime >= vacationBorder)
  {
    vacationList.Add(employee);
  }
}
```

Но, к счастью, разработчики языка C# заметили, что параллельно с «нормальными» языками программирования вполне себе развиваются и прогрессируют языки структурированных запросов, созданные для управления информацией, содержащейся внутри баз данных, и развиваются, в общем, в правильном направлении. Microsoft решила внедрить свой «как-бы» SQL в язык C#, получилось удачно, так что, например, и [Java](https://stackoverflow.com/questions/1217228/what-is-the-java-equivalent-for-linq)-, и [C++](https://stackoverflow.com/questions/232222/is-there-a-linq-library-for-c)-программисты немного горюют по поводу отсутствия LINQ в соответствующих языках.  
С применением LINQ показанный выше запрос будет выглядеть так:  
!!!  
Или так:  
!!!  
  
__Синтаксис__  
  
Исторически сложилось так, что у запросов LINQ две возможных формы написания: __синтаксис запросов__ (query syntax) и __синтаксис методов__ (method syntax), иногда называемый также __текучим синтаксисом__ (fluent syntax). Два примера выше как раз и написаны с применением разных синтаксисов, но делают абсолютно одно и то же.  
Далее мы сосредоточимся на синтаксисе методов, так как он: а) имеет больше методов и б) позволяет добавлять методы самостоятельно. Есть кейсы (МГИМО финишд, ага), в которых синтаксис запросов имеет некоторые преимущества, потому что включает, например, ключевое слово let, позволяющее ввести новую переменную прямо посреди запроса или повышенная удобочитаемость длинных запросов. Но в целом, особенно с учетом того, что стандарт [ECMA-334](https://www.ecma-international.org/wp-content/uploads/ECMA-334_5th_edition_december_2017.pdf) недвусмысленно намекает на некоторую «вторичность» синтаксиса запросов (пункт 12.17.3.1, «The C# language does not specify the execution semantics of query expressions. Rather, query expressions are translated into invocations of methods that adhere to the query-expression pattern»), можно рассматривать синтаксис методов как основной, а синтаксис запросов — как вспомогательный.  

| Метод | Функция | Пример |
| :- | :- | :- |
| Aggregate | Объединяет элементы последовательности, используя входную функцию | Перемножение элементов последовательности |  
| Aggregate | Объединяет элементы последовательности, используя входную функцию и начальное значение |  
| Aggregate | Объединяет элементы последовательности, используя входную функцию, начальное значение и функцию селекции результата |  
| All | Проверяет, все ли элементы последовательности удовлетворяют условию | Проверка на чётность всех элементов последовательности |  
| Any | Проверяет, содержит ли последовательность хотя бы один элемент |  
| Any | Проверяет, содержит ли последовательность хотя бы один элемент, удовлетворяющий условию | Единственное четное число в нечетной последовательности |  
| Append | Добавляет значение в конец последовательности, выдает новую последовательность |  
| AsEnumerable | Просто говорит компилятору, что нужно использовать метод, относящийся к IEnumerable, а не к, скажем, IQueryable |  
| [Average](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Average.cs) | Вычисляет среднее значение |  
| Cast | Преобразует коллекции старого типа (non-generic collections) на базе IEnumerable в коллекцию нового типа на базе IEnumerable<T> |  
| Concat | Конкатенация двух последовательностей|  
| Contains | Проверяет, содержит ли последовательность указанный элемент |  
| [Count](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Count.cs) | Возвращает количество элементов |  
| [Count](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Count.cs) | Возвращает количество элементов, удовлетворяющих условию |  
| DefaultIfEmpty | Возвращает коллекцию с одним элементом по умолчанию, если входная последовательность пуста |  
| Distinct | Возвращает только различающиеся элементы последовательности |  
| ElementAt | Возвращает элемент последовательности, расположенный по указанному индексу |  
| ElementAtOrDefault | Возвращает элемент последовательности, расположенный по указанному индексу или значение по умолчанию |  
| Empty | Создает пустую последовательность |  
| Except | Возвращает разность двух последовательностей | 
| First | Возвращает первый элемент последовательности |  
| First | Возвращает первый элемент последовательности, удовлетворяющий условию
| FirstOrDefault | Возвращает первый элемент последовательности или значение по умолчанию, если последовательность пуста |  
| FirstOrDefault |  Возвращает первый элемент последовательности, удовлетворяющий условию или значение по умолчанию, если последовательность не содержит ни одного удовлетворяющего условию элемента |  
| GroupBy | Разбивает последовательность на подпоследовательности |  
| GroupJoin | Устанавливает корреляцию между элементами двух последовательностей на основе равенства ключей и группирует результаты | 
| Intersect | Находит пересечение двух последовательностей |  
| Join | Устанавливает корреляцию между элементами двух последовательностей на основе равенства ключей |  
| Last | Возвращает последний элемент последовательности |  
| Last | Возвращает последний элемент последовательности, удовлетворяющий условию |  
| LastOrDefault | Возвращает последний элемент последовательности или значение по умолчанию, если ни одного элемента не найдено |  
| LastOrDefault | Возвращает последний элемент последовательности, удовлетворяющий условию или значение по умолчанию, если ни одного элемента не найдено |  
| [LongCount](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Count.cs) | Возвращает количество элементов типа long |  
| [LongCount](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Count.cs) | Возвращает количество элементов типа long, удовлетворяющих условию |  
| [Max](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Max.cs) | Возвращает максимальное значение, содержащееся в последовательности |  
| [Max](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Max.cs) | Вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение, содержащееся в полученной последовательности |  
| [Min](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Min.cs) | Возвращает минимальное значение, содержащееся в последовательности |  
| [Min](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Min.cs) | Вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение, содержащееся в полученной последовательности |  
| OfType | Преобразует IEnumerable к IEnumerable<T>, отбрасывая элементы с несоответствующим типом |  
| OrderBy | Сортирует элементы последовательности в порядке возрастания |  
| OrderByDescending | Сортирует элементы последовательности в порядке убывания |  
| Prepend | Добавляет значение в начало последовательности, выдает новую последовательность |
| Range | Генерирует последовательность целых чисел в заданном диапазоне |  
| Repeat | Генерирует последовательность, содержащую одно повторяющееся значение |
| Reverse | Инвертирует порядок следования элементов последовательности |  
| Select | Преобразует последовательность в новую последовательность, возвращая один выходной элемент для каждого входного элемента |  
| SelectMany | Преобразует каждый элемент последовательности в новую последовательность и объединяет полученные последовательности в одну последовательность |
| SequenceEqual | Определяет, равны ли две последовательности |  
| Single | Возвращает единственный конкретный элемент последовательности |  
| SingleOrDefault | Возвращает единственный конкретный элемент последовательности или значение по умолчанию, если такой элемент не найден |
| Skip | Возвращает элементы последовательности за вычетом заданного числа первых элементов
| SkipLast | Возвращает элементы последовательности за вычетом заданного числа последних элементов |  
| SkipWhile | Пропускает элементы последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы |
| [Sum](github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Sum.cs) | Возвращает сумму последовательности |
| Take | Возвращает заданное число первых элементов |  
| TakeLast | Возвращает заданное число последних элементов  
| TakeWhile | Возвращает элементы последовательности, пока они удовлетворяют заданному условию, и затем пропускает оставшиеся элементы |  
| ThenBy | Дополнительно сортирует элементы последовательности в порядке возрастания |
| ThenByDescending | Дополнительно сортирует элементы последовательности в порядке убывания |  
| ToArray | Преобразует последовательность в массив |  
| ToDictionary | Преобразует последовательность в Dictionary |  
| ToHashSet | Преобразует последовательность в HashSet |  
| ToList | Преобразует последовательность в List |  
| ToLookup | Преобразует последовательность в Lookup |  
| Union | Возвращает элементы, имеющиеся в обеих входных последовательностях, кроме дубликатов |  
| Where | Выполняет фильтрацию последовательности |  
| Zip | Возвращает последовательность, содержащую объединенные элементы двух входных последовательностей |  

### Примеры использования LINQ <a name="basiccsharplinqexamples"></a>

Сначала создаем множество сотрудников...
```csharp
using System;
using System.Collections.Generic;
using System.IO;

namespace Linq
{
    public static class GenerateRandomStaff
    {
        private static readonly Random random = new();
        const int minOvertime = -10;
        const int maxOvertime = 100;

        public static Dictionary<string, int> Get(int workersNum)
        {
            Dictionary<string, int> staff = new();

            while (staff.Count < workersNum)
            {
                var workerName = Path.GetRandomFileName()[..3];
                var workerOvertime = random.Next(minOvertime, maxOvertime);

                staff[workerName] = workerOvertime;
            }

            return staff;
        }
    }
}
```

...потом обрабатываем эти данные:

```csharp
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
```

### Garbage collector <a name="basiccsharpgc"></a>  

Сборщик мусора = автоматический диспетчер памяти. Учитывая то, что, по некоторым данным, разработчики, использующие C++, тратят на управление памятью и на устранение проблем, связанных с управлением памятью, до 40 % рабочего времени, польза автоматической диспетчеризации памяти достаточно очевидна.  

Каждому процессу при помощи VirtualAlloc выделяется виртуальное адресное пространство (соответсвующая непрерывной области физичесской памяти) = управляемая куча для размещения ссылочных типов (SOH) + куча для больших объектов ,размером от 85 кб (LOH), вся работа ведется только с эти пространством, процесс не может управлять физической памятью напрямую, по умолчанию 2 Гбайта для 32-х разрядного процесса. Виртуальная память может дефрагментироваться или закончиться (тогда в действие всупает файл подкачки, общий для всех процессов). Все потоки процесса берут память из общей кучи.  

При анализе памяти сборщик памяти строит дерево объектов. Объекты, не достижимые из корней (roots), удаляются, достижимые объекты уплотняются. Куча для больших объектов обычно не уплотняется.  

Освобожденные сегменты возвращаются ОС при помощи VirtualFree.

Объекты в виртуальной куче делятся на три поколения 0, 1 и 2.  
Поколение 0 - короткоживущие объекты. Если сборка мусора в поколении 0 не принесла достаточно памяти, будет выполнен анализ поколения 1, затем 2. При анализе поколения 0 анализ поколений 1 и 2 может не производится.  
Поколение 2 - долгоживущие объекты, например, статические объекты.  
Куча больших объектов собирается только во время сборки мусора поколения 2.

Сборщик мусора рабочей станции работает с приоритетом основного потока. Сборщик мусора сервера запускается в отдельном потоке (потоках) с приоритетом THREAD_PRIORITY_HIGHEST. У компьютера с одним процессором всегда запускается сборщик рабочей станции, несмотря на конфигурацию.

Анализ работы GC осуществляется при помощи [PerfView](https://github.com/microsoft/perfview). При невозможности выделить память будет сгенерировано [OutOfMemoryException](https://docs.microsoft.com/en-us/dotnet/api/system.outofmemoryexception).  

Для принудительного запуска сборщика мусора можно вызвать GC.Collect() с параметром GCCollectionMode = Forced. Можно также сжать кучу больших объектов при помощи  GCLargeObjectHeapCompactionMode.CompactOnce.  

Можно получать уведомления о приближении полной сборки мусора и о ее окончании.



### Nullable <a name="basiccsharpnullable"></a>  

Три операции для работы со значениями null:  
  
1. Операция объединения с null:  
```csharp
int b = a ?? 7;  
```
Если значение слева ≠ null, значение справа не вычисляется.  
2. null-условная операция (элвис-операция):  
```csharp
string s = sb?.ToString();  
```
Результатом будет значение или null, исключение никогда не возникает. Если элвис-операция столкнется с null, то прекращает дальнейшие вычисления. Окончательное выражение должно уметь принимать null.  
3. Операция присваивания с объединением с null. Операция выполняет присваивание только если переменная не null:  
```csharp
s ??= “Welcome”;  
```
эквивалентно  
```csharp
if (s != null) s = “Welcome”;  
```
Операция объединения с null и элвис-операция хорошо сочетаются:  
```csharp
string s = sb?.ToString() ?? “Empty”;  
```

### Attributes <a name="basiccsharpattributes"></a>  

Атрибуты — своего рода ярлыки, сообщающие внешним инструментам дополнитнльные сведения о методах обработки сущностей (это, например, отдельный метод, класс или вся сборка), на которые они «наклеены». Атрибуты добавляют к сущностям метаданные, которые можно считать и проконтролировать при помощи отражения.  

Чтобы явным образом обозначить цель атрибута, нужно использовать следующий синтаксис:
```csharp
[target : attribute-list]  
```

Возможные значения target показаны в таблице:

| Значение | Область применения |
| :- | :- |
| assembly | Вся сборка |
| module | Модуль текущей сборки |
| field | Поле в классе или структуре |
| event | Событие |
| method | Метод либо методы доступа к свойствам get и set |
| param | Параметры метода или параметры метода доступа set |
| property | Свойство |
| return | Возвращаемое значение метода, индексатора свойства или метода доступа к свойствам get |
| type | Структура, класс, интерфейс, перечисление или делегат |

Вот несколько распространенных сценариев использования атрибутов:  
• указание для методов в веб-службах атрибута WebMethod, который обозначает, что метод должен вызываться по протоколу SOAP (WebMethodAttribute);  
• описание способов упаковки параметров методов при взаимодействии с машинным кодом (MarshalAsAttribute);  
• описание свойств COM для классов, методов и интерфейсов;  
• вызов неуправляемого кода (DllImportAttribute);  
• указание для сборки таких параметров, как заголовок, версия, описание или товарный знак;  
• указание членов класса, которые будут сериализованы при сохранении класса;  
• описание правил сопоставления членов класса с XML-узлами при XML-сериализации;  
• описание требований безопасности для методов;  
• указание характеристик, используемых для обеспечения безопасности;  
• управление оптимизацией для JIT-компилятора, сохраняя при этом простоту отладки кода;  
• получение сведений об объекте, вызывающем метод.  

### Таблица выбора структуры данных <a name="basicstructselectiontable"></a>  

В квадратных скобках показан худший случай.

<style>
table th:first-of-type {
    width: 25%;
}
table th:nth-of-type(2) {
    width: 25%;
}
table th:nth-of-type(3) {
    width: 25%;
}
table th:nth-of-type(4) {
    width: 5%;
}
table th:nth-of-type(5) {
    width: 5%;
}
table th:nth-of-type(6) {
    width: 5%;
}
table th:nth-of-type(7) {
    width: 5%;
}
table th:nth-of-type(8) {
    width: 5%;
}
</style>

| Структура | Реализация | Применение | Индекс. | Поиск | Вставка | Удал. | Память |
| :- | :- | :- | :-: | :-: | :-: | :-: | :-: |
| Массив | Array, SortedList, Stack, Queue, PriorityQueue |  | 1 | n |  |  | n |
| Динамический массив | List\<T> |  | 1 | n | n | n | n |
| Односвязный список | ListDictionary |  | n | n | 1 | 1 | n |
| Двусвязный список | LinkedList\<T> |  | n | n | 1 | 1 | n |
| Хэш таблица | HashSet\<T>, Dictionary\<K,V>, OrdereDictionary\<T> |  |  | 1<br> [n] | 1<br> [n] | 1<br> [n] | n |
| Бинарное дерево | SortedDictionary\<T> |  | logn<br> [n] | logn<br> [n] | logn<br> [n] | logn<br> [n] | n |
| Б-дерево |  | Для памяти с медленным доступом | logn | logn | logn | logn | n |
| КЧ дерево | SortedSet\<T> |  | logn | logn | logn | logn | n |
| АВЛ дерево |  |  | logn | logn | logn | logn | n |
| Префиксное дерево |  | T9, алгоритм [Ахо–Корасик](https://en.wikipedia.org/wiki/Aho%E2%80%93Corasick_algorithm) |  | key | key | key |  |

n! >> 2^n >> n^3 >> n^2 >> nlogn >> n >> logn >>1

### FizzBuzz <a name="simplefizzbuzz"></a>  

Почему нужно просить выполнить столь простое задание? Вот подробности — «[FizzBuzz, или почему программисты не умеют программировать](https://habr.com/ru/post/298134/)», если вкратце, то, к сожалению, можно сказать, что и профильное образование, и профильный опыт не уберегают от потери базовых навыков программирования.  

Задание: Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», а вместо чисел, кратных пяти — слово «Buzz». Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».  

Самый простой вариант:  
```csharp
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

```csharp
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

```cs
int[] arr = { 11, 120, 12, 130, 0, -1000, int.MaxValue, 0, 1_000_000_000, 0xFF, int.MinValue, 0, 100 };

int len = arr.Length;

for (int i = 0; i < len - 1; i++)
{
   for (int j = 0; j < len - i - 1; j++)
   {
      if (arr[j] > arr[j + 1])
      {
         (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
      }
   }
}

Array.ForEach(arr, Console.WriteLine);

Console.ReadKey();
```

### Таблица сравнения методов сортировки <a name="basicsortingcomparisontable"></a>  
  
<style>
table th:first-of-type {
    width: 35%;
}
table th:nth-of-type(2) {
    width: 35%;
}
table th:nth-of-type(3) {
    width: 5%;
}
table th:nth-of-type(4) {
    width: 5%;
}
table th:nth-of-type(5) {
    width: 5%;
}
table th:nth-of-type(6) {
    width: 5%;
}
table th:nth-of-type(7) {
    width: 5%;
}
table th:nth-of-type(8) {
    width: 5%;
}
</style>

| Сортировка | Преимущество | Best | Avg | Worst | Mem | Stable | Paral |
| :- | :- | :-: | :-: | :-: | :-: | :-: | :-: |
| Пузырьковая<br>(Bubble) | Простейшая реализация | n | n^2 | n^2 | 1 | + | + |
| Быстрая<br>(Quick) | Хорошее быстродействие в среднем случае | n*logn | n*logn | n^2 | logn | +/-<br>(depends) | + |
| Слиянием<br>(Merge) | Работает с последовательным доступом | n*logn | n*logn | n*logn | n<br>(depends) | + | + |
| Пирамидальная<br>(Heap) | Хорошая производительность в наихудшем случае | n*logn | n*logn | n*logn | 1 | - | - |
| Вставками<br>(Insertion) | Рекомедуется для почти отсортированных данных или для малого количества элементов | n | n^2 | n^2 | 1 | + | - |
| Timsort | Комбинированный алгоритм. Стандарт для Python, Java, Swift | n*logn | n*logn | n*logn | logn | - | - |
| Introsort | Комбинированный алгоритм. Стандарт для .Net | n*logn | n*logn | n*logn | logn | - | - |
| Поразрядная<br>(Radix) | Быстрая сортировка для целых чисел и строк | n*w | n*w | n*w | n+w | +/-<br>(depends) | + |

### Таблица сравнения методов поиска <a name="basicfindingcomparisontable"></a>  

| Вид поиска | Структура данных | Avg | Worst | Mem |
| :- | :- | :-: | :-: | :-: |
| Линейный поиск | Массив | n | n | 1 |
| Бинарный поиск | Отсортированный массив | logn | n | 1 |
| Поиск в глубину (DFS) | Граф |  | V+E | V |
| Поиск в ширину (BFS) | Граф |  | V+E | V |
| Алгоритм Дейкстры | Граф | (V+E)logV | (V+E)logV | V |
| Алгоритм Беллмана-Форда | Граф | V*E | V*E | V |

### Матрица смежности <a name="basicgraphadjacencymatrix"></a>  

Квадратная целочисленная матрица размера V*V, в которой значение элемента a{i,j} равно числу рёбер из i-й вершины в j-ю вершину.  
Матрица смежности простого графа (не содержащего петель и кратных рёбер) является бинарной матрицей и содержит нули на главной диагонали.

### Матрица инцидентности <a name="basicgraphincidencematrix"></a>  

Способ представления графа, в которой указываются связи между инцидентными элементами графа (ребрами и вершинами). Столбцы матрицы соответствуют ребрам, строки — вершинам. Ненулевое значение в ячейке матрицы указывает связь между вершиной и ребром (их инцидентность). Если связи между вершиной и ребром нет, то в соответствующую ячейку ставится «0».  
В случае ориентированного графа каждой дуге ставится в соответствующем столбце: 1 в строке вершины x и -1 в строке вершины y.  

### Список смежности <a name="basicgraphadjacencylist"></a>  

Способ представления графа в виде коллекции списков вершин. Каждой вершине графа соответствует список, состоящий из «соседей» этой вершины.  
Варианты:  
• использование хеш-таблицы для ассоциации каждой вершины со списком смежных вершин;
• вершины представлены числовым индексом в массиве, каждая ячейка массива ссылается на однонаправленный связанный список соседних вершин;  
• специальные классы вершин и рёбер, каждый объект вершины содержит ссылку на коллекцию рёбер, каждый объект ребра содержит ссылки на исходящую и входящую вершины.

### Список инцидентности <a name="basicgraphincidencelist"></a>  

Список инцидентности похож на список смежности, только с той разницей, что в i-ой строке записываются номера ребер, инцидентных данной i-ой вершине.

### Сравнение структур представления графов <a name="basicgraphstructcomparison"></a>  

| Метод | Mem | Add V | Add E | Remove V | Remove E | Проверка смежн. V |
| :- | :-: | :-: | :-: | :-: | :-: | :-: |
| Матрица смежности<br>(Adjacency matrix) | V^2 | V^2 | 1 | V^2 | 1 | 1 |
| Матрица инцидентности<br>(Incidence matrix) | V*E | V*E | V*E | V*E | V*E | E |
| Список смежности<br>(Adjacency list) | V+E | 1 | 1 | V+E | E | V |
| Список инцидентности<br>(Incidence list) | V+E | 1 | 1 | E | E | E |

### SOLID <a name="arcchsolid"></a>  

Использование принципов SOLID помогает создавать расширяемые и поддерживаемые системы. Принципы SOLID также можно использовать в качестве ориентиров в процессе рефакторинга кода.  

### SRP <a name="archsolidsrp"></a>  

Single-responsibility principle, принцип единственной ответственности. Предполагает проектирование классов, имеющих только одну причину для изменения, позволяет вести проектирование в направлении, противоположном созданию «[Божественных объектов](https://en.wikipedia.org/wiki/God_object)».  

### OCP <a name="archsolidocp"></a>  

Open–closed principle, принцип открытости/закрытости. Классы должны быть закрыты от изменения (чтобы код, опирающийся наэти классы, не нуждался в обновлении), но открыты для расширения (классу можно добавить новое поведение). Вкратце — хочешь изменить поведение класса — не трогай старый код (не считая рефакторинга, т. е. изменение программы без изменения внешнего поведения), добавь новый.  

### LSP <a name="archsolidlsp"></a>

Liskov Substitution Principle, принцип подстановки Барбары Лисков: поведение наследующих классов должно быть ожидаемым для кода, использующего переменную базового класса.  

### ISP <a name="archsolidisp"></a>  

Interface segregation principle, принцип разделения интерфейса. Клиент интерфейса не должен зависить от неиспользуемых методов. В соответствии с принципом ISP рекомендуется создвать минималистичные интерфейсы, содержащие минимальное количество специфичных методов.  

### DIP <a name="archsoliddip"></a>  

Dependency inversion principle, принцип инверсии зависимостей. Модули верхнего уровня не должны обращаться к модулям нижнего уровня напрямую, между ними должна быть «прокладка» из абстракций (т. е. интерфейсов). Причем абстракции не должны зависить от реализаций, реализации должны звисить от абстракций.  

### KISS <a name="archkiss"></a>  

Keep it simple, stupid — принцип проектирования ПО, в соотвтствии с которым простота системы деклариуется как одна из основополагающих ценностей (иногда даже простота объявляется более важной, чем любые другие свойства системы, см. [Worse is Better](https://en.wikipedia.org/wiki/Worse_is_better) Ричарда Гэбриела), одно из практических приложений «[Бритвы Оккама](https://en.wikipedia.org/wiki/Occam%27s_razor)» — не создавай новых сущностей без крайней необходимости.  

### DRY <a name="archdry"></a>  

Don’t repeat yourself (не повторяйся) — принцип, в соответствии с которым изменение любого элемента системы не требует внесения изменений в другие, логически не связанные элементы. Логически же связанные элементы изменяются предсказуемо и единообразно.  

### YAGNI <a name="archyagni"></a>  

You aren't gonna need it (вам это не понадобится) — если в определенном функционале нет потребности прямо здесь и прямо сейчас — не добавляй его. Этим ты не только отнимешь время, необходимое на разработку и тестирование действительного функционала, но и можешь подложить себе мину замедленного действия на будущее, когда контуры развития системы станут более четкими.  

### P vs NP <a name="advancedalgorithmspvsnp"></a>  

Задачи класса P — реально вычислимые задачи ([тезис Кобэма](https://en.wikipedia.org/wiki/Cobham%27s_thesis)), решаются за полиномиальное время.  
NP-полные задачи —  не разрешимы за полиномиальное время, но могут быть сведены к задачам разрешимости (да/нет), которые, в свою очередь, решаются за полиномиальное время.  


### Минимальный вариант <a name="gitflowminimum"></a>

git config --global core.editor "'C:/Program Files/Notepad++/notepad++.exe' -multiInst -notabbar -nosession -noPlugin"  

Создать новую папку  
в папке git init  
добавить файлы  
git add --all  
git commit  
Добавляем в текстовом файле первой строкой англоязычный заголовок коммита, второй и далее строками можно добавить русскоязычное описание. Сохраняем, закрываем.  
git branch --list список веток  
git branch small-update создает новую ветку, переключение на ветку не выполняется  
git checkout small-update переключается на вновь созданную ветку  
Делаем дополнения файлов в новой ветке  
git checkout master переключаемся на ветку master  
git merge small-update сливаем ветки  
git log --graph --full-history --all --color --pretty=format:"%x1b[31m%h%x09%x1b[32m%d%x1b[0m%x20%s"  

Слияние коммитов:  
git rebase  
squash  

### Что почитать  

### C# <a name="bibliographycsharp"></a>

[ECMA-334](https://www.ecma-international.org/wp-content/uploads/ECMA-334_5th_edition_december_2017.pdf)  

Документация на сайте Microsoft и опция «Загрузить pdf»  

### Неструктурированная информация из старых проектов

;Написать список околопрактических задачек, которые я хотел бы решить через LINQ и их решения;2
;"Написание классов, обрабатываемых LINQ; написание собственных методов LINQ";
Структуры данных;Написать свой минисправочник по структурам данных с плюсами и минусами и с условием их выбора;1
;Написать по минипримеру по использованию каждой структуры;
;Написать бенчмарки, показывающие реальные плюсы разных структур;
Параллельность;await, async;1

;System.Threading.Channels;1
;async streams;
;Поставщик-потребитель (Synkro) на Monitor (отдельная от событий ветка);2
;Поставщик-потребитель (Synkro) на AutoResetEvent (отдельная ветка);2
;Поставщик-потребитель (Synkro) на System.Threading.Channels (отдельная ветка);2
;Поставщик-потребитель (Synkro) на async streams (отдельная ветка);
;Развернуть SQL Server;1
;Entity Framework;
;Переключить Trader CAD на работу с SQL;3
NUnit;Просто тесты, моки, стабы;
;Moq;
;Добавить тестов к 2048;1
;Добавить тестов к Synkro;1
;Добавить тестов к TraderCAD;1
;Побриться, постричься, сделать фото для github и habr, разместить фото на github и habr;1
;Приятно оформить репо 2048 (со скриншотами);1
;Приятно оформить репо Synkro (со скриншотами);1
;Обновить резюме, создать репо про себя на github;1
Поиск работы;Разместить резюме на hh;
;Откликнуться на релевантные уфимские вакансии на hh;
;Откликнуться на релевантные удаленные вакансии на hh;
;"Написать на хабр статью ""Играем с LINQ"" с саморекламой";
;"Написать на хабр статью ""Мини-справочник LINQ"" с саморекламой";
;"Написать на хабр статью ""Играем со структурами данных"" с саморекламой";
;"Написать на хабр статью ""Git flow"" с саморекламой";
;"Написать на хабр статью ""Играем с System.Threading"" с саморекламой";

### Неструктурированная информация из старых проектов

2048
- Добавить сложные тесты с моками и стабами
- Serilog
- Изменить работу с appsettings (https://m.habr.com/ru/company/arcadia/blog/514652/)

synkro
- Изменить работу с appsettings (https://m.habr.com/ru/company/arcadia/blog/514652/)
