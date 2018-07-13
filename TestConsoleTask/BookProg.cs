﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleTask
{
    class BookProg:Book
    {
        //Книги и диски.Книги бывают по программированию, кулинарии и эзотерике.У всех
        //товаров есть название (строка), цена (число) и штрих-код (строка). У всех книг –
        //количество страниц (число). У книг по программированию – язык программирования
        //(строка). У книг по кулинарии – основной ингредиент (строка). У книг по
        //эзотерике – минимальный возраст читателя (число). Диски бывают CD и DVD.
        //Независимо от типа диска, его содержимым может быть: музыка, видео, ПО.
        private string language;
        public BookProg(string name, int price, int pages, string language)
        {
            this.name = name;
            this.price = price;
            this.pages = pages;
            this.language = language;
        }
        public string GetInfo()
        {
            return name + " " + price.ToString() + " " + pages.ToString() + " " + language;
        }
    }
}
