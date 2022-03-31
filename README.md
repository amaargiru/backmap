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
    • [Stateless](#csharpstateless)  
• Архитектурные паттерны 1  
    • [Какой код лучше?](#archwhatbest)  
    • [Выделение интерфейсов](#archinterfaces)  
    • [IoC/DI](#archiocdi)  
        • [Microsoft.Extensions.DependencyInjection](#archmicrosoftextensionsdependencyInjection)  
        • [Autofac](#archautofac)  
    • [SOLID](#arcchsolid)  
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
• [Мутационное тестирование](#mutationtesting)  
    • [Stryker](#mutationtestingstryker)  
• Git flow 2  
    • [Минимальный вариант](#gitflowminimum)  
    • [Ветвление](#gitflowfork)  
    • [Слияние](#gitflowmerge)  
        • [Трехстороннее слияние](#gitflowthreewaymerge)  
        • [WinMerge](#gitflowwinmerge)  
    • [Чистка веток](#gitflowcleanup)  

### Pet-проекты, часть 1

• [Игра 2048](#petprojects2048)  
• [Syncro, программа резервного копирования](#petprojectssyncro)  

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

### SOLID <a name="arcchsolid"></a>

Использование принципов SOLID помогает создавать расширяемые и поддерживаемые системы. Принципы SOLID также можно использовать в качестве ориентиров в процессе рефакторинга кода.

### SRP <a name="archsolidsrp"></a>

Single-responsibility principle, принцип единственной ответственности. 

### OCP <a name="archsolidocp"></a>

Open–closed principle, принцип открытости/закрытости

### LSP <a name="archsolidlsp"></a>
### ISP <a name="archsolidisp"></a>
### DIP <a name="archsoliddip"></a>

### P vs NP <a name="advancedalgorithmspvsnp"></a>

Задачи класса P — реально вычислимые задачи (тезис Кобэма), решаются за полиномиальное время.  
NP-полные задачи —  не разрешимы за полиномиальное время, но могут быть сведены к задачам разрешимости (да/нет), которые, в свою очередь, решаются за полиномиальное время.  

### Что почитать  

### C# <a name="bibliographycsharp"></a>

[ECMA-334](https://www.ecma-international.org/wp-content/uploads/ECMA-334_5th_edition_december_2017.pdf)  

Документация на сайте Microsoft и опция «Загрузить pdf»  

### Неструктурированная информация из старых проектов

Простейшая программа на C#:
using System;
{
	static void Main()
{
int x = 12 * 30;
Console.WriteLine(x);
}
}
Исходный код -> сборка = единица упаковки и развертывания = приложение или библиотека. У приложения есть точка входа Main(), у приложения нет.
Встроенные типы = int, string и т. п.
static - оперирует с самим типом,
не static - оперирует с экземпляром типа.
Типы значений = все числовые типы, char, bool, struct и enum.
uint ~ 4 млрд., соотв. int ~ ±2 млрд. (32 бита).
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
Три операции для работы со значениями null:
1. Операция объединения с null:
int b = a ?? 7;
Если значение слева ≠ null, значение справа не вычисляется.
2. null-условная операция (элвис-операция):
string s = sb?.ToString();
Результатом будет значение или null, исключение никогда не возникает. Если элвис-операция столкнется с null, то прекращает дальнейшие вычисления. Окончательное выражение должно уметь принимать null.
3. Операция присваивания с объединением с null. Операция выполняет присваивание только если переменная не null:
s ??= “Welcome”;
эквивалентно
if (s != null) s = “Welcome”;
Операция объединения с null и элвис-операция хорошо сочетаются:
string s = sb?.ToString() ?? “Empty”;
Пространство имен - область, внутри которой имена типов должны быть уникальными.
Ссылка на объект приводится вверх неявно, вниз - явно.
as приводит вниз, в случае неудачи получаем null вместо исключения (!!! примеры).
is проверяет правильность приведения (!!! примеры).
virtual - override (!!! примеры).
Разница между =, Equals() (стр. 104), ReferenceEquals() и GetHashCode(стр. 104) (!!! разжевать).
Структура vs класс (стр. 105, разжевать !!!).
Структура может быть readonly, тогда все поля автоматически становятся тоже readonly. Можно объявить readonly функцию структуры, тогда на этапе компиляции будет выдаваться ошибка при попытке изменить любое поле.
Модификаторы доступа:
public - полный доступ, неявный доступ для интерфейсов и членов перечисления.
internal - доступ внутри содержащей сборки и в дружественных сборках (помеченных атрибутом сборки InternalsVisibleTo), стандартный доступ для невложенного типа.
private - доступ только внутри содержащего типа, стандартный доступ для членов класса или структуры.
protected - доступ внутри содержащего типа и в его подклассах.
protected internal - объединение доступностей protected и internal (бОльшая доступность), доступ открыт как из содержащей сборки, так и из производных типов.
private protected - пересечение доступностей internal и protected (меньшая доступность), доступ могут иметь только производные типы и только в пределах содержащей сборки.
Подкласс может иметь только такую же или меньшую доступность.
Тип устанавливает верхний предел доступности своих членов.

### Неструктурированная информация из старых проектов 2

__Играем с данными при помощи LINQ__  
  
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

~~~csharp
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
~~~

Но, к счастью, разработчики языка C# заметили, что параллельно с «нормальными» языками программирования вполне себе развиваются и прогрессируют языки структурированных запросов, созданные для управления информацией, содержащейся внутри баз данных, и развиваются, в общем, в правильном направлении. Microsoft решила внедрить свой «как-бы» SQL в язык C#, получилось удачно, так что, например, и [Java](https://stackoverflow.com/questions/1217228/what-is-the-java-equivalent-for-linq)-, и [C++](https://stackoverflow.com/questions/232222/is-there-a-linq-library-for-c)-программисты немного горюют по поводу отсутствия LINQ в соответствующих языках.  
С применением LINQ показанный выше запрос будет выглядеть так:  
!!!  
Или так:  
!!!  
  
__Синтаксис__  
  
Исторически сложилось так, что у запросов LINQ две возможных формы написания: __синтаксис запросов__ (query syntax) и __синтаксис методов__ (method syntax), иногда называемый также __текучим синтаксисом__ (fluent syntax). Два примера выше как раз и написаны с применением разных синтаксисов, но делают абсолютно одно и то же. Далее мы сосредоточимся на синтаксисе методов, так как он: а) имеет больше методов и б) позволяет добавлять методы самостоятельно. Есть кейсы (МГИМО финишд, ага), в которых синтаксис запросов имеет некоторые преимущества, потому что включает, например, ключевое слово let, позволяющее ввести новую переменную прямо посреди запроса или повышенная удобочитаемость длинных запросов. Но в целом, особенно с учетом того, что стандарт [ECMA-334](https://www.ecma-international.org/wp-content/uploads/ECMA-334_5th_edition_december_2017.pdf) недвусмысленно намекает на некоторую «вторичность» синтаксиса запросов (пункт 12.17.3.1, «The C# language does not specify the execution semantics of query expressions. Rather, query expressions are translated into invocations of methods that adhere to the query-expression pattern»), можно рассматривать синтаксис методов как основной, а синтаксис запросов — как вспомогательный.  
### Неструктурированная информация из старых проектов 3

Aggregate Объединяет элементы последовательности, используя входную функцию Пример: перемножение элементов последовательности
Aggregate Объединяет элементы последовательности, используя входную функцию и начальное значение
Aggregate Объединяет элементы последовательности, используя входную функцию, начальное значение и функцию селекции результата
All Проверяет, все ли элементы последовательности удовлетворяют условию. Пример: проверить, все ли элементы последовательности четные
Any Проверяет, содержит ли последовательность хотя бы один элемент. Пример: проверить, что выдаст Any на пустой последовательности
Any Проверяет, содержит ли последовательность хотя бы один элемент, удовлетворяющий условию. Пример: единственное четное число в нечетной последовательности
Append Добавляет значение в конец последовательности, выдает новую последовательность
AsEnumerable Просто говорит компилятору, что нужно использовать метод, относящийся к IEnumerable, а не к, скажем, IQueryable
Average Вычисляет среднее значение
Cast Преобразует коллекции старого типа (non-generic collections) на базе IEnumerable в коллекцию нового типа на базе IEnumerable<T>
Concat Конкатенация двух последовательностей
Contains Проверяет, содержит ли последовательность указанный элемент
Count Возвращает количество элементов
Count Возвращает количество элементов, удовлетворяющих условию
DefaultIfEmpty Возвращает коллекцию с одним элементом по умолчанию, если входная последовательность пуста
Distinct Возвращает только различающиеся элементы последовательности
ElementAt Возвращает элемент последовательности, расположенный по указанному индексу
ElementAtOrDefault Возвращает элемент последовательности, расположенный по указанному индексу или значение по умолчанию
Empty Создает пустую последовательность
Except Возвращает разность двух последовательностей
First Возвращает первый элемент последовательности
First Возвращает первый элемент последовательности, удовлетворяющий условию
FirstOrDefault Возвращает первый элемент последовательности или значение по умолчанию, если последовательность пуста
FirstOrDefault Возвращает первый элемент последовательности, удовлетворяющий условию или значение по умолчанию, если последовательность не содержит ни одного удовлетворяющего условию элемента
GroupBy Разбивает последовательность на подпоследовательности
GroupJoin Устанавливает корреляцию между элементами двух последовательностей на основе равенства ключей и группирует результаты
Intersect Находит пересечение двух последовательностей
Join Устанавливает корреляцию между элементами двух последовательностей на основе равенства ключей
Last Возвращает последний элемент последовательности
Last Возвращает последний элемент последовательности, удовлетворяющий условию
LastOrDefault Возвращает последний элемент последовательности или значение по умолчанию, если ни одного элемента не найдено
LastOrDefault Возвращает последний элемент последовательности, удовлетворяющий условию или значение по умолчанию, если ни одного элемента не найдено
LongCount Возвращает количество элементов типа long
LongCount Возвращает количество элементов типа long, удовлетворяющих условию
Max Возвращает максимальное значение, содержащееся в последовательности
Max Вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение, содержащееся в полученной последовательности
Min Возвращает минимальное значение, содержащееся в последовательности
Min Вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение, содержащееся в полученной последовательности
OfType Преобразует IEnumerable к IEnumerable<T>, отбрасывая элементы с несоответствующим типом
OrderBy Сортирует элементы последовательности в порядке возрастания
OrderByDescending Сортирует элементы последовательности в порядке убывания
Prepend Добавляет значение в начало последовательности, выдает новую последовательность
Range Генерирует последовательность целых чисел в заданном диапазоне
Repeat Генерирует последовательность, содержащую одно повторяющееся значение
Reverse Инвертирует порядок следования элементов последовательности
Select Преобразует последовательность в новую последовательность, возвращая один выходной элемент для каждого входного элемента
SelectMany Преобразует каждый элемент последовательности в новую последовательность и объединяет полученные последовательности в одну последовательность
SequenceEqual Определяет, равны ли две последовательности
Single Возвращает единственный конкретный элемент последовательности
SingleOrDefault Возвращает единственный конкретный элемент последовательности или значение по умолчанию, если такой элемент не найден
Skip Возвращает элементы последовательности за вычетом заданного числа первых элементов
SkipLast Возвращает элементы последовательности за вычетом заданного числа последних элементов
SkipWhile Пропускает элементы последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы
Sum Возвращает сумму последовательности
Take Возвращает заданное число первых элементов
TakeLast Возвращает заданное число последних элементов
TakeWhile Возвращает элементы последовательности, пока они удовлетворяют заданному условию, и затем пропускает оставшиеся элементы
ThenBy Дополнительно сортирует элементы последовательности в порядке возрастания
ThenByDescending Дополнительно сортирует элементы последовательности в порядке убывания
ToArray Преобразует последовательность в массив
ToDictionary Преобразует последовательность в Dictionary
ToHashSet Преобразует последовательность в HashSet
ToList Преобразует последовательность в List
ToLookup Преобразует последовательность в Lookup
Union Возвращает элементы, имеющиеся в обеих входных последовательностях, кроме дубликатов
Where Выполняет фильтрацию последовательности
Zip Возвращает последовательность, содержащую объединенные элементы двух входных последовательностей


### Неструктурированная информация из старых проектов 4

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

### Неструктурированная информация из старых проектов 5

;;Дней
;;
LINQ;Написать свой минисправочник по LINQ: метод, описание;2
;Написать список околопрактических задачек, которые я хотел бы решить через LINQ и их решения;2
;"Написание классов, обрабатываемых LINQ; написание собственных методо LINQ";
;IQueryable;
Структуры данных;Написать свой минисправочник по структурам данных с плюсами и минусами и с условием их выбора;1
;Написать по минипримеру по использованию каждой структуры;
;Написать бенчмарки, показывающие реальные плюсы разных структур;
Git flow;Ветвление;1
;Накопление коммитов;
;Визуализация;
;Чистка ветки;
;Слияние;
;Разрешение конфликтов;
Параллельность;await, async;1
;Monitor, Mutex, Semaphore, AutoResetEvent, ReaderWriterLock;1
;Interlocked, volatile, slim-версии объектов;1
;Параллельное синхронизированное выполнение в 2 потока (ping-pong);1
;Параллельное синхронизированное выполнение на 2 ядрах (ping-pong);
;Параллельное синхронизированное выполнение в 4 потока (mummy-daddy-baby-cat);1
;Параллельное синхронизированное выполнение на 4 ядрах (mummy-daddy-baby-cat);
;System.Threading.Channels;1
;async streams;
;Поставщик-потребитель (Synkro) на Monitor (отдельная от событий ветка);2
;Поставщик-потребитель (Synkro) на AutoResetEvent (отдельная ветка);2
;Поставщик-потребитель (Synkro) на System.Threading.Channels (отдельная ветка);2
;Поставщик-потребитель (Synkro) на async streams (отдельная ветка);
WPF;Придать внешний лоск WPF приложению 2048;2
;Сделать и придать внешний лоск WPF приложению Synkro;4
;Сделать и придать внешний лоск WPF приложению Trader CAD;5
SQL;Основы (Create, Update, Delete, Select, Where, Insert, Drop, Show, Join);1
;Развернуть SQL Server;1
;Entity Framework;
;Переключить Trader CAD на работу с SQL;3
;Финализировать WPF приложение Trader CAD;1
NUnit;Просто тесты, моки, стабы;
;Moq;
;Добавить тестов к 2048;1
;Добавить тестов к Synkro;1
;Добавить тестов к TraderCAD;1
Архитектурные паттерны;SOLID, KISS, DRY, YAGNI своими словами;1
Подготовка к поиску работы;Подготовить шпаргалку;2
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

### Неструктурированная информация из старых проектов 6

2048
- Добавить сложные тесты с моками и стабами
- Документация
	- readme (+ описание игры)
	- скриншот
- Доработать WPF-версию
- Serilog
- Изменить работу с appsettings (https://m.habr.com/ru/company/arcadia/blog/514652/)
- Перевод русскоязычных комментариев на английский

synkro
- Тесты простые
- Добавить сложные тесты с моками и стабами
- Документация
	- readme
	- скриншот
- Попробовать сделать удаление файлов более "зубастым", возможно, сейчас не умеет удалять read-only файлы
- Перейти с простого лога на Serilog
- Попробовать сделать работу с файлами и папками более интерактивной
- Сделать WPF-версию
- Сделать работу через интерфейсы
- Перейти на System.Threading.Channels (https://habr.com/ru/post/508726/) или на System.Threading.Tasks.Dataflow(https://docs.microsoft.com/ru-ru/dotnet/standard/parallel-programming/how-to-implement-a-producer-consumer-dataflow-pattern)
- Изменить работу с appsettings (https://m.habr.com/ru/company/arcadia/blog/514652/)
- Цветная консоль

sharpshort
- добавить еще один метод
- readme

### Неструктурированная информация из старых проектов 7

Игра 2048.

На случай, если вы никогда не играли в игру 2048, ниже приведены ее несложные правила, взятые с ru.wikipedia.org/wiki/2048_(игра):
- В каждом раунде появляется плитка номинала «2» (с вероятностью 90 %) или «4» (с вероятностью 10 %).
- Нажатием на клавиатуре кнопок со стрелками игрок может сбросить все плитки игрового поля в одну из 4 сторон. Если при сбрасывании две плитки одного номинала соседствуют друг с другом, то они объединяются в одну, номинал которой равен сумме соединившихся плиток. После каждого хода на одном из свободных полей появляется новая плитка номиналом «2» или «4». Если при нажатии кнопки местоположение плиток или их номинал не изменится, то ход не совершается.
- Если в одной строке или в одном столбце находится более двух плиток одного номинала, то при сбрасывании они начинают объединяться с той стороны, в которую происходит движение. Например, находящиеся в одной строке плитки (4, 4, 4) после хода влево превратятся в (8, 4), а после хода вправо — в (4, 8). Данная обработка неоднозначности позволяет более точно формировать стратегию игры.
- За каждое объединение игровые очки увеличиваются на номинал получившейся плитки.
- Игра заканчивается поражением, если после очередного хода невозможно совершить действие.
