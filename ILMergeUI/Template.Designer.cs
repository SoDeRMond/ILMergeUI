using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace ILMergeUI
{
	public partial class Template
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Template));
			this.Panel_Top = new Panel();
			this.Label_Title = new Label();
			this.Panel_Tools = new Panel();
			this.Button_Minimize = new Button();
			this.Button_Maximize = new Button();
			this.Button_Close = new Button();
			this.Panel_Left = new Panel();
			this.Label_Logo = new Label();
			this.Panel_Tabs = new Panel();
			this.Button_Merge = new Button();
			this.Button_Settings = new Button();
			this.Button_LanguageSwitcher = new Button();
			this.Panel_FormsArea = new Panel();
			this.Panel_Top.SuspendLayout();
			this.Panel_Tools.SuspendLayout();
			this.Panel_Left.SuspendLayout();
			this.Panel_Tabs.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1000, 600);
			this.Controls.Add(this.Panel_FormsArea);
			this.Controls.Add(this.Panel_Top);
			this.Controls.Add(this.Panel_Left);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Template";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "ILMerge UI";
			this.Load += new EventHandler(this.Form_Template_Load);
			this.Shown += new EventHandler(this.Form_Template_Shown);
			this.Panel_Top.ResumeLayout(false);
			this.Panel_Tools.ResumeLayout(false);
			this.Panel_Left.ResumeLayout(false);
			this.Panel_Tabs.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Top.BackColor = Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
			this.Panel_Top.Controls.Add(this.Label_Title);
			this.Panel_Top.Controls.Add(this.Panel_Tools);
			this.Panel_Top.Dock = DockStyle.Top;
			this.Panel_Top.Location = new Point(240, 0);
			this.Panel_Top.Name = "Panel_Top";
			this.Panel_Top.Size = new Size(760, 60);
			this.Panel_Top.TabIndex = 1;

			this.Label_Title.Dock = DockStyle.Fill;
			this.Label_Title.Font = new Font("Microsoft Sans Serif", 16F);
			this.Label_Title.ForeColor = Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
			this.Label_Title.Location = new Point(0, 0);
			this.Label_Title.Name = "Label_Title";
			this.Label_Title.Size = new Size(634, 60);
			this.Label_Title.TabIndex = 0;
			this.Label_Title.Text = "Home";
			this.Label_Title.TextAlign = ContentAlignment.MiddleCenter;
			this.Label_Title.MouseDown += new MouseEventHandler(this.Label_Title_MouseDown);

			this.Panel_Tools.BackColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
			this.Panel_Tools.Controls.Add(this.Button_Minimize);
			this.Panel_Tools.Controls.Add(this.Button_Maximize);
			this.Panel_Tools.Controls.Add(this.Button_Close);
			this.Panel_Tools.Dock = DockStyle.Right;
			this.Panel_Tools.Location = new Point(634, 0);
			this.Panel_Tools.Name = "Panel_Tools";
			this.Panel_Tools.Size = new Size(126, 60);
			this.Panel_Tools.TabIndex = 0;

			this.Button_Minimize.Dock = DockStyle.Right;
			this.Button_Minimize.FlatAppearance.BorderSize = 0;
			this.Button_Minimize.FlatStyle = FlatStyle.Flat;
			this.Button_Minimize.Font = new Font("Microsoft Sans Serif", 18F);
			this.Button_Minimize.ForeColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
			this.Button_Minimize.Location = new Point(0, 0);
			this.Button_Minimize.Name = "Button_Minimize";
			this.Button_Minimize.Size = new Size(42, 60);
			this.Button_Minimize.TabIndex = 2;
			this.Button_Minimize.Text = "O";
			this.Button_Minimize.Click += new EventHandler(this.Button_Minimize_Click);

			this.Button_Maximize.Dock = DockStyle.Right;
			this.Button_Maximize.FlatAppearance.BorderSize = 0;
			this.Button_Maximize.FlatStyle = FlatStyle.Flat;
			this.Button_Maximize.Font = new Font("Microsoft Sans Serif", 18F);
			this.Button_Maximize.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(5)))));
			this.Button_Maximize.Location = new Point(42, 0);
			this.Button_Maximize.Name = "Button_Maximize";
			this.Button_Maximize.Size = new Size(42, 60);
			this.Button_Maximize.TabIndex = 1;
			this.Button_Maximize.Text = "O";
			this.Button_Maximize.Click += new EventHandler(this.Button_Maximize_Click);

			this.Button_Close.Dock = DockStyle.Right;
			this.Button_Close.FlatAppearance.BorderSize = 0;
			this.Button_Close.FlatStyle = FlatStyle.Flat;
			this.Button_Close.Font = new Font("Microsoft Sans Serif", 18F);
			this.Button_Close.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
			this.Button_Close.Location = new Point(84, 0);
			this.Button_Close.Name = "Button_Close";
			this.Button_Close.Size = new Size(42, 60);
			this.Button_Close.TabIndex = 0;
			this.Button_Close.Text = "O";
			this.Button_Close.Click += new EventHandler(this.Button_Close_Click);

			this.Panel_Left.BackColor = Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
			this.Panel_Left.Controls.Add(this.Button_LanguageSwitcher);
			this.Panel_Left.Controls.Add(this.Panel_Tabs);
			this.Panel_Left.Controls.Add(this.Label_Logo);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 0);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Size = new Size(240, 600);
			this.Panel_Left.TabIndex = 0;

			this.Label_Logo.BackColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
			this.Label_Logo.Dock = DockStyle.Top;
			this.Label_Logo.Font = new Font("Microsoft Sans Serif", 14F);
			this.Label_Logo.ForeColor = Color.White;
			this.Label_Logo.Location = new Point(0, 0);
			this.Label_Logo.Name = "Label_Logo";
			this.Label_Logo.Size = new Size(240, 60);
			this.Label_Logo.TabIndex = 0;
			this.Label_Logo.Text = "ILMerge UI";
			this.Label_Logo.TextAlign = ContentAlignment.MiddleCenter;
			this.Label_Logo.Click += new EventHandler(this.Label_Logo_Click);

			this.Panel_Tabs.Controls.Add(this.Button_Settings);
			this.Panel_Tabs.Controls.Add(this.Button_Merge);
			this.Panel_Tabs.Dock = DockStyle.Fill;
			this.Panel_Tabs.Location = new Point(0, 60);
			this.Panel_Tabs.Name = "Panel_Tabs";
			this.Panel_Tabs.Size = new Size(240, 540);
			this.Panel_Tabs.TabIndex = 1;

			this.Button_Merge.Dock = DockStyle.Top;
			this.Button_Merge.FlatAppearance.BorderSize = 0;
			this.Button_Merge.FlatStyle = FlatStyle.Flat;
			this.Button_Merge.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_Merge.ForeColor = Color.White;
			this.Button_Merge.Image = global::ILMergeUI.Properties.Resources.Merge_White;
			this.Button_Merge.ImageAlign = ContentAlignment.MiddleLeft;
			this.Button_Merge.Location = new Point(0, 0);
			this.Button_Merge.Name = "Button_Merge";
			this.Button_Merge.Padding = new Padding(8, 0, 16, 0);
			this.Button_Merge.Size = new Size(240, 42);
			this.Button_Merge.TabIndex = 0;
			this.Button_Merge.Text = "  Merge";
			this.Button_Merge.TextAlign = ContentAlignment.MiddleLeft;
			this.Button_Merge.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button_Merge.Click += new EventHandler(this.Button_Merge_Click);

			this.Button_Settings.Dock = DockStyle.Top;
			this.Button_Settings.FlatAppearance.BorderSize = 0;
			this.Button_Settings.FlatStyle = FlatStyle.Flat;
			this.Button_Settings.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_Settings.ForeColor = Color.White;
			this.Button_Settings.Image = global::ILMergeUI.Properties.Resources.Settings_White;
			this.Button_Settings.ImageAlign = ContentAlignment.MiddleLeft;
			this.Button_Settings.Location = new Point(0, 42);
			this.Button_Settings.Name = "Button_Settings";
			this.Button_Settings.Padding = new Padding(8, 0, 16, 0);
			this.Button_Settings.Size = new Size(240, 42);
			this.Button_Settings.TabIndex = 1;
			this.Button_Settings.Text = "  Settings";
			this.Button_Settings.TextAlign = ContentAlignment.MiddleLeft;
			this.Button_Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button_Settings.Click += new EventHandler(this.Button_Settings_Click);

			this.Button_LanguageSwitcher.BackColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
			this.Button_LanguageSwitcher.Dock = DockStyle.Bottom;
			this.Button_LanguageSwitcher.FlatAppearance.BorderSize = 0;
			this.Button_LanguageSwitcher.FlatStyle = FlatStyle.Flat;
			this.Button_LanguageSwitcher.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_LanguageSwitcher.ForeColor = Color.White;
			this.Button_LanguageSwitcher.Image = global::ILMergeUI.Properties.Resources.LanguageSwitcher;
			this.Button_LanguageSwitcher.ImageAlign = ContentAlignment.MiddleLeft;
			this.Button_LanguageSwitcher.Location = new Point(0, 558);
			this.Button_LanguageSwitcher.Name = "Button_LanguageSwitcher";
			this.Button_LanguageSwitcher.Padding = new Padding(8, 0, 0, 0);
			this.Button_LanguageSwitcher.Size = new Size(240, 42);
			this.Button_LanguageSwitcher.TabIndex = 2;
			this.Button_LanguageSwitcher.Text = "  English";
			this.Button_LanguageSwitcher.TextAlign = ContentAlignment.MiddleLeft;
			this.Button_LanguageSwitcher.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.Button_LanguageSwitcher.UseVisualStyleBackColor = false;
			this.Button_LanguageSwitcher.Click += new EventHandler(this.Button_LanguageSwitcher_Click);

			this.Panel_FormsArea.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.Panel_FormsArea.Dock = DockStyle.Fill;
			this.Panel_FormsArea.Location = new Point(240, 60);
			this.Panel_FormsArea.Name = "Panel_FormsArea";
			this.Panel_FormsArea.Size = new Size(760, 540);
			this.Panel_FormsArea.TabIndex = 2;
		}

		private Panel Panel_Top;
		private Label Label_Title;
		private Panel Panel_Tools;
		private Button Button_Minimize;
		private Button Button_Maximize;
		private Button Button_Close;
		private Panel Panel_Left;
		private Label Label_Logo;
		private Panel Panel_Tabs;
		private Button Button_Merge;
		private Button Button_Settings;
		private Button Button_LanguageSwitcher;
		private Panel Panel_FormsArea;
	}
}