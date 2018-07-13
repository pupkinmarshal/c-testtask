using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleTask
{
    class BookCook:Book
    {
        //Книги и диски.Книги бывают по программированию, кулинарии и эзотерике.У всех
        //товаров есть название (строка), цена (число) и штрих-код (строка). У всех книг –
        //количество страниц (число). У книг по программированию – язык программирования
        //(строка). У книг по кулинарии – основной ингредиент (строка). У книг по
        //эзотерике – минимальный возраст читателя (число). Диски бывают CD и DVD.
        //Независимо от типа диска, его содержимым может быть: музыка, видео, ПО.
        private string ingridient;
        public BookCook(string name, int price,int pages, string ingridient)
        {
            this.name = name;
            this.price = price;
            this.pages = pages;
            this.ingridient = ingridient;
        }
        public string GetInfo()
        {
            return name + " " + price.ToString() +" "+pages.ToString()+" " + ingridient;
        }
    }
}
