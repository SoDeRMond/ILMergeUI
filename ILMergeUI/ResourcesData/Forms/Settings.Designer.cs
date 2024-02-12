using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace ILMergeUI.ResourcesData.Forms
{
	public partial class Settings
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
			this.Panel_SavePath = new Panel();
			this.Label_SavePath = new Label();
			this.TextBox_SavePath = new TextBox();
			this.Panel_Left = new Panel();
			this.GroupBox_AutoProgramUpdates = new GroupBox();
			this.RadioButton_AutoProgramUpdates_Enable = new RadioButton();
			this.RadioButton_AutoProgramUpdates_Disable = new RadioButton();
			this.Panel_Layer = new Panel();
			this.Button_DeleteSavedProgramFiles = new Button();
			this.Panel_Right = new Panel();
			this.GroupBox_SavingFileAfterMerging = new GroupBox();
			this.RadioButton_SavingFileAfterMerging_Enable = new RadioButton();
			this.RadioButton_SavingFileAfterMerging_Disable = new RadioButton();
			this.SaveFileDialog_SavePath = new SaveFileDialog();
			this.Panel_Top.SuspendLayout();
			this.Panel_SavePath.SuspendLayout();
			this.Panel_Left.SuspendLayout();
			this.GroupBox_AutoProgramUpdates.SuspendLayout();
			this.Panel_Right.SuspendLayout();
			this.GroupBox_SavingFileAfterMerging.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Panel_Right);
			this.Controls.Add(this.Panel_Left);
			this.Controls.Add(this.Panel_Top);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "Settings";
			this.Text = "Settings";
			this.Load += new EventHandler(this.Form_Settings_Load);
			this.Shown += new EventHandler(this.Form_Settings_Shown);
			this.SizeChanged += new EventHandler(this.Form_Settings_SizeChanged);
			this.Panel_Top.ResumeLayout(false);
			this.Panel_SavePath.ResumeLayout(false);
			this.Panel_SavePath.PerformLayout();
			this.Panel_Left.ResumeLayout(false);
			this.GroupBox_AutoProgramUpdates.ResumeLayout(false);
			this.Panel_Right.ResumeLayout(false);
			this.GroupBox_SavingFileAfterMerging.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Top.Controls.Add(this.Panel_SavePath);
			this.Panel_Top.Dock = DockStyle.Top;
			this.Panel_Top.Location = new Point(0, 0);
			this.Panel_Top.Name = "Panel_Top";
			this.Panel_Top.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Top.Size = new Size(760, 28);
			this.Panel_Top.TabIndex = 0;

			this.Panel_SavePath.BorderStyle = BorderStyle.FixedSingle;
			this.Panel_SavePath.Controls.Add(this.TextBox_SavePath);
			this.Panel_SavePath.Controls.Add(this.Label_SavePath);
			this.Panel_SavePath.Dock = DockStyle.Fill;
			this.Panel_SavePath.Location = new Point(4, 2);
			this.Panel_SavePath.Name = "Panel_SavePath";
			this.Panel_SavePath.Size = new Size(752, 24);
			this.Panel_SavePath.TabIndex = 0;

			this.Label_SavePath.AutoSize = true;
			this.Label_SavePath.Dock = DockStyle.Left;
			this.Label_SavePath.Font = new Font("Microsoft Sans Serif", 12F);
			this.Label_SavePath.ForeColor = Color.Silver;
			this.Label_SavePath.Location = new Point(0, 0);
			this.Label_SavePath.Name = "Label_SavePath";
			this.Label_SavePath.Size = new Size(91, 20);
			this.Label_SavePath.TabIndex = 0;
			this.Label_SavePath.Text = "Save Path -";
			this.Label_SavePath.TextAlign = ContentAlignment.MiddleCenter;

			this.TextBox_SavePath.BackColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
			this.TextBox_SavePath.BorderStyle = BorderStyle.None;
			this.TextBox_SavePath.Dock = DockStyle.Fill;
			this.TextBox_SavePath.Font = new Font("Microsoft Sans Serif", 13F);
			this.TextBox_SavePath.ForeColor = Color.WhiteSmoke;
			this.TextBox_SavePath.Location = new Point(91, 0);
			this.TextBox_SavePath.Name = "TextBox_SavePath";
			this.TextBox_SavePath.ReadOnly = true;
			this.TextBox_SavePath.Size = new Size(659, 20);
			this.TextBox_SavePath.TabIndex = 0;
			this.TextBox_SavePath.DoubleClick += new EventHandler(this.TextBox_SavePath_DoubleClick);

			this.Panel_Left.Controls.Add(this.Button_DeleteSavedProgramFiles);
			this.Panel_Left.Controls.Add(this.Panel_Layer);
			this.Panel_Left.Controls.Add(this.GroupBox_AutoProgramUpdates);
			this.Panel_Left.Dock = DockStyle.Left;
			this.Panel_Left.Location = new Point(0, 28);
			this.Panel_Left.Name = "Panel_Left";
			this.Panel_Left.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Left.Size = new Size(380, 512);
			this.Panel_Left.TabIndex = 0;

			this.GroupBox_AutoProgramUpdates.Controls.Add(this.RadioButton_AutoProgramUpdates_Disable);
			this.GroupBox_AutoProgramUpdates.Controls.Add(this.RadioButton_AutoProgramUpdates_Enable);
			this.GroupBox_AutoProgramUpdates.Dock = DockStyle.Top;
			this.GroupBox_AutoProgramUpdates.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_AutoProgramUpdates.ForeColor = Color.White;
			this.GroupBox_AutoProgramUpdates.Location = new Point(4, 2);
			this.GroupBox_AutoProgramUpdates.Name = "GroupBox_AutoProgramUpdates";
			this.GroupBox_AutoProgramUpdates.Size = new Size(372, 70);
			this.GroupBox_AutoProgramUpdates.TabIndex = 0;
			this.GroupBox_AutoProgramUpdates.TabStop = false;
			this.GroupBox_AutoProgramUpdates.Text = "Auto Program Updates";

			this.RadioButton_AutoProgramUpdates_Enable.Dock = DockStyle.Top;
			this.RadioButton_AutoProgramUpdates_Enable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_AutoProgramUpdates_Enable.Location = new Point(3, 22);
			this.RadioButton_AutoProgramUpdates_Enable.Name = "RadioButton_AutoProgramUpdates_Enable";
			this.RadioButton_AutoProgramUpdates_Enable.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_AutoProgramUpdates_Enable.Size = new Size(366, 23);
			this.RadioButton_AutoProgramUpdates_Enable.TabIndex = 0;
			this.RadioButton_AutoProgramUpdates_Enable.Text = "Enable";
			this.RadioButton_AutoProgramUpdates_Enable.Click += new EventHandler(this.RadioButtons_AutoProgramUpdates_Click);

			this.RadioButton_AutoProgramUpdates_Disable.Dock = DockStyle.Top;
			this.RadioButton_AutoProgramUpdates_Disable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_AutoProgramUpdates_Disable.Location = new Point(3, 45);
			this.RadioButton_AutoProgramUpdates_Disable.Name = "RadioButton_AutoProgramUpdates_Disable";
			this.RadioButton_AutoProgramUpdates_Disable.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_AutoProgramUpdates_Disable.Size = new Size(366, 21);
			this.RadioButton_AutoProgramUpdates_Disable.TabIndex = 1;
			this.RadioButton_AutoProgramUpdates_Disable.Text = "Disable";
			this.RadioButton_AutoProgramUpdates_Disable.Click += new EventHandler(this.RadioButtons_AutoProgramUpdates_Click);

			this.Panel_Layer.Dock = DockStyle.Top;
			this.Panel_Layer.Location = new Point(4, 72);
			this.Panel_Layer.Name = "Panel_Layer";
			this.Panel_Layer.Size = new Size(372, 2);
			this.Panel_Layer.TabIndex = 0;

			this.Button_DeleteSavedProgramFiles.Dock = DockStyle.Top;
			this.Button_DeleteSavedProgramFiles.FlatAppearance.BorderSize = 0;
			this.Button_DeleteSavedProgramFiles.FlatStyle = FlatStyle.Flat;
			this.Button_DeleteSavedProgramFiles.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_DeleteSavedProgramFiles.ForeColor = Color.White;
			this.Button_DeleteSavedProgramFiles.Location = new Point(4, 74);
			this.Button_DeleteSavedProgramFiles.Name = "Button_DeleteSavedProgramFiles";
			this.Button_DeleteSavedProgramFiles.Size = new Size(372, 30);
			this.Button_DeleteSavedProgramFiles.TabIndex = 0;
			this.Button_DeleteSavedProgramFiles.Text = "Delete Saved Program Files";
			this.Button_DeleteSavedProgramFiles.Click += new EventHandler(this.Button_DeleteSavedProgramFiles_Click);

			this.Panel_Right.Controls.Add(this.GroupBox_SavingFileAfterMerging);
			this.Panel_Right.Dock = DockStyle.Fill;
			this.Panel_Right.Location = new Point(380, 28);
			this.Panel_Right.Name = "Panel_Right";
			this.Panel_Right.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Right.Size = new Size(380, 512);
			this.Panel_Right.TabIndex = 0;

			this.GroupBox_SavingFileAfterMerging.Controls.Add(this.RadioButton_SavingFileAfterMerging_Disable);
			this.GroupBox_SavingFileAfterMerging.Controls.Add(this.RadioButton_SavingFileAfterMerging_Enable);
			this.GroupBox_SavingFileAfterMerging.Dock = DockStyle.Top;
			this.GroupBox_SavingFileAfterMerging.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_SavingFileAfterMerging.ForeColor = Color.White;
			this.GroupBox_SavingFileAfterMerging.Location = new Point(4, 2);
			this.GroupBox_SavingFileAfterMerging.Name = "GroupBox_SavingFileAfterMerging";
			this.GroupBox_SavingFileAfterMerging.Size = new Size(372, 70);
			this.GroupBox_SavingFileAfterMerging.TabIndex = 0;
			this.GroupBox_SavingFileAfterMerging.TabStop = false;
			this.GroupBox_SavingFileAfterMerging.Text = "Saving .pdb File After Merging";

			this.RadioButton_SavingFileAfterMerging_Enable.Dock = DockStyle.Top;
			this.RadioButton_SavingFileAfterMerging_Enable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_SavingFileAfterMerging_Enable.Location = new Point(3, 22);
			this.RadioButton_SavingFileAfterMerging_Enable.Name = "RadioButton_SavingFileAfterMerging_Enable";
			this.RadioButton_SavingFileAfterMerging_Enable.Padding = new Padding(4, 2, 0, 0);
			this.RadioButton_SavingFileAfterMerging_Enable.Size = new Size(366, 23);
			this.RadioButton_SavingFileAfterMerging_Enable.TabIndex = 0;
			this.RadioButton_SavingFileAfterMerging_Enable.Text = "Enable";
			this.RadioButton_SavingFileAfterMerging_Enable.Click += new EventHandler(this.RadioButtons_SavingFileAfterMerging_Click);

			this.RadioButton_SavingFileAfterMerging_Disable.Dock = DockStyle.Top;
			this.RadioButton_SavingFileAfterMerging_Disable.Font = new Font("Microsoft Sans Serif", 10F);
			this.RadioButton_SavingFileAfterMerging_Disable.Location = new Point(3, 45);
			this.RadioButton_SavingFileAfterMerging_Disable.Name = "RadioButton_SavingFileAfterMerging_Disable";
			this.RadioButton_SavingFileAfterMerging_Disable.Padding = new Padding(4, 0, 0, 0);
			this.RadioButton_SavingFileAfterMerging_Disable.Size = new Size(366, 21);
			this.RadioButton_SavingFileAfterMerging_Disable.TabIndex = 1;
			this.RadioButton_SavingFileAfterMerging_Disable.Text = "Disable";
			this.RadioButton_SavingFileAfterMerging_Disable.Click += new EventHandler(this.RadioButtons_SavingFileAfterMerging_Click);
		}

		private Panel Panel_Top;
		private Panel Panel_SavePath;
		private Label Label_SavePath;
		private TextBox TextBox_SavePath;
		private Panel Panel_Left;
		private GroupBox GroupBox_AutoProgramUpdates;
		private RadioButton RadioButton_AutoProgramUpdates_Enable;
		private RadioButton RadioButton_AutoProgramUpdates_Disable;
		private Panel Panel_Layer;
		private Button Button_DeleteSavedProgramFiles;
		private Panel Panel_Right;
		private GroupBox GroupBox_SavingFileAfterMerging;
		private RadioButton RadioButton_SavingFileAfterMerging_Enable;
		private RadioButton RadioButton_SavingFileAfterMerging_Disable;
		private SaveFileDialog SaveFileDialog_SavePath;
	}
}