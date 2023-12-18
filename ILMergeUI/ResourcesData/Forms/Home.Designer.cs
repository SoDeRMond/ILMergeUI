using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace ILMergeUI.ResourcesData.Forms
{
	public partial class Home
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
			this.GroupBox_ProgramUpdate = new GroupBox();
			this.Label_UpdateStatus = new Label();
			this.Label_ChangeLog = new Label();
			this.Panel_Content = new Panel();
			this.Panel_Layer = new Panel();
			this.Button_DownloadAndRun = new Button();
			this.Panel_Bottom = new Panel();
			this.LinkLabel_GitHub = new LinkLabel();
			this.Label_Copyright = new Label();
			this.Panel_Top.SuspendLayout();
			this.GroupBox_ProgramUpdate.SuspendLayout();
			this.Panel_Content.SuspendLayout();
			this.Panel_Bottom.SuspendLayout();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Panel_Top);
			this.Controls.Add(this.Panel_Bottom);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "Home";
			this.Text = "Home";
			this.Load += new EventHandler(this.Form_Home_Load);
			this.Shown += new EventHandler(this.Form_Home_Shown);
			this.SizeChanged += new EventHandler(this.Form_Home_SizeChanged);
			this.Panel_Top.ResumeLayout(false);
			this.GroupBox_ProgramUpdate.ResumeLayout(false);
			this.Panel_Content.ResumeLayout(false);
			this.Panel_Content.PerformLayout();
			this.Panel_Bottom.ResumeLayout(false);
			this.ResumeLayout(false);

			this.Panel_Top.Controls.Add(this.GroupBox_ProgramUpdate);
			this.Panel_Top.Dock = DockStyle.Fill;
			this.Panel_Top.Location = new Point(0, 0);
			this.Panel_Top.Name = "Panel_Top";
			this.Panel_Top.Padding = new Padding(4, 2, 4, 2);
			this.Panel_Top.Size = new Size(760, 520);
			this.Panel_Top.TabIndex = 0;

			this.GroupBox_ProgramUpdate.Controls.Add(this.Panel_Content);
			this.GroupBox_ProgramUpdate.Controls.Add(this.Panel_Layer);
			this.GroupBox_ProgramUpdate.Controls.Add(this.Button_DownloadAndRun);
			this.GroupBox_ProgramUpdate.Controls.Add(this.Label_ChangeLog);
			this.GroupBox_ProgramUpdate.Controls.Add(this.Label_UpdateStatus);
			this.GroupBox_ProgramUpdate.Dock = DockStyle.Fill;
			this.GroupBox_ProgramUpdate.Font = new Font("Microsoft Sans Serif", 12F);
			this.GroupBox_ProgramUpdate.ForeColor = Color.White;
			this.GroupBox_ProgramUpdate.Location = new Point(4, 2);
			this.GroupBox_ProgramUpdate.Name = "GroupBox_ProgramUpdate";
			this.GroupBox_ProgramUpdate.Size = new Size(752, 516);
			this.GroupBox_ProgramUpdate.TabIndex = 0;
			this.GroupBox_ProgramUpdate.TabStop = false;
			this.GroupBox_ProgramUpdate.Text = "Program Update";
			this.GroupBox_ProgramUpdate.TextChanged += new EventHandler(this.GroupBox_ProgramUpdate_TextChanged);

			this.Label_UpdateStatus.Dock = DockStyle.Top;
			this.Label_UpdateStatus.Font = new Font("Microsoft Sans Serif", 10F);
			this.Label_UpdateStatus.Location = new Point(3, 22);
			this.Label_UpdateStatus.Name = "Label_UpdateStatus";
			this.Label_UpdateStatus.Padding = new Padding(4, 2, 0, 0);
			this.Label_UpdateStatus.Size = new Size(746, 22);
			this.Label_UpdateStatus.TabIndex = 0;
			this.Label_UpdateStatus.TextAlign = ContentAlignment.MiddleLeft;

			this.Label_ChangeLog.Dock = DockStyle.Top;
			this.Label_ChangeLog.Font = new Font("Microsoft Sans Serif", 10F);
			this.Label_ChangeLog.Location = new Point(3, 44);
			this.Label_ChangeLog.Name = "Label_ChangeLog";
			this.Label_ChangeLog.Padding = new Padding(4, 0, 0, 2);
			this.Label_ChangeLog.Size = new Size(746, 22);
			this.Label_ChangeLog.TabIndex = 0;
			this.Label_ChangeLog.Text = "♦ Change Log in Updated Version";
			this.Label_ChangeLog.TextAlign = ContentAlignment.MiddleLeft;

			this.Panel_Content.BorderStyle = BorderStyle.FixedSingle;
			this.Panel_Content.Dock = DockStyle.Fill;
			this.Panel_Content.Location = new Point(3, 66);
			this.Panel_Content.Name = "Panel_Content";
			this.Panel_Content.Size = new Size(746, 415);
			this.Panel_Content.TabIndex = 0;

			this.Panel_Layer.Dock = DockStyle.Bottom;
			this.Panel_Layer.Location = new Point(3, 481);
			this.Panel_Layer.Name = "Panel_Layer";
			this.Panel_Layer.Size = new Size(746, 2);
			this.Panel_Layer.TabIndex = 0;

			this.Button_DownloadAndRun.Dock = DockStyle.Bottom;
			this.Button_DownloadAndRun.Enabled = false;
			this.Button_DownloadAndRun.FlatAppearance.BorderSize = 0;
			this.Button_DownloadAndRun.FlatStyle = FlatStyle.Flat;
			this.Button_DownloadAndRun.Font = new Font("Microsoft Sans Serif", 10F);
			this.Button_DownloadAndRun.Location = new Point(3, 483);
			this.Button_DownloadAndRun.Name = "Button_DownloadAndRun";
			this.Button_DownloadAndRun.Size = new Size(746, 30);
			this.Button_DownloadAndRun.TabIndex = 0;
			this.Button_DownloadAndRun.Text = "Download and Run";
			this.Button_DownloadAndRun.Click += new EventHandler(this.Button_DownloadAndRun_Click);

			this.Panel_Bottom.Controls.Add(this.LinkLabel_GitHub);
			this.Panel_Bottom.Controls.Add(this.Label_Copyright);
			this.Panel_Bottom.Dock = DockStyle.Bottom;
			this.Panel_Bottom.Location = new Point(0, 520);
			this.Panel_Bottom.Name = "Panel_Bottom";
			this.Panel_Bottom.Padding = new Padding(0, 0, 1, 4);
			this.Panel_Bottom.Size = new Size(760, 20);
			this.Panel_Bottom.TabIndex = 0;

			this.LinkLabel_GitHub.ActiveLinkColor = Color.Gray;
			this.LinkLabel_GitHub.Dock = DockStyle.Right;
			this.LinkLabel_GitHub.Font = new Font("Microsoft Sans Serif", 8F);
			this.LinkLabel_GitHub.LinkBehavior = LinkBehavior.NeverUnderline;
			this.LinkLabel_GitHub.LinkColor = Color.Silver;
			this.LinkLabel_GitHub.Location = new Point(606, 0);
			this.LinkLabel_GitHub.Name = "LinkLabel_GitHub";
			this.LinkLabel_GitHub.Size = new Size(41, 16);
			this.LinkLabel_GitHub.TabIndex = 0;
			this.LinkLabel_GitHub.TabStop = true;
			this.LinkLabel_GitHub.Text = "GitHub";
			this.LinkLabel_GitHub.TextAlign = ContentAlignment.MiddleCenter;
			this.LinkLabel_GitHub.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabel_GitHub_LinkClicked);

			this.Label_Copyright.Dock = DockStyle.Right;
			this.Label_Copyright.Font = new Font("Microsoft Sans Serif", 8F);
			this.Label_Copyright.ForeColor = Color.White;
			this.Label_Copyright.Location = new Point(647, 0);
			this.Label_Copyright.Name = "Label_Copyright";
			this.Label_Copyright.Size = new Size(112, 16);
			this.Label_Copyright.TabIndex = 0;
			this.Label_Copyright.Text = "© SoDeRMond, 2023";
			this.Label_Copyright.TextAlign = ContentAlignment.MiddleCenter;
		}

		private Panel Panel_Top;
		private GroupBox GroupBox_ProgramUpdate;
		private Label Label_UpdateStatus;
		private Label Label_ChangeLog;
		private Panel Panel_Content;
		private Panel Panel_Layer;
		private Button Button_DownloadAndRun;
		private Panel Panel_Bottom;
		private LinkLabel LinkLabel_GitHub;
		private Label Label_Copyright;
	}
}