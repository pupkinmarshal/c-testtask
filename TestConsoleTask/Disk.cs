using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleTask
{
    class Disk : Item
    {
        private enum Content { music, video, program };
        protected string content;
        protected string getContent(int content)
        {
            if (content >= 0 && content <= 2)
                return ((Content)content).ToString();
            else
                return "Invalid value";
        }
    }
}
