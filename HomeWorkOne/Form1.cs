using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkOne
{

    public partial class Form1 : Form
    {
        Model _model = new Model();
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        const int FIVE = 5;

        List<string> _dataList = new List<string>();
        int _buttonIndex;
        int _sum = 0;
        public Form1()
        {
            InitializeComponent();
            _model.LoadData();
            InitialDataGridView();
            _buttonAdd.Enabled = false;
        }        

        // 初始化
        private void InitialDataGridView()
        {
            _dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridView1.ReadOnly = true;
            _dataGridView1.RowHeadersVisible = false;
            _dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //add
        private void ButtonAddClick(object sender, EventArgs e)
        {
            _dataGridView1.Rows.Add(_dataList[0], _dataList[1], _dataList[TWO]);
            _sum = _model.Add(_sum, int.Parse(_dataList[TWO]));
            _labelMoneySum.Text = _sum.ToString();
        }

        // click
        private void BoardOneClick(object sender, EventArgs e)
        {
            _buttonAdd.Enabled = true;
            _buttonIndex = 0;
            _dataList = _model.GetData(_tabProduct.SelectedIndex, _buttonIndex);
            _richTextBox.Text = _dataList[THREE];
            _labelMoney.Text = _dataList[TWO];
        }

        // click
        private void BoardTwoClick(object sender, EventArgs e)
        {
            _buttonAdd.Enabled = true;
            _buttonIndex = 1;
            _dataList = _model.GetData(_tabProduct.SelectedIndex, _buttonIndex);
            _richTextBox.Text = _dataList[THREE];
            _labelMoney.Text = _dataList[TWO];
        }

        // click
        private void BoardThreeClick(object sender, EventArgs e)
        {
            _buttonAdd.Enabled = true;
            _buttonIndex = TWO;
            _dataList = _model.GetData(_tabProduct.SelectedIndex, _buttonIndex);
            _richTextBox.Text = _dataList[THREE];
            _labelMoney.Text = _dataList[TWO];
        }

        // click
        private void BoardFourClick(object sender, EventArgs e)
        {
            _buttonAdd.Enabled = true;
            _buttonIndex = THREE;
            _dataList = _model.GetData(_tabProduct.SelectedIndex, _buttonIndex);
            _richTextBox.Text = _dataList[THREE];
            _labelMoney.Text = _dataList[TWO];
        }

        // click
        private void BoardFiveClick(object sender, EventArgs e)
        {
            _buttonAdd.Enabled = true;
            _buttonIndex = FOUR;
            _dataList = _model.GetData(_tabProduct.SelectedIndex, _buttonIndex);
            _richTextBox.Text = _dataList[THREE];
            _labelMoney.Text = _dataList[TWO];
        }

        // click
        private void BoardSixClick(object sender, EventArgs e)
        {
            _buttonAdd.Enabled = true;
            _buttonIndex = FIVE;
            _dataList = _model.GetData(_tabProduct.SelectedIndex, _buttonIndex);
            _richTextBox.Text = _dataList[THREE];
            _labelMoney.Text = _dataList[TWO];
        }

        // changeIndex
        private void ChangeTabIndex(object sender, EventArgs e)
        {
            _buttonAdd.Enabled = false;
            _richTextBox.Text = "";
            _labelMoney.Text = "";
        }
    }
}
