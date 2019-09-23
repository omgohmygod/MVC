using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOne
{
    class Disk : Product
    {
        const string NAME = "硬碟";
        private string _class = NAME;
        public Disk(string name, string text, int money)
        {
            SetName(name);
            SetDescription(text);
            SetMoney(money);
        }
        //回傳Class
        public string GetClass()
        {
            return _class;
        }
    }
}
