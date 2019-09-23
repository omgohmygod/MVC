using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOne
{
    class Product
    {
        private string _name;
        private string _description;
        private int _money;
        // set
        public void SetName(string name)
        {
            _name = name;
        }

        // set
        public void SetMoney(int money)
        {
            _money = money;
        }

        // set
        public void SetDescription(string text)
        {
            _description = text;
        }

        // get
        public string GetName()
        {
            return _name;
        }

        // get
        public int GetMoney()
        {
            return _money;
        }

        // get
        public string GetDescription()
        {
            return _description;
        }
    }
}
