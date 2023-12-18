using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace ILMergeUI.ResourcesData.Forms
{
	public partial class Merge
	{
		private IContainer IContainer_Components = null;


		protected override void Dispose(bool Bool_Disposing)
		{
			if (Bool_Disposing && (IContainer_Components != null))
			{ IContainer_Components.Dispose(); }

			base.Dispose(Bool_Disposing);
		}

		private void InitializeComponent()
		{
			this.Panel_Top = new Panel();
			this.Panel_Input = new Panel();
			this.Label_Input = new Label();
			this.TextBox_Input = new TextBox();
			this.Panel_Top_LayerOne = new Panel();
			this.Panel_Output = new Panel();
			this.Label_Output = new Label();
			this.TextBox_Output = new TextBox();
			this.Panel_Top_LayerTwo = new Panel();
			this.Panel_Libraries = new Panel();
			this.Label_Libraries = new Label();
			this.TextBox_Libraries = new TextBox();
			this.Panel_Left = new Panel();
			this.Label_LibrariesList = new Label();
			this.ListBox_Libraries = new ListBox();
			this.Panel_Right = new Panel();
			this.Button_RefreshList = new Button();
			this.Panel_Right_LayerOne = new Panel();
			this.Button_DeleteLibrary = new Button();
			this.Panel_Right_LayerTwo = new Panel();
			this.Button_StartMerging = new Button();
			this.OpenFileDialog_Input = new OpenFileDialog();
			this.SaveFileDialog_Output = new SaveFileDialog();
			this.FolderBrowserDialog_Libraries = new FolderBrowserDialog();
			this.Panel_Top.SuspendLayout();
			this.Panel_Input.SuspendLayout();
			this.Panel_Output.SuspendLayout();
			this.Panel_Libraries.SuspendLayout();
			this.Panel_Left.SuspendLayout();
			this.Panel_Right.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Panel_Right);
			this.Controls.Add(this.Panel_Left);
			this.Controls.Add(this.Panel_Top);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "Merge";
			this.Text = "Merge";
			this.Load += new EventHandler(this.Form_Merge_Load);
			this.Shown += new EventHandler(this.Form_Merge_Shown);
			this.SizeChanged += new EventHandler(this.Form_Merge_SizeChanged);
			this.Panel_Top.ResumeLayout(false);
			this.Panel_Libraries.ResumeLayout(false);
			this.Panel_Libraries.PerformLayout();
			this.Panel_Output.ResumeLayout(false);
			this.Panel_Output.PerformLayout();
			this.Panel_Input.ResumeLayout(false);
			this.Panel_Input.PerformLayout();
			this.Panel_Left.ResumeLayout(false);
			this.Panel_Right.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Top.Controls.Add(this.Panel_Libraries);
			this.Panel_Top.Controls.Add(this.Panel_Top_LayerTwo);
			this.Panel_Top.Controls.Add(this.Panel_Output);
			this.Panel_Top.Controls.Add(this.Panel_Top_LayerOne);
			this.Panel_Top.Controls.Add(this.Panel_Input);
			this.Panel_Top.Dock = DockStyle.Top;
			this.Panel_Top.Location = new Point(0, 0);
			this.Panel_Top.Name = "Panel_Top";
			this.Panel_Top.Padding = new Padding(4, 2, 4, 0);
			this.Panel_Top.Size = new Size(760, 80);
			this.Panel_Top.TabIndex = 0;

			this.Panel_Input.BorderStyle = BorderStyle.FixedSingle;
			this.Panel_Input.Controls.Add(this.TextBox_Input);
			this.Panel_Input.Controls.Add(this.Label_Input);
			this.Panel_Input.Dock = DockStyle.Top;
			this.Panel_Input.Location = new Point(4, 2);
			this.Panel_Input.Name = "Panel_Input";
			this.Panel_Input.Size = new Size(752, 24);
			this.Panel_Input.TabIndex = 0;

			this.Label_Input.AutoSize = true;
			this.Label_Input.Dock = DockStyle.Left;
			this.Label_Input.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_Input.ForeColor = Color.Silver;
			this.Label_Input.Location = new Point(0, 0);
			this.Label_Input.Name = "Label_Input";
			this.Label_Input.Size = new Size(55, 20);
			this.Label_Input.TabIndex = 0;
			this.Label_Input.Text = "Input -";
			this.Label_Input.TextAlign = ContentAlignment.MiddleCenter;

			this.TextBox_Input.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.TextBox_Input.BorderStyle = BorderStyle.None;
			this.TextBox_Input.Dock = DockStyle.Fill;
			this.TextBox_Input.Font = new Font("Microsoft Sans Serif", 13F);
			this.TextBox_Input.ForeColor = Color.WhiteSmoke;
			this.TextBox_Input.Location = new Point(55, 0);
			this.TextBox_Input.Name = "TextBox_Input";
			this.TextBox_Input.ReadOnly = true;
			this.TextBox_Input.Size = new Size(695, 20);
			this.TextBox_Input.TabIndex = 0;
			this.TextBox_Input.DoubleClick += new EventHandler(this.TextBox_Input_DoubleClick);

			this.Panel_Top_LayerOne.Dock = DockStyle.Top;
			this.Panel_Top_LayerOne.Location = new Point(4, 26);
			this.Panel_Top_LayerOne.Name = "Panel_Top_LayerOne";
			this.Panel_Top_LayerOne.Size = new Size(752, 2);
			this.Panel_Top_LayerOne.TabIndex = 0;

			this.Panel_Output.BorderStyle = BorderStyle.FixedSingle;
			this.Panel_Output.Controls.Add(this.TextBox_Output);
			this.Panel_Output.Controls.Add(this.Label_Output);
			this.Panel_Output.Dock = DockStyle.Top;
			this.Panel_Output.Location = new Point(4, 28);
			this.Panel_Output.Name = "Panel_Output";
			this.Panel_Output.Size = new Size(752, 24);
			this.Panel_Output.TabIndex = 0;

			this.Label_Output.AutoSize = true;
			this.Label_Output.Dock = DockStyle.Left;
			this.Label_Output.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_Output.ForeColor = Color.Silver;
			this.Label_Output.Location = new Point(0, 0);
			this.Label_Output.Name = "Label_Output";
			this.Label_Output.Size = new Size(67, 20);
			this.Label_Output.TabIndex = 0;
			this.Label_Output.Text = "Output -";
			this.Label_Output.TextAlign = ContentAlignment.MiddleCenter;

			this.TextBox_Output.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.TextBox_Output.BorderStyle = BorderStyle.None;
			this.TextBox_Output.Dock = DockStyle.Fill;
			this.TextBox_Output.Font = new Font("Microsoft Sans Serif", 13F);
			this.TextBox_Output.ForeColor = Color.WhiteSmoke;
			this.TextBox_Output.Location = new Point(67, 0);
			this.TextBox_Output.Name = "TextBox_Output";
			this.TextBox_Output.ReadOnly = true;
			this.TextBox_Output.Size = new Size(683, 20);
			this.TextBox_Output.TabIndex = 0;
			this.TextBox_Output.DoubleClick += new EventHandler(this.TextBox_Output_DoubleClick);

			this.Panel_Top_LayerTwo.Dock = DockStyle.Top;
			this.Panel_Top_LayerTwo.Location = new Point(4, 52);
			this.Panel_Top_LayerTwo.Name = "Panel_Top_LayerTwo";
			this.Panel_Top_LayerTwo.Size = new Size(752, 2);
			this.Panel_Top_LayerTwo.TabIndex = 0;

			this.Panel_Libraries.BorderStyle = BorderStyle.FixedSingle;
			this.Panel_Libraries.Controls.Add(this.TextBox_Libraries);
			this.Panel_Libraries.Controls.Add(this.Label_Libraries);
			this.Panel_Libraries.Dock = DockStyle.Top;
			this.Panel_Libraries.Location = new Point(4, 54);
			this.Panel_Libraries.Name = "Panel_Libraries";
			this.Panel_Libraries.Size = new Size(752, 24);
			this.Panel_Libraries.TabIndex = 0;

			this.Label_Libraries.AutoSize = true;
			this.Label_Libraries.Dock = DockStyle.Left;
			this.Label_Libraries.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_Libraries.ForeColor = Color.Silver;
			this.Label_Libraries.Location = new Point(0, 0);
			this.Label_Libraries.Name = "Label_Libraries";
			this.Label_Libraries.Size = new Size(78, 20);
			this.Label_Libraries.TabIndex = 0;
			this.Label_Libraries.Text = "Libraries -";
			this.Label_Libraries.TextAlign = ContentAlignment.MiddleCenter;

			this.TextBox_Libraries.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.TextBox_Libraries.BorderStyle = BorderStyle.None;
			this.TextBox_Libraries.Dock = DockStyle.Fill;
			this.TextBox_Libraries.Font = new Font("Microsoft Sans Serif", 13F);
			this.TextBox_Libraries.ForeColor = Color.WhiteSmoke;
			this.TextBox_Libraries.Location = new Point(78, 0);
			this.TextBox_Libraries.Name = "TextBox_Libraries";
			this.TextBox_Libraries.ReadOnly = true;
			this.TextBox_Libraries.Size = new Size(672, 20);
			this.TextBox_Libraries.TabIndex = 0;
			this.TextBox_Libraries.DoubleClick += new EventHandler(this.TextBox_Libraries_DoubleClick);

			this.Panel_Left.Controls.Add(this.ListBox_Libraries);
			this.Panel_Left.Controls.Add(this.Label_LibrariesList);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 80);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Padding = new Padding(4, 0, 0, 0);
			this.Panel_Left.Size = new Size(475, 460);
			this.Panel_Left.TabIndex = 0;

			this.Label_LibrariesList.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
			this.Label_LibrariesList.Dock = DockStyle.Top;
			this.Label_LibrariesList.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_LibrariesList.ForeColor = SystemColors.ActiveCaption;
			this.Label_LibrariesList.Location = new Point(4, 0);
			this.Label_LibrariesList.Name = "Label_LibrariesList";
			this.Label_LibrariesList.Size = new Size(471, 30);
			this.Label_LibrariesList.TabIndex = 0;
			this.Label_LibrariesList.Text = "Libraries List";
			this.Label_LibrariesList.TextAlign = ContentAlignment.MiddleCenter;

			this.ListBox_Libraries.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ListBox_Libraries.BorderStyle = BorderStyle.None;
			this.ListBox_Libraries.Dock = DockStyle.Fill;
			this.ListBox_Libraries.Font = new Font("Microsoft Sans Serif", 10F);
			this.ListBox_Libraries.ForeColor = Color.White;
			this.ListBox_Libraries.ItemHeight = 16;
			this.ListBox_Libraries.Location = new Point(4, 30);
			this.ListBox_Libraries.Name = "ListBox_Libraries";
			this.ListBox_Libraries.Size = new Size(471, 430);
			this.ListBox_Libraries.TabIndex = 0;
			this.ListBox_Libraries.Tag = "";

			this.Panel_Right.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.Panel_Right.Controls.Add(this.Button_StartMerging);
			this.Panel_Right.Controls.Add(this.Panel_Right_LayerTwo);
			this.Panel_Right.Controls.Add(this.Button_DeleteLibrary);
			this.Panel_Right.Controls.Add(this.Panel_Right_LayerOne);
			this.Panel_Right.Controls.Add(this.Button_RefreshList);
			this.Panel_Right.Dock = DockStyle.Fill;
			this.Panel_Right.Location = new Point(475, 80);
			this.Panel_Right.Name = "Panel_Right";
			this.Panel_Right.Padding = new Padding(0, 0, 4, 0);
			this.Panel_Right.Size = new Size(285, 460);
			this.Panel_Right.TabIndex = 0;

			this.Button_RefreshList.Dock = DockStyle.Top;
			this.Button_RefreshList.FlatAppearance.BorderSize = 0;
			this.Button_RefreshList.FlatStyle = FlatStyle.Flat;
			this.Button_RefreshList.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_RefreshList.ForeColor = Color.White;
			this.Button_RefreshList.Location = new Point(0, 0);
			this.Button_RefreshList.Name = "Button_RefreshList";
			this.Button_RefreshList.Size = new Size(281, 30);
			this.Button_RefreshList.TabIndex = 0;
			this.Button_RefreshList.Text = "Refresh List";
			this.Button_RefreshList.Click += new EventHandler(this.Button_RefreshList_Click);

			this.Panel_Right_LayerOne.Dock = DockStyle.Top;
			this.Panel_Right_LayerOne.Location = new Point(0, 30);
			this.Panel_Right_LayerOne.Name = "Panel_Right_LayerOne";
			this.Panel_Right_LayerOne.Size = new Size(281, 30);
			this.Panel_Right_LayerOne.TabIndex = 0;

			this.Button_DeleteLibrary.Dock = DockStyle.Top;
			this.Button_DeleteLibrary.FlatAppearance.BorderSize = 0;
			this.Button_DeleteLibrary.FlatStyle = FlatStyle.Flat;
			this.Button_DeleteLibrary.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_DeleteLibrary.ForeColor = Color.White;
			this.Button_DeleteLibrary.Location = new Point(0, 60);
			this.Button_DeleteLibrary.Name = "Button_DeleteLibrary";
			this.Button_DeleteLibrary.Size = new Size(281, 30);
			this.Button_DeleteLibrary.TabIndex = 0;
			this.Button_DeleteLibrary.Text = "Delete Library";
			this.Button_DeleteLibrary.Click += new EventHandler(this.Button_DeleteLibrary_Click);

			this.Panel_Right_LayerTwo.Dock = DockStyle.Top;
			this.Panel_Right_LayerTwo.Location = new Point(0, 90);
			this.Panel_Right_LayerTwo.Name = "Panel_Right_LayerTwo";
			this.Panel_Right_LayerTwo.Size = new Size(281, 45);
			this.Panel_Right_LayerTwo.TabIndex = 0;

			this.Button_StartMerging.Dock = DockStyle.Top;
			this.Button_StartMerging.FlatAppearance.BorderSize = 0;
			this.Button_StartMerging.FlatStyle = FlatStyle.Flat;
			this.Button_StartMerging.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_StartMerging.ForeColor = Color.White;
			this.Button_StartMerging.Location = new Point(0, 135);
			this.Button_StartMerging.Name = "Button_StartMerging";
			this.Button_StartMerging.Size = new Size(281, 30);
			this.Button_StartMerging.TabIndex = 0;
			this.Button_StartMerging.Text = "Start Merging";
			this.Button_StartMerging.Click += new EventHandler(this.Button_StartMerging_Click);
		}

		private Panel Panel_Top;
		private Panel Panel_Input;
		private Label Label_Input;
		private TextBox TextBox_Input;
		private Panel Panel_Top_LayerOne;
		private Panel Panel_Output;
		private Label Label_Output;
		private TextBox TextBox_Output;
		private Panel Panel_Top_LayerTwo;
		private Panel Panel_Libraries;
		private Label Label_Libraries;
		private TextBox TextBox_Libraries;
		private Panel Panel_Left;
		private Label Label_LibrariesList;
		private ListBox ListBox_Libraries;
		private Panel Panel_Right;
		private Button Button_RefreshList;
		private Panel Panel_Right_LayerOne;
		private Button Button_DeleteLibrary;
		private Panel Panel_Right_LayerTwo;
		private Button Button_StartMerging;
		private OpenFileDialog OpenFileDialog_Input;
		private SaveFileDialog SaveFileDialog_Output;
		private FolderBrowserDialog FolderBrowserDialog_Libraries;
	}
}