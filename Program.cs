// See https://aka.ms/new-console-template for more information


//1
using LINQConsoleApp1;

string[] ArrayNameOfClass = new string[]
{
    "yafit",
    "eden",
    "eikva",
   "keren",
   "eaim"
};
List<string> listNames = ArrayNameOfClass.Where(item => item[0] == 'e').ToList();
foreach (string item in listNames)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------------");


//2
int[] ArrayRandomAge = new int[10];
Random RandomAge = new Random();
for (int i = 0; i < ArrayRandomAge.Length; i++)
{
    ArrayRandomAge[i] = RandomAge.Next(1, 30);
    //Console.WriteLine(ArrayRandomAge[i]);
}

var listAge = (from item in ArrayRandomAge
               where item > 20
               select item).ToList();
foreach (int item in listAge)
{
    Console.WriteLine(item);
}

Console.WriteLine("----------------");


//4
Random RandomBook = new Random();

Book[] BooksArray = new Book[] {
new Book("rina","samuey", RandomBook.Next(1,500)),
 new Book("hy", "ayano", RandomBook.Next(1,500)),
 new Book("ya", "samuey", RandomBook.Next(1,500)),
 new Book("aafit", "ayano", RandomBook.Next(1,500)),
  new Book("yarit", "ayano", RandomBook.Next(1,500)),
 new Book("aafity", "samuey", RandomBook.Next(1,500))
};

//5
var listBookOver200Pages = (from item in BooksArray
                            where item.numOfPages > 200
                            select item).ToList();
foreach (var item in listBookOver200Pages)
{

    Console.WriteLine(item.numOfPages);
}

Console.WriteLine("----------------");

//6
var listBookOver4Tavs = (from item in BooksArray
                         where item.writer.Length > 4
                         select item).ToList();
foreach (var item in listBookOver4Tavs)
{
    Console.WriteLine(item.writer);
}

Console.WriteLine("----------------");


////7
var list111 = (from item in BooksArray
            where item.numOfPages < 150
            select item).ToList();
Book books1 = list111.Find(item => item.numOfPages < 150);

Console.WriteLine(books1.numOfPages);

Console.WriteLine("----------------");

//8


var listEndsInCharacterY = (from item in BooksArray
                            where item.bookName[item.bookName.Length - 1] == 'y'
                            select item).ToList();
foreach (var item in listEndsInCharacterY)
{
    Console.WriteLine(item.bookName);
}
Console.WriteLine("----------------");



//9 //10 //


var bookList = (from item in BooksArray
                group item by item.writer);
foreach (var book in bookList)
{
    Console.WriteLine($" Group Name : {book.Key} ");
    foreach (Book item in book)
    {
        Console.WriteLine(item);
    }

    foreach (Book item in book)
    {
        Console.WriteLine(item.bookName);
    }
}

Console.WriteLine("=============");




