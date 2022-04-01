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
                //f1 += 1; // Действие инструкции и оператора checked не распространяется на decimal (а также на BigInteger и Complex). Переполнение будет вызвано средствами проверки, встроенными в decimal
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