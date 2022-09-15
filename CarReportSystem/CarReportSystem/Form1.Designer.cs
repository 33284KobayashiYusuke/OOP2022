
namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.toyota = new System.Windows.Forms.RadioButton();
            this.nissann = new System.Windows.Forms.RadioButton();
            this.honnda = new System.Windows.Forms.RadioButton();
            this.subaru = new System.Windows.Forms.RadioButton();
            this.foreign_Car = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pdPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColorDialog = new System.Windows.Forms.ColorDialog();
            this.carReportDBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carReportDBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.btConnect = new System.Windows.Forms.Button();
            this.btNameSerch = new System.Windows.Forms.Button();
            this.cbNameSerch = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202226DataSet = new CarReportSystem.infosys202226DataSet();
            this.carReportDBTableAdapter = new CarReportSystem.infosys202226DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202226DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pdPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingNavigator)).BeginInit();
            this.carReportDBBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202226DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(88, 73);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(274, 20);
            this.cbName.TabIndex = 0;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(93, 122);
            this.cbCarName.MaximumSize = new System.Drawing.Size(274, 0);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(274, 20);
            this.cbCarName.TabIndex = 0;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(657, 52);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(83, 28);
            this.btPictureOpen.TabIndex = 1;
            this.btPictureOpen.Text = "開く";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(751, 52);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(83, 28);
            this.btPictureDelete.TabIndex = 1;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            this.btPictureDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(608, 289);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(74, 29);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(688, 289);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(74, 29);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(765, 289);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(74, 29);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(765, 494);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(69, 34);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // toyota
            // 
            this.toyota.AutoSize = true;
            this.toyota.Location = new System.Drawing.Point(88, 99);
            this.toyota.Name = "toyota";
            this.toyota.Size = new System.Drawing.Size(47, 16);
            this.toyota.TabIndex = 3;
            this.toyota.Text = "トヨタ";
            this.toyota.UseVisualStyleBackColor = true;
            // 
            // nissann
            // 
            this.nissann.AutoSize = true;
            this.nissann.Location = new System.Drawing.Point(150, 99);
            this.nissann.Name = "nissann";
            this.nissann.Size = new System.Drawing.Size(47, 16);
            this.nissann.TabIndex = 3;
            this.nissann.Text = "日産";
            this.nissann.UseVisualStyleBackColor = true;
            // 
            // honnda
            // 
            this.honnda.AutoSize = true;
            this.honnda.Location = new System.Drawing.Point(213, 99);
            this.honnda.Name = "honnda";
            this.honnda.Size = new System.Drawing.Size(51, 16);
            this.honnda.TabIndex = 3;
            this.honnda.Text = "ホンダ";
            this.honnda.UseVisualStyleBackColor = true;
            // 
            // subaru
            // 
            this.subaru.AutoSize = true;
            this.subaru.Location = new System.Drawing.Point(279, 99);
            this.subaru.Name = "subaru";
            this.subaru.Size = new System.Drawing.Size(52, 16);
            this.subaru.TabIndex = 3;
            this.subaru.Text = "スバル";
            this.subaru.UseVisualStyleBackColor = true;
            // 
            // foreign_Car
            // 
            this.foreign_Car.AutoSize = true;
            this.foreign_Car.Location = new System.Drawing.Point(349, 99);
            this.foreign_Car.Name = "foreign_Car";
            this.foreign_Car.Size = new System.Drawing.Size(59, 16);
            this.foreign_Car.TabIndex = 3;
            this.foreign_Car.Text = "外国車";
            this.foreign_Car.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(413, 99);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(54, 16);
            this.other.TabIndex = 3;
            this.other.Text = "その他";
            this.other.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "日付:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 19);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "記録者:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "メーカー:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "車名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "画像:";
            // 
            // pdPicture
            // 
            this.pdPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pdPicture.Location = new System.Drawing.Point(621, 86);
            this.pdPicture.Name = "pdPicture";
            this.pdPicture.Size = new System.Drawing.Size(213, 183);
            this.pdPicture.TabIndex = 6;
            this.pdPicture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "記事一覧:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "レポート:";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(88, 148);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(476, 153);
            this.tbReport.TabIndex = 7;
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.色設定ToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.保存ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.色設定ToolStripMenuItem.Text = "色設定";
            this.色設定ToolStripMenuItem.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(107, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // carReportDBBindingNavigator
            // 
            this.carReportDBBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carReportDBBindingNavigator.BindingSource = this.carReportDBBindingSource;
            this.carReportDBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carReportDBBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carReportDBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carReportDBBindingNavigatorSaveItem});
            this.carReportDBBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.carReportDBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carReportDBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carReportDBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carReportDBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carReportDBBindingNavigator.Name = "carReportDBBindingNavigator";
            this.carReportDBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carReportDBBindingNavigator.Size = new System.Drawing.Size(861, 25);
            this.carReportDBBindingNavigator.TabIndex = 9;
            this.carReportDBBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carReportDBBindingNavigatorSaveItem
            // 
            this.carReportDBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carReportDBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carReportDBBindingNavigatorSaveItem.Image")));
            this.carReportDBBindingNavigatorSaveItem.Name = "carReportDBBindingNavigatorSaveItem";
            this.carReportDBBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carReportDBBindingNavigatorSaveItem.Text = "データの保存";
            this.carReportDBBindingNavigatorSaveItem.Click += new System.EventHandler(this.carReportDBBindingNavigatorSaveItem_Click);
            // 
            // carReportDBDataGridView
            // 
            this.carReportDBDataGridView.AutoGenerateColumns = false;
            this.carReportDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.carReportDBDataGridView.DataSource = this.carReportDBBindingSource;
            this.carReportDBDataGridView.Location = new System.Drawing.Point(88, 324);
            this.carReportDBDataGridView.MultiSelect = false;
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(746, 164);
            this.carReportDBDataGridView.TabIndex = 29;
            this.carReportDBDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDBDataGridView_DataError);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(4, 356);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(78, 67);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "DB接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btNameSerch
            // 
            this.btNameSerch.Location = new System.Drawing.Point(195, 494);
            this.btNameSerch.Name = "btNameSerch";
            this.btNameSerch.Size = new System.Drawing.Size(69, 34);
            this.btNameSerch.TabIndex = 1;
            this.btNameSerch.Text = "名前検索";
            this.btNameSerch.UseVisualStyleBackColor = true;
            this.btNameSerch.Click += new System.EventHandler(this.btNameSerch_Click);
            // 
            // cbNameSerch
            // 
            this.cbNameSerch.FormattingEnabled = true;
            this.cbNameSerch.Location = new System.Drawing.Point(279, 502);
            this.cbNameSerch.MaximumSize = new System.Drawing.Size(274, 0);
            this.cbNameSerch.Name = "cbNameSerch";
            this.cbNameSerch.Size = new System.Drawing.Size(274, 20);
            this.cbNameSerch.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202226DataSet;
            // 
            // infosys202226DataSet
            // 
            this.infosys202226DataSet.DataSetName = "infosys202226DataSet";
            this.infosys202226DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportDBTableAdapter
            // 
            this.carReportDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202226DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 547);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.carReportDBBindingNavigator);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.pdPicture);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.other);
            this.Controls.Add(this.foreign_Car);
            this.Controls.Add(this.honnda);
            this.Controls.Add(this.subaru);
            this.Controls.Add(this.nissann);
            this.Controls.Add(this.toyota);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btNameSerch);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbNameSerch);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingNavigator)).EndInit();
            this.carReportDBBindingNavigator.ResumeLayout(false);
            this.carReportDBBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202226DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.RadioButton toyota;
        private System.Windows.Forms.RadioButton nissann;
        private System.Windows.Forms.RadioButton honnda;
        private System.Windows.Forms.RadioButton subaru;
        private System.Windows.Forms.RadioButton foreign_Car;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pdPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColorDialog;
        private infosys202226DataSet infosys202226DataSet;
        private System.Windows.Forms.BindingSource carReportDBBindingSource;
        private infosys202226DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
        private infosys202226DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carReportDBBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carReportDBBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btNameSerch;
        private System.Windows.Forms.ComboBox cbNameSerch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}

