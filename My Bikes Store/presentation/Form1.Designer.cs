
namespace My_Bikes_Store
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_serialNum = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.tbox_serialNumber = new System.Windows.Forms.TextBox();
            this.tbox_make = new System.Windows.Forms.TextBox();
            this.tbox_speed = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_select = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.tbox_heightFromGround = new System.Windows.Forms.TextBox();
            this.groupBox_add = new System.Windows.Forms.GroupBox();
            this.lbl_heightFromGround = new System.Windows.Forms.Label();
            this.tbox_tireSize = new System.Windows.Forms.TextBox();
            this.lbl_tireSize = new System.Windows.Forms.Label();
            this.combo_abs = new System.Windows.Forms.ComboBox();
            this.lbl_abs = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.combo_suspension = new System.Windows.Forms.ComboBox();
            this.combo_color = new System.Windows.Forms.ComboBox();
            this.tbox_seatHeight = new System.Windows.Forms.TextBox();
            this.lbl_seatHeight = new System.Windows.Forms.Label();
            this.lbl_suspension = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_printRoadBikes = new System.Windows.Forms.Button();
            this.btn_printMountainBikes = new System.Windows.Forms.Button();
            this.btn_writeBin = new System.Windows.Forms.Button();
            this.btn_readBin = new System.Windows.Forms.Button();
            this.lbl_range = new System.Windows.Forms.Label();
            this.combo_range = new System.Windows.Forms.ComboBox();
            this.lbl_charge = new System.Windows.Forms.Label();
            this.combo_charge = new System.Windows.Forms.ComboBox();
            this.groupBox_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_type
            // 
            this.combo_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_type.FormattingEnabled = true;
            this.combo_type.ItemHeight = 20;
            this.combo_type.Location = new System.Drawing.Point(46, 76);
            this.combo_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(178, 28);
            this.combo_type.TabIndex = 0;
            this.combo_type.Text = "Choose...";
            this.combo_type.SelectedIndexChanged += new System.EventHandler(this.combo_type_SelectedIndexChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_type.Location = new System.Drawing.Point(33, 32);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(78, 40);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Text = "Type";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_serialNum
            // 
            this.lbl_serialNum.AutoSize = true;
            this.lbl_serialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serialNum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_serialNum.Location = new System.Drawing.Point(356, 42);
            this.lbl_serialNum.Name = "lbl_serialNum";
            this.lbl_serialNum.Size = new System.Drawing.Size(161, 25);
            this.lbl_serialNum.TabIndex = 2;
            this.lbl_serialNum.Text = "Serial Number";
            // 
            // lbl_make
            // 
            this.lbl_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_make.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_make.Location = new System.Drawing.Point(33, 125);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(80, 40);
            this.lbl_make.TabIndex = 3;
            this.lbl_make.Text = "Make";
            this.lbl_make.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_speed
            // 
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_speed.Location = new System.Drawing.Point(343, 128);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(91, 40);
            this.lbl_speed.TabIndex = 4;
            this.lbl_speed.Text = "Speed";
            this.lbl_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_color
            // 
            this.lbl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_color.Location = new System.Drawing.Point(42, 226);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(73, 40);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color";
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_serialNumber
            // 
            this.tbox_serialNumber.Location = new System.Drawing.Point(360, 79);
            this.tbox_serialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_serialNumber.Name = "tbox_serialNumber";
            this.tbox_serialNumber.Size = new System.Drawing.Size(244, 26);
            this.tbox_serialNumber.TabIndex = 6;
            // 
            // tbox_make
            // 
            this.tbox_make.Location = new System.Drawing.Point(46, 169);
            this.tbox_make.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_make.Name = "tbox_make";
            this.tbox_make.Size = new System.Drawing.Size(178, 26);
            this.tbox_make.TabIndex = 7;
            // 
            // tbox_speed
            // 
            this.tbox_speed.Location = new System.Drawing.Point(360, 171);
            this.tbox_speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_speed.Name = "tbox_speed";
            this.tbox_speed.Size = new System.Drawing.Size(244, 26);
            this.tbox_speed.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(708, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(785, 424);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_select
            // 
            this.lbl_select.BackColor = System.Drawing.Color.DarkBlue;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.ForeColor = System.Drawing.Color.White;
            this.lbl_select.Location = new System.Drawing.Point(708, 15);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Padding = new System.Windows.Forms.Padding(6);
            this.lbl_select.Size = new System.Drawing.Size(785, 40);
            this.lbl_select.TabIndex = 11;
            this.lbl_select.Text = "Select One to make changes";
            this.lbl_select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_add.Location = new System.Drawing.Point(417, 658);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 42);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_remove.Location = new System.Drawing.Point(1141, 512);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(111, 42);
            this.btn_remove.TabIndex = 13;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Aqua;
            this.btn_search.Location = new System.Drawing.Point(708, 691);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(111, 42);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_update.Location = new System.Drawing.Point(1259, 512);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(234, 42);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update Serial No. and Sped";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_exit.Location = new System.Drawing.Point(1382, 691);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(111, 42);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_reset.Location = new System.Drawing.Point(536, 658);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(105, 42);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tbox_search
            // 
            this.tbox_search.Location = new System.Drawing.Point(708, 656);
            this.tbox_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(200, 26);
            this.tbox_search.TabIndex = 18;
            // 
            // tbox_heightFromGround
            // 
            this.tbox_heightFromGround.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_heightFromGround.Enabled = false;
            this.tbox_heightFromGround.Location = new System.Drawing.Point(46, 369);
            this.tbox_heightFromGround.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_heightFromGround.Name = "tbox_heightFromGround";
            this.tbox_heightFromGround.Size = new System.Drawing.Size(178, 26);
            this.tbox_heightFromGround.TabIndex = 20;
            // 
            // groupBox_add
            // 
            this.groupBox_add.BackColor = System.Drawing.Color.Crimson;
            this.groupBox_add.Controls.Add(this.combo_charge);
            this.groupBox_add.Controls.Add(this.lbl_charge);
            this.groupBox_add.Controls.Add(this.combo_range);
            this.groupBox_add.Controls.Add(this.lbl_range);
            this.groupBox_add.Controls.Add(this.lbl_heightFromGround);
            this.groupBox_add.Controls.Add(this.tbox_tireSize);
            this.groupBox_add.Controls.Add(this.lbl_tireSize);
            this.groupBox_add.Controls.Add(this.combo_abs);
            this.groupBox_add.Controls.Add(this.lbl_abs);
            this.groupBox_add.Controls.Add(this.dateTimePicker1);
            this.groupBox_add.Controls.Add(this.lbl_date);
            this.groupBox_add.Controls.Add(this.combo_suspension);
            this.groupBox_add.Controls.Add(this.combo_color);
            this.groupBox_add.Controls.Add(this.tbox_seatHeight);
            this.groupBox_add.Controls.Add(this.lbl_seatHeight);
            this.groupBox_add.Controls.Add(this.lbl_suspension);
            this.groupBox_add.Controls.Add(this.lbl_type);
            this.groupBox_add.Controls.Add(this.tbox_heightFromGround);
            this.groupBox_add.Controls.Add(this.btn_reset);
            this.groupBox_add.Controls.Add(this.combo_type);
            this.groupBox_add.Controls.Add(this.tbox_serialNumber);
            this.groupBox_add.Controls.Add(this.btn_add);
            this.groupBox_add.Controls.Add(this.tbox_speed);
            this.groupBox_add.Controls.Add(this.lbl_serialNum);
            this.groupBox_add.Controls.Add(this.lbl_make);
            this.groupBox_add.Controls.Add(this.lbl_speed);
            this.groupBox_add.Controls.Add(this.lbl_color);
            this.groupBox_add.Controls.Add(this.tbox_make);
            this.groupBox_add.Location = new System.Drawing.Point(14, 15);
            this.groupBox_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_add.Name = "groupBox_add";
            this.groupBox_add.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_add.Size = new System.Drawing.Size(660, 720);
            this.groupBox_add.TabIndex = 21;
            this.groupBox_add.TabStop = false;
            this.groupBox_add.Text = "Add";
            // 
            // lbl_heightFromGround
            // 
            this.lbl_heightFromGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heightFromGround.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_heightFromGround.Location = new System.Drawing.Point(21, 322);
            this.lbl_heightFromGround.Name = "lbl_heightFromGround";
            this.lbl_heightFromGround.Size = new System.Drawing.Size(240, 40);
            this.lbl_heightFromGround.TabIndex = 32;
            this.lbl_heightFromGround.Text = "Height From Ground";
            this.lbl_heightFromGround.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_tireSize
            // 
            this.tbox_tireSize.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_tireSize.Enabled = false;
            this.tbox_tireSize.Location = new System.Drawing.Point(46, 554);
            this.tbox_tireSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_tireSize.Name = "tbox_tireSize";
            this.tbox_tireSize.Size = new System.Drawing.Size(178, 26);
            this.tbox_tireSize.TabIndex = 31;
            // 
            // lbl_tireSize
            // 
            this.lbl_tireSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tireSize.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_tireSize.Location = new System.Drawing.Point(42, 510);
            this.lbl_tireSize.Name = "lbl_tireSize";
            this.lbl_tireSize.Padding = new System.Windows.Forms.Padding(6);
            this.lbl_tireSize.Size = new System.Drawing.Size(110, 40);
            this.lbl_tireSize.TabIndex = 30;
            this.lbl_tireSize.Text = "Tire Size";
            this.lbl_tireSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_abs
            // 
            this.combo_abs.BackColor = System.Drawing.SystemColors.Window;
            this.combo_abs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_abs.Enabled = false;
            this.combo_abs.FormattingEnabled = true;
            this.combo_abs.ItemHeight = 20;
            this.combo_abs.Location = new System.Drawing.Point(360, 461);
            this.combo_abs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_abs.Name = "combo_abs";
            this.combo_abs.Size = new System.Drawing.Size(244, 28);
            this.combo_abs.TabIndex = 29;
            this.combo_abs.Text = "Choose...";
            // 
            // lbl_abs
            // 
            this.lbl_abs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abs.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_abs.Location = new System.Drawing.Point(323, 418);
            this.lbl_abs.Name = "lbl_abs";
            this.lbl_abs.Padding = new System.Windows.Forms.Padding(6);
            this.lbl_abs.Size = new System.Drawing.Size(208, 40);
            this.lbl_abs.TabIndex = 28;
            this.lbl_abs.Text = "ABS Support";
            this.lbl_abs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 272);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_date.Location = new System.Drawing.Point(353, 226);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(68, 40);
            this.lbl_date.TabIndex = 27;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_suspension
            // 
            this.combo_suspension.BackColor = System.Drawing.SystemColors.Window;
            this.combo_suspension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_suspension.Enabled = false;
            this.combo_suspension.FormattingEnabled = true;
            this.combo_suspension.ItemHeight = 20;
            this.combo_suspension.Location = new System.Drawing.Point(360, 366);
            this.combo_suspension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_suspension.Name = "combo_suspension";
            this.combo_suspension.Size = new System.Drawing.Size(244, 28);
            this.combo_suspension.TabIndex = 26;
            this.combo_suspension.Text = "Choose...";
            // 
            // combo_color
            // 
            this.combo_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_color.FormattingEnabled = true;
            this.combo_color.ItemHeight = 20;
            this.combo_color.Location = new System.Drawing.Point(46, 270);
            this.combo_color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_color.Name = "combo_color";
            this.combo_color.Size = new System.Drawing.Size(178, 28);
            this.combo_color.TabIndex = 25;
            this.combo_color.Text = "Choose...";
            // 
            // tbox_seatHeight
            // 
            this.tbox_seatHeight.BackColor = System.Drawing.SystemColors.Window;
            this.tbox_seatHeight.Enabled = false;
            this.tbox_seatHeight.Location = new System.Drawing.Point(46, 461);
            this.tbox_seatHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_seatHeight.Name = "tbox_seatHeight";
            this.tbox_seatHeight.Size = new System.Drawing.Size(178, 26);
            this.tbox_seatHeight.TabIndex = 24;
            // 
            // lbl_seatHeight
            // 
            this.lbl_seatHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seatHeight.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_seatHeight.Location = new System.Drawing.Point(7, 418);
            this.lbl_seatHeight.Name = "lbl_seatHeight";
            this.lbl_seatHeight.Padding = new System.Windows.Forms.Padding(6);
            this.lbl_seatHeight.Size = new System.Drawing.Size(192, 40);
            this.lbl_seatHeight.TabIndex = 23;
            this.lbl_seatHeight.Text = "Seat Height";
            this.lbl_seatHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_suspension
            // 
            this.lbl_suspension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suspension.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_suspension.Location = new System.Drawing.Point(353, 322);
            this.lbl_suspension.Name = "lbl_suspension";
            this.lbl_suspension.Padding = new System.Windows.Forms.Padding(6);
            this.lbl_suspension.Size = new System.Drawing.Size(136, 40);
            this.lbl_suspension.TabIndex = 21;
            this.lbl_suspension.Text = "Suspension";
            this.lbl_suspension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_print.Location = new System.Drawing.Point(708, 512);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(111, 42);
            this.btn_print.TabIndex = 22;
            this.btn_print.Text = "Print All";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(704, 624);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(252, 20);
            this.lbl_search.TabIndex = 23;
            this.lbl_search.Text = "Search for a bike by serial number:";
            // 
            // btn_printRoadBikes
            // 
            this.btn_printRoadBikes.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_printRoadBikes.Location = new System.Drawing.Point(826, 512);
            this.btn_printRoadBikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_printRoadBikes.Name = "btn_printRoadBikes";
            this.btn_printRoadBikes.Size = new System.Drawing.Size(136, 42);
            this.btn_printRoadBikes.TabIndex = 24;
            this.btn_printRoadBikes.Text = "Print Road Bikes";
            this.btn_printRoadBikes.UseVisualStyleBackColor = false;
            this.btn_printRoadBikes.Click += new System.EventHandler(this.btn_printRoadBikes_Click);
            // 
            // btn_printMountainBikes
            // 
            this.btn_printMountainBikes.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_printMountainBikes.Location = new System.Drawing.Point(969, 512);
            this.btn_printMountainBikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_printMountainBikes.Name = "btn_printMountainBikes";
            this.btn_printMountainBikes.Size = new System.Drawing.Size(165, 42);
            this.btn_printMountainBikes.TabIndex = 25;
            this.btn_printMountainBikes.Text = "Print Mountain Bikes";
            this.btn_printMountainBikes.UseVisualStyleBackColor = false;
            this.btn_printMountainBikes.Click += new System.EventHandler(this.btn_printMountainBikes_Click);
            // 
            // btn_writeBin
            // 
            this.btn_writeBin.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_writeBin.Location = new System.Drawing.Point(998, 602);
            this.btn_writeBin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_writeBin.Name = "btn_writeBin";
            this.btn_writeBin.Size = new System.Drawing.Size(111, 42);
            this.btn_writeBin.TabIndex = 26;
            this.btn_writeBin.Text = "Write Binary";
            this.btn_writeBin.UseVisualStyleBackColor = false;
            this.btn_writeBin.Click += new System.EventHandler(this.btn_writeBin_Click);
            // 
            // btn_readBin
            // 
            this.btn_readBin.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_readBin.Location = new System.Drawing.Point(1141, 602);
            this.btn_readBin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_readBin.Name = "btn_readBin";
            this.btn_readBin.Size = new System.Drawing.Size(111, 42);
            this.btn_readBin.TabIndex = 27;
            this.btn_readBin.Text = "Read Binary";
            this.btn_readBin.UseVisualStyleBackColor = false;
            this.btn_readBin.Click += new System.EventHandler(this.btn_readBin_Click);
            // 
            // lbl_range
            // 
            this.lbl_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_range.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_range.Location = new System.Drawing.Point(323, 510);
            this.lbl_range.Name = "lbl_range";
            this.lbl_range.Padding = new System.Windows.Forms.Padding(6);
            this.lbl_range.Size = new System.Drawing.Size(208, 40);
            this.lbl_range.TabIndex = 33;
            this.lbl_range.Text = "Longer Range";
            this.lbl_range.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_range
            // 
            this.combo_range.BackColor = System.Drawing.SystemColors.Window;
            this.combo_range.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_range.Enabled = false;
            this.combo_range.FormattingEnabled = true;
            this.combo_range.ItemHeight = 20;
            this.combo_range.Location = new System.Drawing.Point(358, 554);
            this.combo_range.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_range.Name = "combo_range";
            this.combo_range.Size = new System.Drawing.Size(244, 28);
            this.combo_range.TabIndex = 34;
            this.combo_range.Text = "Choose...";
            this.combo_range.SelectedIndexChanged += new System.EventHandler(this.combo_range_SelectedIndexChanged);
            // 
            // lbl_charge
            // 
            this.lbl_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_charge.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_charge.Location = new System.Drawing.Point(41, 597);
            this.lbl_charge.Name = "lbl_charge";
            this.lbl_charge.Padding = new System.Windows.Forms.Padding(6);
            this.lbl_charge.Size = new System.Drawing.Size(208, 40);
            this.lbl_charge.TabIndex = 35;
            this.lbl_charge.Text = "Quick Charger";
            this.lbl_charge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_charge
            // 
            this.combo_charge.BackColor = System.Drawing.SystemColors.Window;
            this.combo_charge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_charge.Enabled = false;
            this.combo_charge.FormattingEnabled = true;
            this.combo_charge.ItemHeight = 20;
            this.combo_charge.Location = new System.Drawing.Point(47, 641);
            this.combo_charge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_charge.Name = "combo_charge";
            this.combo_charge.Size = new System.Drawing.Size(244, 28);
            this.combo_charge.TabIndex = 36;
            this.combo_charge.Text = "Choose...";
            this.combo_charge.SelectedIndexChanged += new System.EventHandler(this.combo_charge_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 752);
            this.Controls.Add(this.btn_readBin);
            this.Controls.Add(this.btn_writeBin);
            this.Controls.Add(this.btn_printMountainBikes);
            this.Controls.Add(this.btn_printRoadBikes);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.groupBox_add);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_add.ResumeLayout(false);
            this.groupBox_add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_serialNum;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.TextBox tbox_serialNumber;
        private System.Windows.Forms.TextBox tbox_make;
        private System.Windows.Forms.TextBox tbox_speed;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.TextBox tbox_heightFromGround;
        private System.Windows.Forms.GroupBox groupBox_add;
        private System.Windows.Forms.Label lbl_suspension;
        private System.Windows.Forms.TextBox tbox_seatHeight;
        private System.Windows.Forms.Label lbl_seatHeight;
        private System.Windows.Forms.ComboBox combo_color;
        private System.Windows.Forms.ComboBox combo_suspension;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_printRoadBikes;
        private System.Windows.Forms.Button btn_printMountainBikes;
        private System.Windows.Forms.ComboBox combo_abs;
        private System.Windows.Forms.Label lbl_abs;
        private System.Windows.Forms.TextBox tbox_tireSize;
        private System.Windows.Forms.Label lbl_tireSize;
        private System.Windows.Forms.Label lbl_heightFromGround;
        private System.Windows.Forms.Button btn_writeBin;
        private System.Windows.Forms.Button btn_readBin;
        private System.Windows.Forms.Label lbl_charge;
        private System.Windows.Forms.ComboBox combo_range;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.ComboBox combo_charge;
    }
}

