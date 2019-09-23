namespace HomeWorkOne
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._groupBoxProduct = new System.Windows.Forms.GroupBox();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._groupBoxInformation = new System.Windows.Forms.GroupBox();
            this._labelMoney = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._tabProduct = new System.Windows.Forms.TabControl();
            this._tabBoard = new System.Windows.Forms.TabPage();
            this._boardSix = new System.Windows.Forms.Button();
            this._boardFive = new System.Windows.Forms.Button();
            this._boardFour = new System.Windows.Forms.Button();
            this._boardThree = new System.Windows.Forms.Button();
            this._boardTwo = new System.Windows.Forms.Button();
            this._boardOne = new System.Windows.Forms.Button();
            this._tabCore = new System.Windows.Forms.TabPage();
            this._coreSix = new System.Windows.Forms.Button();
            this._coreFive = new System.Windows.Forms.Button();
            this._coreFour = new System.Windows.Forms.Button();
            this._coreThree = new System.Windows.Forms.Button();
            this._coreTwo = new System.Windows.Forms.Button();
            this._coreOne = new System.Windows.Forms.Button();
            this._tabMemory = new System.Windows.Forms.TabPage();
            this._memorySix = new System.Windows.Forms.Button();
            this._memoryFive = new System.Windows.Forms.Button();
            this._memoryFour = new System.Windows.Forms.Button();
            this._memoryThree = new System.Windows.Forms.Button();
            this._memoryTwo = new System.Windows.Forms.Button();
            this._memoryOne = new System.Windows.Forms.Button();
            this._tabDisk = new System.Windows.Forms.TabPage();
            this._diskSix = new System.Windows.Forms.Button();
            this._diskFive = new System.Windows.Forms.Button();
            this._diskFour = new System.Windows.Forms.Button();
            this._diskThree = new System.Windows.Forms.Button();
            this._diskTwo = new System.Windows.Forms.Button();
            this._diskOne = new System.Windows.Forms.Button();
            this._tabDisplayCard = new System.Windows.Forms.TabPage();
            this._displaySix = new System.Windows.Forms.Button();
            this._displayFive = new System.Windows.Forms.Button();
            this._displayFour = new System.Windows.Forms.Button();
            this._displayThree = new System.Windows.Forms.Button();
            this._displayTwo = new System.Windows.Forms.Button();
            this._displayOne = new System.Windows.Forms.Button();
            this._tabComboComputer = new System.Windows.Forms.TabPage();
            this._comboSix = new System.Windows.Forms.Button();
            this._comboFive = new System.Windows.Forms.Button();
            this._comboFour = new System.Windows.Forms.Button();
            this._comboThree = new System.Windows.Forms.Button();
            this._comboTwo = new System.Windows.Forms.Button();
            this._comboOne = new System.Windows.Forms.Button();
            this._dataGridView1 = new System.Windows.Forms.DataGridView();
            this._gridViewProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._gridViewProductClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._gridViewProductCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._label2 = new System.Windows.Forms.Label();
            this._labelMoneySum = new System.Windows.Forms.Label();
            this._groupBoxProduct.SuspendLayout();
            this._groupBoxInformation.SuspendLayout();
            this._tabProduct.SuspendLayout();
            this._tabBoard.SuspendLayout();
            this._tabCore.SuspendLayout();
            this._tabMemory.SuspendLayout();
            this._tabDisk.SuspendLayout();
            this._tabDisplayCard.SuspendLayout();
            this._tabComboComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _groupBoxProduct
            // 
            this._groupBoxProduct.Controls.Add(this._buttonAdd);
            this._groupBoxProduct.Controls.Add(this._groupBoxInformation);
            this._groupBoxProduct.Controls.Add(this._tabProduct);
            this._groupBoxProduct.Location = new System.Drawing.Point(12, 12);
            this._groupBoxProduct.Name = "_groupBoxProduct";
            this._groupBoxProduct.Size = new System.Drawing.Size(595, 641);
            this._groupBoxProduct.TabIndex = 0;
            this._groupBoxProduct.TabStop = false;
            this._groupBoxProduct.Text = "商品";
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(489, 597);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(93, 38);
            this._buttonAdd.TabIndex = 4;
            this._buttonAdd.Text = "加入";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // _groupBoxInformation
            // 
            this._groupBoxInformation.Controls.Add(this._labelMoney);
            this._groupBoxInformation.Controls.Add(this._label1);
            this._groupBoxInformation.Controls.Add(this._richTextBox);
            this._groupBoxInformation.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._groupBoxInformation.Location = new System.Drawing.Point(10, 398);
            this._groupBoxInformation.Name = "_groupBoxInformation";
            this._groupBoxInformation.Size = new System.Drawing.Size(572, 182);
            this._groupBoxInformation.TabIndex = 3;
            this._groupBoxInformation.TabStop = false;
            this._groupBoxInformation.Text = "商品介紹";
            // 
            // _labelMoney
            // 
            this._labelMoney.AutoSize = true;
            this._labelMoney.Location = new System.Drawing.Point(481, 155);
            this._labelMoney.Name = "_labelMoney";
            this._labelMoney.Size = new System.Drawing.Size(0, 24);
            this._labelMoney.TabIndex = 4;
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._label1.Location = new System.Drawing.Point(423, 155);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(52, 24);
            this._label1.TabIndex = 3;
            this._label1.Text = "單價:";
            // 
            // _richTextBox
            // 
            this._richTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._richTextBox.Location = new System.Drawing.Point(6, 31);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(290, 131);
            this._richTextBox.TabIndex = 2;
            this._richTextBox.Text = "";
            // 
            // _tabProduct
            // 
            this._tabProduct.Controls.Add(this._tabBoard);
            this._tabProduct.Controls.Add(this._tabCore);
            this._tabProduct.Controls.Add(this._tabMemory);
            this._tabProduct.Controls.Add(this._tabDisk);
            this._tabProduct.Controls.Add(this._tabDisplayCard);
            this._tabProduct.Controls.Add(this._tabComboComputer);
            this._tabProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this._tabProduct.Location = new System.Drawing.Point(3, 18);
            this._tabProduct.Name = "_tabProduct";
            this._tabProduct.SelectedIndex = 0;
            this._tabProduct.Size = new System.Drawing.Size(589, 360);
            this._tabProduct.TabIndex = 0;
            this._tabProduct.SelectedIndexChanged += new System.EventHandler(this.ChangeTabIndex);
            // 
            // _tabBoard
            // 
            this._tabBoard.Controls.Add(this._boardSix);
            this._tabBoard.Controls.Add(this._boardFive);
            this._tabBoard.Controls.Add(this._boardFour);
            this._tabBoard.Controls.Add(this._boardThree);
            this._tabBoard.Controls.Add(this._boardTwo);
            this._tabBoard.Controls.Add(this._boardOne);
            this._tabBoard.Location = new System.Drawing.Point(4, 22);
            this._tabBoard.Name = "_tabBoard";
            this._tabBoard.Padding = new System.Windows.Forms.Padding(3);
            this._tabBoard.Size = new System.Drawing.Size(581, 334);
            this._tabBoard.TabIndex = 0;
            this._tabBoard.Text = "主機板";
            this._tabBoard.UseVisualStyleBackColor = true;
            // 
            // _boardSix
            // 
            this._boardSix.Location = new System.Drawing.Point(392, 162);
            this._boardSix.Name = "_boardSix";
            this._boardSix.Size = new System.Drawing.Size(180, 150);
            this._boardSix.TabIndex = 5;
            this._boardSix.Text = "button6";
            this._boardSix.UseVisualStyleBackColor = true;
            this._boardSix.Click += new System.EventHandler(this.BoardSixClick);
            // 
            // _boardFive
            // 
            this._boardFive.Location = new System.Drawing.Point(200, 162);
            this._boardFive.Name = "_boardFive";
            this._boardFive.Size = new System.Drawing.Size(180, 150);
            this._boardFive.TabIndex = 4;
            this._boardFive.Text = "button5";
            this._boardFive.UseVisualStyleBackColor = true;
            this._boardFive.Click += new System.EventHandler(this.BoardFiveClick);
            // 
            // _boardFour
            // 
            this._boardFour.Location = new System.Drawing.Point(6, 162);
            this._boardFour.Name = "_boardFour";
            this._boardFour.Size = new System.Drawing.Size(180, 150);
            this._boardFour.TabIndex = 3;
            this._boardFour.Text = "button4";
            this._boardFour.UseVisualStyleBackColor = true;
            this._boardFour.Click += new System.EventHandler(this.BoardFourClick);
            // 
            // _boardThree
            // 
            this._boardThree.Location = new System.Drawing.Point(392, 6);
            this._boardThree.Name = "_boardThree";
            this._boardThree.Size = new System.Drawing.Size(180, 150);
            this._boardThree.TabIndex = 2;
            this._boardThree.Text = "button3";
            this._boardThree.UseVisualStyleBackColor = true;
            this._boardThree.Click += new System.EventHandler(this.BoardThreeClick);
            // 
            // _boardTwo
            // 
            this._boardTwo.Location = new System.Drawing.Point(200, 6);
            this._boardTwo.Name = "_boardTwo";
            this._boardTwo.Size = new System.Drawing.Size(180, 150);
            this._boardTwo.TabIndex = 1;
            this._boardTwo.Text = "button2";
            this._boardTwo.UseVisualStyleBackColor = true;
            this._boardTwo.Click += new System.EventHandler(this.BoardTwoClick);
            // 
            // _boardOne
            // 
            this._boardOne.Location = new System.Drawing.Point(6, 6);
            this._boardOne.Name = "_boardOne";
            this._boardOne.Size = new System.Drawing.Size(180, 150);
            this._boardOne.TabIndex = 0;
            this._boardOne.Text = "button1";
            this._boardOne.UseVisualStyleBackColor = true;
            this._boardOne.Click += new System.EventHandler(this.BoardOneClick);
            // 
            // _tabCore
            // 
            this._tabCore.Controls.Add(this._coreSix);
            this._tabCore.Controls.Add(this._coreFive);
            this._tabCore.Controls.Add(this._coreFour);
            this._tabCore.Controls.Add(this._coreThree);
            this._tabCore.Controls.Add(this._coreTwo);
            this._tabCore.Controls.Add(this._coreOne);
            this._tabCore.Location = new System.Drawing.Point(4, 22);
            this._tabCore.Name = "_tabCore";
            this._tabCore.Padding = new System.Windows.Forms.Padding(3);
            this._tabCore.Size = new System.Drawing.Size(581, 334);
            this._tabCore.TabIndex = 1;
            this._tabCore.Text = "CPU";
            this._tabCore.UseVisualStyleBackColor = true;
            // 
            // _coreSix
            // 
            this._coreSix.Location = new System.Drawing.Point(378, 162);
            this._coreSix.Name = "_coreSix";
            this._coreSix.Size = new System.Drawing.Size(180, 150);
            this._coreSix.TabIndex = 11;
            this._coreSix.Text = "button6";
            this._coreSix.UseVisualStyleBackColor = true;
            this._coreSix.Click += new System.EventHandler(this.BoardSixClick);
            // 
            // _coreFive
            // 
            this._coreFive.Location = new System.Drawing.Point(192, 162);
            this._coreFive.Name = "_coreFive";
            this._coreFive.Size = new System.Drawing.Size(180, 150);
            this._coreFive.TabIndex = 10;
            this._coreFive.Text = "button6";
            this._coreFive.UseVisualStyleBackColor = true;
            this._coreFive.Click += new System.EventHandler(this.BoardFiveClick);
            // 
            // _coreFour
            // 
            this._coreFour.Location = new System.Drawing.Point(6, 162);
            this._coreFour.Name = "_coreFour";
            this._coreFour.Size = new System.Drawing.Size(180, 150);
            this._coreFour.TabIndex = 9;
            this._coreFour.Text = "button6";
            this._coreFour.UseVisualStyleBackColor = true;
            this._coreFour.Click += new System.EventHandler(this.BoardFourClick);
            // 
            // _coreThree
            // 
            this._coreThree.Location = new System.Drawing.Point(378, 6);
            this._coreThree.Name = "_coreThree";
            this._coreThree.Size = new System.Drawing.Size(180, 150);
            this._coreThree.TabIndex = 8;
            this._coreThree.Text = "button6";
            this._coreThree.UseVisualStyleBackColor = true;
            this._coreThree.Click += new System.EventHandler(this.BoardThreeClick);
            // 
            // _coreTwo
            // 
            this._coreTwo.Location = new System.Drawing.Point(192, 6);
            this._coreTwo.Name = "_coreTwo";
            this._coreTwo.Size = new System.Drawing.Size(180, 150);
            this._coreTwo.TabIndex = 7;
            this._coreTwo.Text = "button6";
            this._coreTwo.UseVisualStyleBackColor = true;
            this._coreTwo.Click += new System.EventHandler(this.BoardTwoClick);
            // 
            // _coreOne
            // 
            this._coreOne.Location = new System.Drawing.Point(6, 6);
            this._coreOne.Name = "_coreOne";
            this._coreOne.Size = new System.Drawing.Size(180, 150);
            this._coreOne.TabIndex = 6;
            this._coreOne.Text = "button6";
            this._coreOne.UseVisualStyleBackColor = true;
            this._coreOne.Click += new System.EventHandler(this.BoardOneClick);
            // 
            // _tabMemory
            // 
            this._tabMemory.Controls.Add(this._memorySix);
            this._tabMemory.Controls.Add(this._memoryFive);
            this._tabMemory.Controls.Add(this._memoryFour);
            this._tabMemory.Controls.Add(this._memoryThree);
            this._tabMemory.Controls.Add(this._memoryTwo);
            this._tabMemory.Controls.Add(this._memoryOne);
            this._tabMemory.Location = new System.Drawing.Point(4, 22);
            this._tabMemory.Name = "_tabMemory";
            this._tabMemory.Padding = new System.Windows.Forms.Padding(3);
            this._tabMemory.Size = new System.Drawing.Size(581, 334);
            this._tabMemory.TabIndex = 2;
            this._tabMemory.Text = "記憶體";
            this._tabMemory.UseVisualStyleBackColor = true;
            // 
            // _memorySix
            // 
            this._memorySix.Location = new System.Drawing.Point(378, 162);
            this._memorySix.Name = "_memorySix";
            this._memorySix.Size = new System.Drawing.Size(180, 150);
            this._memorySix.TabIndex = 12;
            this._memorySix.Text = "button6";
            this._memorySix.UseVisualStyleBackColor = true;
            this._memorySix.Click += new System.EventHandler(this.BoardSixClick);
            // 
            // _memoryFive
            // 
            this._memoryFive.Location = new System.Drawing.Point(192, 162);
            this._memoryFive.Name = "_memoryFive";
            this._memoryFive.Size = new System.Drawing.Size(180, 150);
            this._memoryFive.TabIndex = 11;
            this._memoryFive.Text = "button6";
            this._memoryFive.UseVisualStyleBackColor = true;
            this._memoryFive.Click += new System.EventHandler(this.BoardFiveClick);
            // 
            // _memoryFour
            // 
            this._memoryFour.Location = new System.Drawing.Point(6, 162);
            this._memoryFour.Name = "_memoryFour";
            this._memoryFour.Size = new System.Drawing.Size(180, 150);
            this._memoryFour.TabIndex = 10;
            this._memoryFour.Text = "button6";
            this._memoryFour.UseVisualStyleBackColor = true;
            this._memoryFour.Click += new System.EventHandler(this.BoardFourClick);
            // 
            // _memoryThree
            // 
            this._memoryThree.Location = new System.Drawing.Point(378, 6);
            this._memoryThree.Name = "_memoryThree";
            this._memoryThree.Size = new System.Drawing.Size(180, 150);
            this._memoryThree.TabIndex = 9;
            this._memoryThree.Text = "button6";
            this._memoryThree.UseVisualStyleBackColor = true;
            this._memoryThree.Click += new System.EventHandler(this.BoardThreeClick);
            // 
            // _memoryTwo
            // 
            this._memoryTwo.Location = new System.Drawing.Point(192, 6);
            this._memoryTwo.Name = "_memoryTwo";
            this._memoryTwo.Size = new System.Drawing.Size(180, 150);
            this._memoryTwo.TabIndex = 8;
            this._memoryTwo.Text = "button6";
            this._memoryTwo.UseVisualStyleBackColor = true;
            this._memoryTwo.Click += new System.EventHandler(this.BoardTwoClick);
            // 
            // _memoryOne
            // 
            this._memoryOne.Location = new System.Drawing.Point(6, 6);
            this._memoryOne.Name = "_memoryOne";
            this._memoryOne.Size = new System.Drawing.Size(180, 150);
            this._memoryOne.TabIndex = 7;
            this._memoryOne.Text = "button6";
            this._memoryOne.UseVisualStyleBackColor = true;
            this._memoryOne.Click += new System.EventHandler(this.BoardOneClick);
            // 
            // _tabDisk
            // 
            this._tabDisk.Controls.Add(this._diskSix);
            this._tabDisk.Controls.Add(this._diskFive);
            this._tabDisk.Controls.Add(this._diskFour);
            this._tabDisk.Controls.Add(this._diskThree);
            this._tabDisk.Controls.Add(this._diskTwo);
            this._tabDisk.Controls.Add(this._diskOne);
            this._tabDisk.Location = new System.Drawing.Point(4, 22);
            this._tabDisk.Name = "_tabDisk";
            this._tabDisk.Padding = new System.Windows.Forms.Padding(3);
            this._tabDisk.Size = new System.Drawing.Size(581, 334);
            this._tabDisk.TabIndex = 3;
            this._tabDisk.Text = "硬碟";
            this._tabDisk.UseVisualStyleBackColor = true;
            // 
            // _diskSix
            // 
            this._diskSix.Location = new System.Drawing.Point(378, 162);
            this._diskSix.Name = "_diskSix";
            this._diskSix.Size = new System.Drawing.Size(180, 150);
            this._diskSix.TabIndex = 12;
            this._diskSix.Text = "button6";
            this._diskSix.UseVisualStyleBackColor = true;
            this._diskSix.Click += new System.EventHandler(this.BoardSixClick);
            // 
            // _diskFive
            // 
            this._diskFive.Location = new System.Drawing.Point(192, 162);
            this._diskFive.Name = "_diskFive";
            this._diskFive.Size = new System.Drawing.Size(180, 150);
            this._diskFive.TabIndex = 11;
            this._diskFive.Text = "button6";
            this._diskFive.UseVisualStyleBackColor = true;
            this._diskFive.Click += new System.EventHandler(this.BoardFiveClick);
            // 
            // _diskFour
            // 
            this._diskFour.Location = new System.Drawing.Point(6, 162);
            this._diskFour.Name = "_diskFour";
            this._diskFour.Size = new System.Drawing.Size(180, 150);
            this._diskFour.TabIndex = 10;
            this._diskFour.Text = "button6";
            this._diskFour.UseVisualStyleBackColor = true;
            this._diskFour.Click += new System.EventHandler(this.BoardFourClick);
            // 
            // _diskThree
            // 
            this._diskThree.Location = new System.Drawing.Point(378, 6);
            this._diskThree.Name = "_diskThree";
            this._diskThree.Size = new System.Drawing.Size(180, 150);
            this._diskThree.TabIndex = 9;
            this._diskThree.Text = "button6";
            this._diskThree.UseVisualStyleBackColor = true;
            this._diskThree.Click += new System.EventHandler(this.BoardThreeClick);
            // 
            // _diskTwo
            // 
            this._diskTwo.Location = new System.Drawing.Point(192, 6);
            this._diskTwo.Name = "_diskTwo";
            this._diskTwo.Size = new System.Drawing.Size(180, 150);
            this._diskTwo.TabIndex = 8;
            this._diskTwo.Text = "button6";
            this._diskTwo.UseVisualStyleBackColor = true;
            this._diskTwo.Click += new System.EventHandler(this.BoardTwoClick);
            // 
            // _diskOne
            // 
            this._diskOne.Location = new System.Drawing.Point(6, 6);
            this._diskOne.Name = "_diskOne";
            this._diskOne.Size = new System.Drawing.Size(180, 150);
            this._diskOne.TabIndex = 7;
            this._diskOne.Text = "button6";
            this._diskOne.UseVisualStyleBackColor = true;
            this._diskOne.Click += new System.EventHandler(this.BoardOneClick);
            // 
            // _tabDisplayCard
            // 
            this._tabDisplayCard.Controls.Add(this._displaySix);
            this._tabDisplayCard.Controls.Add(this._displayFive);
            this._tabDisplayCard.Controls.Add(this._displayFour);
            this._tabDisplayCard.Controls.Add(this._displayThree);
            this._tabDisplayCard.Controls.Add(this._displayTwo);
            this._tabDisplayCard.Controls.Add(this._displayOne);
            this._tabDisplayCard.Location = new System.Drawing.Point(4, 22);
            this._tabDisplayCard.Name = "_tabDisplayCard";
            this._tabDisplayCard.Padding = new System.Windows.Forms.Padding(3);
            this._tabDisplayCard.Size = new System.Drawing.Size(581, 334);
            this._tabDisplayCard.TabIndex = 4;
            this._tabDisplayCard.Text = "顯示卡";
            this._tabDisplayCard.UseVisualStyleBackColor = true;
            // 
            // _displaySix
            // 
            this._displaySix.Location = new System.Drawing.Point(378, 162);
            this._displaySix.Name = "_displaySix";
            this._displaySix.Size = new System.Drawing.Size(180, 150);
            this._displaySix.TabIndex = 12;
            this._displaySix.Text = "button6";
            this._displaySix.UseVisualStyleBackColor = true;
            this._displaySix.Click += new System.EventHandler(this.BoardSixClick);
            // 
            // _displayFive
            // 
            this._displayFive.Location = new System.Drawing.Point(192, 162);
            this._displayFive.Name = "_displayFive";
            this._displayFive.Size = new System.Drawing.Size(180, 150);
            this._displayFive.TabIndex = 11;
            this._displayFive.Text = "button6";
            this._displayFive.UseVisualStyleBackColor = true;
            this._displayFive.Click += new System.EventHandler(this.BoardFiveClick);
            // 
            // _displayFour
            // 
            this._displayFour.Location = new System.Drawing.Point(6, 162);
            this._displayFour.Name = "_displayFour";
            this._displayFour.Size = new System.Drawing.Size(180, 150);
            this._displayFour.TabIndex = 10;
            this._displayFour.Text = "button6";
            this._displayFour.UseVisualStyleBackColor = true;
            this._displayFour.Click += new System.EventHandler(this.BoardFourClick);
            // 
            // _displayThree
            // 
            this._displayThree.Location = new System.Drawing.Point(378, 6);
            this._displayThree.Name = "_displayThree";
            this._displayThree.Size = new System.Drawing.Size(180, 150);
            this._displayThree.TabIndex = 9;
            this._displayThree.Text = "button6";
            this._displayThree.UseVisualStyleBackColor = true;
            this._displayThree.Click += new System.EventHandler(this.BoardThreeClick);
            // 
            // _displayTwo
            // 
            this._displayTwo.Location = new System.Drawing.Point(192, 6);
            this._displayTwo.Name = "_displayTwo";
            this._displayTwo.Size = new System.Drawing.Size(180, 150);
            this._displayTwo.TabIndex = 8;
            this._displayTwo.Text = "button6";
            this._displayTwo.UseVisualStyleBackColor = true;
            this._displayTwo.Click += new System.EventHandler(this.BoardTwoClick);
            // 
            // _displayOne
            // 
            this._displayOne.Location = new System.Drawing.Point(6, 6);
            this._displayOne.Name = "_displayOne";
            this._displayOne.Size = new System.Drawing.Size(180, 150);
            this._displayOne.TabIndex = 7;
            this._displayOne.Text = "button6";
            this._displayOne.UseVisualStyleBackColor = true;
            this._displayOne.Click += new System.EventHandler(this.BoardOneClick);
            // 
            // _tabComboComputer
            // 
            this._tabComboComputer.Controls.Add(this._comboSix);
            this._tabComboComputer.Controls.Add(this._comboFive);
            this._tabComboComputer.Controls.Add(this._comboFour);
            this._tabComboComputer.Controls.Add(this._comboThree);
            this._tabComboComputer.Controls.Add(this._comboTwo);
            this._tabComboComputer.Controls.Add(this._comboOne);
            this._tabComboComputer.Location = new System.Drawing.Point(4, 22);
            this._tabComboComputer.Name = "_tabComboComputer";
            this._tabComboComputer.Padding = new System.Windows.Forms.Padding(3);
            this._tabComboComputer.Size = new System.Drawing.Size(581, 334);
            this._tabComboComputer.TabIndex = 5;
            this._tabComboComputer.Text = "套裝電腦";
            this._tabComboComputer.UseVisualStyleBackColor = true;
            // 
            // _comboSix
            // 
            this._comboSix.Location = new System.Drawing.Point(378, 162);
            this._comboSix.Name = "_comboSix";
            this._comboSix.Size = new System.Drawing.Size(180, 150);
            this._comboSix.TabIndex = 12;
            this._comboSix.Text = "button6";
            this._comboSix.UseVisualStyleBackColor = true;
            this._comboSix.Click += new System.EventHandler(this.BoardSixClick);
            // 
            // _comboFive
            // 
            this._comboFive.Location = new System.Drawing.Point(192, 162);
            this._comboFive.Name = "_comboFive";
            this._comboFive.Size = new System.Drawing.Size(180, 150);
            this._comboFive.TabIndex = 11;
            this._comboFive.Text = "button6";
            this._comboFive.UseVisualStyleBackColor = true;
            this._comboFive.Click += new System.EventHandler(this.BoardFiveClick);
            // 
            // _comboFour
            // 
            this._comboFour.Location = new System.Drawing.Point(6, 162);
            this._comboFour.Name = "_comboFour";
            this._comboFour.Size = new System.Drawing.Size(180, 150);
            this._comboFour.TabIndex = 10;
            this._comboFour.Text = "button6";
            this._comboFour.UseVisualStyleBackColor = true;
            this._comboFour.Click += new System.EventHandler(this.BoardFourClick);
            // 
            // _comboThree
            // 
            this._comboThree.Location = new System.Drawing.Point(378, 6);
            this._comboThree.Name = "_comboThree";
            this._comboThree.Size = new System.Drawing.Size(180, 150);
            this._comboThree.TabIndex = 9;
            this._comboThree.Text = "button6";
            this._comboThree.UseVisualStyleBackColor = true;
            this._comboThree.Click += new System.EventHandler(this.BoardThreeClick);
            // 
            // _comboTwo
            // 
            this._comboTwo.Location = new System.Drawing.Point(192, 6);
            this._comboTwo.Name = "_comboTwo";
            this._comboTwo.Size = new System.Drawing.Size(180, 150);
            this._comboTwo.TabIndex = 8;
            this._comboTwo.Text = "button6";
            this._comboTwo.UseVisualStyleBackColor = true;
            this._comboTwo.Click += new System.EventHandler(this.BoardTwoClick);
            // 
            // _comboOne
            // 
            this._comboOne.Location = new System.Drawing.Point(6, 6);
            this._comboOne.Name = "_comboOne";
            this._comboOne.Size = new System.Drawing.Size(180, 150);
            this._comboOne.TabIndex = 7;
            this._comboOne.Text = "button6";
            this._comboOne.UseVisualStyleBackColor = true;
            this._comboOne.Click += new System.EventHandler(this.BoardOneClick);
            // 
            // _dataGridView1
            // 
            this._dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._gridViewProductName,
            this._gridViewProductClass,
            this._gridViewProductCost});
            this._dataGridView1.Location = new System.Drawing.Point(615, 55);
            this._dataGridView1.Name = "_dataGridView1";
            this._dataGridView1.RowTemplate.Height = 24;
            this._dataGridView1.Size = new System.Drawing.Size(365, 385);
            this._dataGridView1.TabIndex = 1;
            // 
            // _gridViewProductName
            // 
            this._gridViewProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._gridViewProductName.HeaderText = "商品名稱";
            this._gridViewProductName.Name = "_gridViewProductName";
            // 
            // _gridViewProductClass
            // 
            this._gridViewProductClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._gridViewProductClass.HeaderText = "商品類別";
            this._gridViewProductClass.Name = "_gridViewProductClass";
            // 
            // _gridViewProductCost
            // 
            this._gridViewProductCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._gridViewProductCost.HeaderText = "單價";
            this._gridViewProductCost.Name = "_gridViewProductCost";
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._label2.Location = new System.Drawing.Point(796, 609);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(71, 24);
            this._label2.TabIndex = 2;
            this._label2.Text = "總金額:";
            // 
            // _labelMoneySum
            // 
            this._labelMoneySum.AutoSize = true;
            this._labelMoneySum.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelMoneySum.Location = new System.Drawing.Point(873, 609);
            this._labelMoneySum.Name = "_labelMoneySum";
            this._labelMoneySum.Size = new System.Drawing.Size(0, 24);
            this._labelMoneySum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 665);
            this.Controls.Add(this._labelMoneySum);
            this.Controls.Add(this._label2);
            this.Controls.Add(this._groupBoxProduct);
            this.Controls.Add(this._dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this._groupBoxProduct.ResumeLayout(false);
            this._groupBoxInformation.ResumeLayout(false);
            this._groupBoxInformation.PerformLayout();
            this._tabProduct.ResumeLayout(false);
            this._tabBoard.ResumeLayout(false);
            this._tabCore.ResumeLayout(false);
            this._tabMemory.ResumeLayout(false);
            this._tabDisk.ResumeLayout(false);
            this._tabDisplayCard.ResumeLayout(false);
            this._tabComboComputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupBoxProduct;
        private System.Windows.Forms.DataGridView _dataGridView1;
        private System.Windows.Forms.TabControl _tabProduct;
        private System.Windows.Forms.TabPage _tabBoard;
        private System.Windows.Forms.TabPage _tabCore;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.Button _boardSix;
        private System.Windows.Forms.Button _boardFive;
        private System.Windows.Forms.Button _boardFour;
        private System.Windows.Forms.Button _boardThree;
        private System.Windows.Forms.Button _boardTwo;
        private System.Windows.Forms.Button _boardOne;
        private System.Windows.Forms.TabPage _tabMemory;
        private System.Windows.Forms.TabPage _tabDisk;
        private System.Windows.Forms.TabPage _tabDisplayCard;
        private System.Windows.Forms.TabPage _tabComboComputer;
        private System.Windows.Forms.GroupBox _groupBoxInformation;
        private System.Windows.Forms.Button _coreSix;
        private System.Windows.Forms.Button _coreFive;
        private System.Windows.Forms.Button _coreFour;
        private System.Windows.Forms.Button _coreThree;
        private System.Windows.Forms.Button _coreTwo;
        private System.Windows.Forms.Button _coreOne;
        private System.Windows.Forms.Button _memorySix;
        private System.Windows.Forms.Button _memoryFive;
        private System.Windows.Forms.Button _memoryFour;
        private System.Windows.Forms.Button _memoryThree;
        private System.Windows.Forms.Button _memoryTwo;
        private System.Windows.Forms.Button _memoryOne;
        private System.Windows.Forms.Button _diskSix;
        private System.Windows.Forms.Button _diskFive;
        private System.Windows.Forms.Button _diskFour;
        private System.Windows.Forms.Button _diskThree;
        private System.Windows.Forms.Button _diskTwo;
        private System.Windows.Forms.Button _diskOne;
        private System.Windows.Forms.Button _displaySix;
        private System.Windows.Forms.Button _displayFive;
        private System.Windows.Forms.Button _displayFour;
        private System.Windows.Forms.Button _displayThree;
        private System.Windows.Forms.Button _displayTwo;
        private System.Windows.Forms.Button _displayOne;
        private System.Windows.Forms.Button _comboSix;
        private System.Windows.Forms.Button _comboFive;
        private System.Windows.Forms.Button _comboFour;
        private System.Windows.Forms.Button _comboThree;
        private System.Windows.Forms.Button _comboTwo;
        private System.Windows.Forms.Button _comboOne;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Label _labelMoney;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label _labelMoneySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn _gridViewProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _gridViewProductClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn _gridViewProductCost;
    }
}

