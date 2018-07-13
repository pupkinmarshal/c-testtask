﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleTask
{
    class CD:Disk
    {
        public CD(string name,int price, int content)
        {
            this.name = name;
            this.price = price;
            this.content = getContent(content);
        }
        public string GetInfo()
        {
            return name + " " + price.ToString() + " " + content;
        }
    }
}
