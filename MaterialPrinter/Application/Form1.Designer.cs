
using System.Windows.Forms;

namespace MaterialPrinter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRender = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.NumericTextBox7 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox6 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox5 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox4 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox8 = new MaterialPrinter.NumericTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NumericTextBox9 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox10 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox11 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox12 = new MaterialPrinter.NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumericTextBox2 = new MaterialPrinter.NumericTextBox();
            this.NumericTextBox3 = new MaterialPrinter.NumericTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddToRenderQueue = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectOutputFolder = new System.Windows.Forms.Button();
            this.NumericTextBox1 = new MaterialPrinter.NumericTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.DarkOrange;
            this.progressBar1.Location = new System.Drawing.Point(53, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(451, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(53, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 63);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRender
            // 
            this.btnRender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRender.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRender.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRender.ForeColor = System.Drawing.Color.Black;
            this.btnRender.Location = new System.Drawing.Point(53, 85);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(63, 63);
            this.btnRender.TabIndex = 29;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = false;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 607);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Render Job";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 570);
            this.panel2.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.vScrollBar1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 324);
            this.panel4.TabIndex = 27;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 324);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox7, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox6, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox5, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox4, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox8, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 12);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox9, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox10, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox11, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox12, 1, 12);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBox1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.NumericTextBox3, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(31, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 13;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(437, 318);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // NumericTextBox7
            // 
            this.NumericTextBox7.AllowSpace = false;
            this.NumericTextBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox7.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox7.Location = new System.Drawing.Point(134, 178);
            this.NumericTextBox7.Name = "NumericTextBox7";
            this.NumericTextBox7.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox7.TabIndex = 44;
            this.NumericTextBox7.WordWrap = false;
            // 
            // NumericTextBox6
            // 
            this.NumericTextBox6.AllowSpace = false;
            this.NumericTextBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox6.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox6.Location = new System.Drawing.Point(134, 153);
            this.NumericTextBox6.Name = "NumericTextBox6";
            this.NumericTextBox6.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox6.TabIndex = 43;
            this.NumericTextBox6.WordWrap = false;
            // 
            // NumericTextBox5
            // 
            this.NumericTextBox5.AllowSpace = false;
            this.NumericTextBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox5.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox5.Location = new System.Drawing.Point(134, 128);
            this.NumericTextBox5.Name = "NumericTextBox5";
            this.NumericTextBox5.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox5.TabIndex = 42;
            this.NumericTextBox5.WordWrap = false;
            // 
            // NumericTextBox4
            // 
            this.NumericTextBox4.AllowSpace = false;
            this.NumericTextBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox4.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox4.Location = new System.Drawing.Point(134, 103);
            this.NumericTextBox4.Name = "NumericTextBox4";
            this.NumericTextBox4.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox4.TabIndex = 41;
            this.NumericTextBox4.WordWrap = false;
            // 
            // NumericTextBox8
            // 
            this.NumericTextBox8.AllowSpace = false;
            this.NumericTextBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox8.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox8.Location = new System.Drawing.Point(134, 203);
            this.NumericTextBox8.Name = "NumericTextBox8";
            this.NumericTextBox8.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox8.TabIndex = 49;
            this.NumericTextBox8.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Orthogonal Scale";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Resolution Y";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Resolution X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Number of vertical tiles";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Number of horizontal tiles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Start Tile X";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Start Tile Y";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "End Tile X";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "End Tile Y";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericTextBox9
            // 
            this.NumericTextBox9.AllowSpace = false;
            this.NumericTextBox9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox9.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox9.Location = new System.Drawing.Point(134, 228);
            this.NumericTextBox9.Name = "NumericTextBox9";
            this.NumericTextBox9.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox9.TabIndex = 54;
            this.NumericTextBox9.WordWrap = false;
            // 
            // NumericTextBox10
            // 
            this.NumericTextBox10.AllowSpace = false;
            this.NumericTextBox10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox10.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox10.Location = new System.Drawing.Point(134, 253);
            this.NumericTextBox10.Name = "NumericTextBox10";
            this.NumericTextBox10.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox10.TabIndex = 55;
            this.NumericTextBox10.WordWrap = false;
            // 
            // NumericTextBox11
            // 
            this.NumericTextBox11.AllowSpace = false;
            this.NumericTextBox11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox11.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox11.Location = new System.Drawing.Point(134, 278);
            this.NumericTextBox11.Name = "NumericTextBox11";
            this.NumericTextBox11.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox11.TabIndex = 56;
            this.NumericTextBox11.WordWrap = false;
            // 
            // NumericTextBox12
            // 
            this.NumericTextBox12.AllowSpace = false;
            this.NumericTextBox12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox12.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox12.Location = new System.Drawing.Point(134, 303);
            this.NumericTextBox12.Name = "NumericTextBox12";
            this.NumericTextBox12.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox12.TabIndex = 57;
            this.NumericTextBox12.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Testrender";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Test Tile X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Test Tile Y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericTextBox2
            // 
            this.NumericTextBox2.AllowSpace = false;
            this.NumericTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox2.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox2.Location = new System.Drawing.Point(134, 28);
            this.NumericTextBox2.Name = "NumericTextBox2";
            this.NumericTextBox2.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox2.TabIndex = 47;
            this.NumericTextBox2.WordWrap = false;
            // 
            // NumericTextBox3
            // 
            this.NumericTextBox3.AllowSpace = false;
            this.NumericTextBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox3.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox3.Location = new System.Drawing.Point(134, 53);
            this.NumericTextBox3.Name = "NumericTextBox3";
            this.NumericTextBox3.Size = new System.Drawing.Size(300, 20);
            this.NumericTextBox3.TabIndex = 40;
            this.NumericTextBox3.WordWrap = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(529, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 324);
            this.vScrollBar1.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.btnAddToRenderQueue);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSelectMaterial);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSelectOutputFolder);
            this.panel3.Controls.Add(this.NumericTextBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 246);
            this.panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(28, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(28, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Post-Render Action:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddToRenderQueue
            // 
            this.btnAddToRenderQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddToRenderQueue.ForeColor = System.Drawing.Color.Black;
            this.btnAddToRenderQueue.ImageKey = "ico_folder_add.png";
            this.btnAddToRenderQueue.ImageList = this.imageList1;
            this.btnAddToRenderQueue.Location = new System.Drawing.Point(214, 69);
            this.btnAddToRenderQueue.Name = "btnAddToRenderQueue";
            this.btnAddToRenderQueue.Size = new System.Drawing.Size(259, 64);
            this.btnAddToRenderQueue.TabIndex = 48;
            this.btnAddToRenderQueue.Text = "   ADD TO RENDER QUEUE";
            this.btnAddToRenderQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToRenderQueue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToRenderQueue.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ico_file.png");
            this.imageList1.Images.SetKeyName(1, "ico_file_add.png");
            this.imageList1.Images.SetKeyName(2, "ico_file_delete.png");
            this.imageList1.Images.SetKeyName(3, "ico_file_edit.png");
            this.imageList1.Images.SetKeyName(4, "ico_file_info.png");
            this.imageList1.Images.SetKeyName(5, "ico_folder.png");
            this.imageList1.Images.SetKeyName(6, "ico_folder_add.png");
            this.imageList1.Images.SetKeyName(7, "ico_folder_delete.png");
            this.imageList1.Images.SetKeyName(8, "ico_folder_info.png");
            this.imageList1.Images.SetKeyName(9, "ico_general_add.png");
            this.imageList1.Images.SetKeyName(10, "ico_general_alert.png");
            this.imageList1.Images.SetKeyName(11, "ico_general_cancel.png");
            this.imageList1.Images.SetKeyName(12, "ico_general_close.png");
            this.imageList1.Images.SetKeyName(13, "ico_general_copy.png");
            this.imageList1.Images.SetKeyName(14, "ico_general_delete.png");
            this.imageList1.Images.SetKeyName(15, "ico_general_edit.png");
            this.imageList1.Images.SetKeyName(16, "ico_general_info.png");
            this.imageList1.Images.SetKeyName(17, "ico_general_paste.png");
            this.imageList1.Images.SetKeyName(18, "ico_general_performance.png");
            this.imageList1.Images.SetKeyName(19, "ico_general_refresh.png");
            this.imageList1.Images.SetKeyName(20, "ico_general_save.png");
            this.imageList1.Images.SetKeyName(21, "ico_general_search.png");
            this.imageList1.Images.SetKeyName(22, "ico_general_settings.png");
            this.imageList1.Images.SetKeyName(23, "ico_general_settings2.png");
            this.imageList1.Images.SetKeyName(24, "ico_general_time.png");
            this.imageList1.Images.SetKeyName(25, "ico_general_tools.png");
            this.imageList1.Images.SetKeyName(26, "ico_general_zoomin.png");
            this.imageList1.Images.SetKeyName(27, "ico_general_zoomout.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Set Render Specific Parameters:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectMaterial
            // 
            this.btnSelectMaterial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelectMaterial.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectMaterial.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelectMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSelectMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnSelectMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectMaterial.ForeColor = System.Drawing.Color.Black;
            this.btnSelectMaterial.Location = new System.Drawing.Point(28, 154);
            this.btnSelectMaterial.Name = "btnSelectMaterial";
            this.btnSelectMaterial.Size = new System.Drawing.Size(445, 21);
            this.btnSelectMaterial.TabIndex = 44;
            this.btnSelectMaterial.Text = "- Select your Material file -";
            this.btnSelectMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectMaterial.UseVisualStyleBackColor = true;
            this.btnSelectMaterial.Click += new System.EventHandler(this.btnSelectMaterial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Select Material:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(28, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Output folder:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectOutputFolder
            // 
            this.btnSelectOutputFolder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelectOutputFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectOutputFolder.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectOutputFolder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelectOutputFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSelectOutputFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnSelectOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectOutputFolder.ForeColor = System.Drawing.Color.Black;
            this.btnSelectOutputFolder.Location = new System.Drawing.Point(28, 194);
            this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            this.btnSelectOutputFolder.Size = new System.Drawing.Size(445, 21);
            this.btnSelectOutputFolder.TabIndex = 42;
            this.btnSelectOutputFolder.Text = "- Select your Output folder -";
            this.btnSelectOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutputFolder.Click += new System.EventHandler(this.btnSelectOutputFolder_Click);
            // 
            // NumericTextBox1
            // 
            this.NumericTextBox1.AllowSpace = false;
            this.NumericTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NumericTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox1.ForeColor = System.Drawing.Color.Black;
            this.NumericTextBox1.Location = new System.Drawing.Point(28, 70);
            this.NumericTextBox1.Name = "NumericTextBox1";
            this.NumericTextBox1.Size = new System.Drawing.Size(175, 20);
            this.NumericTextBox1.TabIndex = 31;
            this.NumericTextBox1.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Render Queue";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Controls.Add(this.txtConsole);
            this.tabPage3.Controls.Add(this.btnRender);
            this.tabPage3.Controls.Add(this.btnCancel);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(554, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Render Engine";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(53, 167);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(451, 386);
            this.txtConsole.TabIndex = 29;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1184, 926);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Printer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private TabControl tabControl1;
        private Button btnRender;
        private Button btnCancel;
        private TextBox txtConsole;
        private TabPage tabPage1;
        private Panel panel2;
        private Label label12;
        private NumericTextBox NumericTextBox1;
        private Panel panel3;
        private Button btnAddToRenderQueue;
        private ComboBox comboBox1;
        private Label label17;
        private Label label3;
        private Button btnSelectMaterial;
        private Label label1;
        private Label label2;
        private Button btnSelectOutputFolder;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericTextBox NumericTextBox7;
        private NumericTextBox NumericTextBox6;
        private NumericTextBox NumericTextBox5;
        private NumericTextBox NumericTextBox4;
        private NumericTextBox NumericTextBox8;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private NumericTextBox NumericTextBox9;
        private NumericTextBox NumericTextBox10;
        private NumericTextBox NumericTextBox11;
        private NumericTextBox NumericTextBox12;
        private Label label4;
        private CheckBox checkBox1;
        private Label label7;
        private Label label8;
        private NumericTextBox NumericTextBox2;
        private NumericTextBox NumericTextBox3;
        private VScrollBar vScrollBar1;

	}
}

