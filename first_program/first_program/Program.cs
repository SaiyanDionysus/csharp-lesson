/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//переменные и константы
string name;
name = "Tom";

Console.WriteLine(name);

name = "Bob";
Console.WriteLine(name);

//константы
const string NAME = "Tom"; // константе можно присвоить только одно значение

//литералы (true/false)
Console.WriteLine(true);
Console.WriteLine(false);

//целочисленные литералы
Console.WriteLine(-11);
Console.WriteLine(5);
Console.WriteLine(505);

//двоичная запись
Console.WriteLine(0b1011); // 11
Console.WriteLine(0b100001); // 33

Console.WriteLine(0x0A); // 10
Console.WriteLine(0xFF); // 10
Console.WriteLine(0xA1); // 10

//символьные литералы

Console.WriteLine('2');
Console.WriteLine('A');
Console.WriteLine('T');

// '\n' - перевод строки
// '\t' - табуляция
// '\\' - слеш

//ТИПЫ ДАННЫХ
string name_n = "Tom";
int age = 33;
bool isEmployed = false;
double weight = 78.65;

Console.WriteLine($"Имя: {name_n}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работает: {isEmployed}");

//использование системных типов
int a = 4;
System.Int32 b = 4;
Console.WriteLine(a);
Console.WriteLine(b);

//использование суффиксов
//для типов float, decimal, uint, long, ulong используются суффиксы
F,f
 M, m; U, L, UL соответственно

//неявная типизация
var hello = "hello to world";
var c = 20;
Console.WriteLine(c);
Console.WriteLine(hello);


//консольный ввод-вывод
Console.Write("Введите свое имя: ");
string nameee = Console.ReadLine();
Console.WriteLine($"Hi, {nameee}");

Convert.ToInt32()(преобразует к типу int)

Convert.ToDouble()(преобразует к типу double)

Convert.ToDecimal()(преобразует к типу decimal)

Console.Write("Введите свое имя: ");
string name2 = Console.ReadLine();

Console.Write("Введите возраст: ");
int age2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name2} Возраст: {age2} Рсот: {height} Зарплата: {salary} ");

//логические операции
int x1 = 2;
int y1 = 5;
Console.WriteLine(x1 & y1);

int x2 = 2; //010
int y2 = 5;//101
Console.WriteLine(x1 | y1);

int x3 = 45;
int key = 102;

int encrypt = x3 ^ key;
Console.WriteLine($"Зашифрованное число: {encrypt}");

int decrypt = encrypt ^ key;
Console.WriteLine($"Расшифрованное число: {decrypt}");


//операции сдвига
int a4 = 16;
int b4 = 2;
int c4 = a << b;

Console.WriteLine($"Зашифрованное число: {c})");

int d4 = a >> b;
Console.WriteLine($"Зашифрованное число: {d4}");

//
int value1 = 3;
int value2 = 2;
int value3 = 1;

int result = 0b0000_0000;
result = result | value1;

result = result << 2;

result = result | value2;

result = result | value3;

Console.WriteLine(result);

//операции присваивания

int a5 = 10;
a += 10;
a -= 4;
a *= 2;
a /= 8;
a <<= 4;
a >>= 2;

//конструкция if.. else и тенарная операция

*/
//задача №1
Console.WriteLine("Введите числа от 1 до 5");
Console.Write("Ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number % 10;
int b = number / 10;


void detectFinger(int hand) 
{
    switch (hand)
    {
        case 1:
            Console.WriteLine("Большой");
            break;
        case 2:
            Console.WriteLine("Указательный");
            break;
        case 3:
            Console.WriteLine("Средний");
            break;
        case 4:
            Console.WriteLine("Безымянный");
            break;
        case 5:
            Console.WriteLine("Мезинец");
            break;
    }
}
detectFinger(a);
detectFinger(b);


//методы

