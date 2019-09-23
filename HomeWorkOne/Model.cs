using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOne
{
    class Model
    {
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        const int FIVE = 5;
        const int BUTTON = 6;
        const int COST = 4000;
        const string BOARD_NAME = "主機板";
        const string CARD_NAME = "顯示卡";
        const string DISK_NAME = "硬碟";
        const string CORE_NAME = "CPU";
        const string COMPUTER_NAME = "套裝電腦";
        const string MEMORY_NAME = "記憶體";
        const string COUNT = "我是第";
        const string TYPE = "個";
        private List<Board> _boardList = new List<Board>();
        private List<Core> _coreList = new List<Core>();
        private List<Disk> _diskList = new List<Disk>();
        private List<Memory> _memoryList = new List<Memory>();
        private List<ComboComputer> _comboComputerList = new List<ComboComputer>();
        private List<DisplayCard> _displayCardList = new List<DisplayCard>();

        public List<Core> CoreList
        {
            get
            {
                return _coreList;
            }
            
        }
        public List<Disk> DiskList
        {
            get
            {
                return _diskList;
            }
        }
        public List<Board> BoardList
        {
            get
            {
                return _boardList;
            }
           
        }
        public List<Memory> MemoryList
        {
            get
            {
                return _memoryList;
            }
        }
        public List<ComboComputer> ComboComputerList
        {
            get
            {
                return _comboComputerList;
            }
        }
        public List<DisplayCard> DisplayCardList
        {
            get
            {
                return _displayCardList;
            }
        }

        // load
        public void LoadData()
        {
            for (int i = 0; i < BUTTON; i++)
            {
                Board _newBoard = new Board(BOARD_NAME + (i + 1), COUNT + (i + 1) + TYPE + BOARD_NAME, (i + 1) * COST * TWO);
                Core _newCpu = new Core(CORE_NAME + (i + 1), COUNT + (i + 1) + TYPE + CORE_NAME, (i + 1) * COST * THREE);
                Disk _newDisk = new Disk(DISK_NAME + (i + 1), COUNT + (i + 1) + TYPE + DISK_NAME, (i + 1) * COST);
                Memory _newMemory = new Memory(MEMORY_NAME + (i + 1), COUNT + (i + 1) + TYPE + MEMORY_NAME, (i + 1) * COST);
                DisplayCard _newDisplayCard = new DisplayCard(CARD_NAME + (i + 1), COUNT + (i + 1) + TYPE + CARD_NAME, (i + 1) * COST * FOUR);
                ComboComputer _newComboComputer = new ComboComputer(COMPUTER_NAME + (i + 1), COUNT + (i + 1) + TYPE + COMPUTER_NAME, (i + 1) * COST * FIVE);

                BoardList.Add(_newBoard);
                CoreList.Add(_newCpu);
                DiskList.Add(_newDisk);
                MemoryList.Add(_newMemory);
                DisplayCardList.Add(_newDisplayCard);
                ComboComputerList.Add(_newComboComputer);
            }
        }

        // get
        public List<string> GetData(int tabIndex, int buttonIndex)
        {
            List<string> item = new List<string>();
            if (tabIndex == 0)
                item = GetBoard(buttonIndex);
            else if (tabIndex == 1)
                item = GetCore(buttonIndex);
            else if (tabIndex == TWO)
                item = GetMemory(buttonIndex);
            else if (tabIndex == THREE)
                item = GetDisk(buttonIndex);
            else if (tabIndex == FOUR)
                item = GetCard(buttonIndex);
            else if (tabIndex == FIVE)
                item = GetComputer(buttonIndex);
            return item;
        }

        // get
        public List<string> GetBoard(int buttonIndex)
        {
            List<string> item = new List<string>();
            item.Add(_boardList[buttonIndex].GetName());
            item.Add(_boardList[buttonIndex].GetClass());
            item.Add(_boardList[buttonIndex].GetMoney().ToString());
            item.Add(_boardList[buttonIndex].GetDescription());
            return item;
        }

        // get
        public List<string> GetCard(int buttonIndex)
        {
            List<string> item = new List<string>();
            item.Add(_displayCardList[buttonIndex].GetName());
            item.Add(_displayCardList[buttonIndex].GetClass());
            item.Add(_displayCardList[buttonIndex].GetMoney().ToString());
            item.Add(_displayCardList[buttonIndex].GetDescription());
            return item;
        }

        // get
        public List<string> GetCore(int buttonIndex)
        {
            List<string> item = new List<string>();
            item.Add(_coreList[buttonIndex].GetName());
            item.Add(_coreList[buttonIndex].GetClass());
            item.Add(_coreList[buttonIndex].GetMoney().ToString());
            item.Add(_coreList[buttonIndex].GetDescription());
            return item;
        }

        // get
        public List<string> GetMemory(int buttonIndex)
        {
            List<string> item = new List<string>();
            item.Add(_memoryList[buttonIndex].GetName());
            item.Add(_memoryList[buttonIndex].GetClass());
            item.Add(_memoryList[buttonIndex].GetMoney().ToString());
            item.Add(_memoryList[buttonIndex].GetDescription());
            return item;
        }

        // get
        public List<string> GetComputer(int buttonIndex)
        {
            List<string> item = new List<string>();
            item.Add(_comboComputerList[buttonIndex].GetName());
            item.Add(_comboComputerList[buttonIndex].GetClass());
            item.Add(_comboComputerList[buttonIndex].GetMoney().ToString());
            item.Add(_comboComputerList[buttonIndex].GetDescription());
            return item;
        }

        // get
        public List<string> GetDisk(int buttonIndex)
        {
            List<string> item = new List<string>();
            item.Add(_diskList[buttonIndex].GetName());
            item.Add(_diskList[buttonIndex].GetClass());
            item.Add(_diskList[buttonIndex].GetMoney().ToString());
            item.Add(_diskList[buttonIndex].GetDescription());
            return item;
        }

        // add
        public int Add(int sum, int money)
        {
            sum += money;
            return sum;
        }
    }
}
