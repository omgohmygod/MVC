using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOne
{
    class ComboComputer : Product
    {
        const string NAME = "套裝電腦";
        private string _class = NAME;
        public ComboComputer(string name, string text, int money)
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
