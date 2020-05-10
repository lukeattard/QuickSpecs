/*
 * Created by SharpDevelop.
 * User: ZHANITEST
 * Date: 2019-07-14
 * Time: 오전 12:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuickSpecs
{
  partial class MainForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageView = new System.Windows.Forms.TabPage();
      this.labelHardDisks = new System.Windows.Forms.Label();
      this.listBoxHardDisk = new System.Windows.Forms.ListBox();
      this.lbPorts = new System.Windows.Forms.ListBox();
      this.tbOs = new System.Windows.Forms.TextBox();
      this.tbRam = new System.Windows.Forms.TextBox();
      this.tbGpu = new System.Windows.Forms.TextBox();
      this.tbCpu = new System.Windows.Forms.TextBox();
      this.labelSerialOpen = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPageText = new System.Windows.Forms.TabPage();
      this.rtbReport = new System.Windows.Forms.RichTextBox();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.fmrAbout = new System.Windows.Forms.Button();
      this.btnOutText = new System.Windows.Forms.Button();
      this.lbStatus = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPageView.SuspendLayout();
      this.tabPageText.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageView);
      this.tabControl1.Controls.Add(this.tabPageText);
      this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabControl1.Location = new System.Drawing.Point(10, 13);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(480, 475);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPageView
      // 
      this.tabPageView.Controls.Add(this.labelHardDisks);
      this.tabPageView.Controls.Add(this.listBoxHardDisk);
      this.tabPageView.Controls.Add(this.lbPorts);
      this.tabPageView.Controls.Add(this.tbOs);
      this.tabPageView.Controls.Add(this.tbRam);
      this.tabPageView.Controls.Add(this.tbGpu);
      this.tabPageView.Controls.Add(this.tbCpu);
      this.tabPageView.Controls.Add(this.labelSerialOpen);
      this.tabPageView.Controls.Add(this.label4);
      this.tabPageView.Controls.Add(this.label3);
      this.tabPageView.Controls.Add(this.label2);
      this.tabPageView.Controls.Add(this.label1);
      this.tabPageView.Location = new System.Drawing.Point(4, 24);
      this.tabPageView.Name = "tabPageView";
      this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageView.Size = new System.Drawing.Size(472, 447);
      this.tabPageView.TabIndex = 0;
      this.tabPageView.Text = "Quick";
      this.tabPageView.UseVisualStyleBackColor = true;
      // 
      // labelHardDisks
      // 
      this.labelHardDisks.Location = new System.Drawing.Point(6, 244);
      this.labelHardDisks.Name = "labelHardDisks";
      this.labelHardDisks.Size = new System.Drawing.Size(463, 25);
      this.labelHardDisks.TabIndex = 10;
      this.labelHardDisks.Text = "Hard Disks:";
      this.labelHardDisks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // listBoxHardDisk
      // 
      this.listBoxHardDisk.FormattingEnabled = true;
      this.listBoxHardDisk.ItemHeight = 15;
      this.listBoxHardDisk.Location = new System.Drawing.Point(5, 272);
      this.listBoxHardDisk.Name = "listBoxHardDisk";
      this.listBoxHardDisk.Size = new System.Drawing.Size(463, 154);
      this.listBoxHardDisk.TabIndex = 9;
      // 
      // lbPorts
      // 
      this.lbPorts.FormattingEnabled = true;
      this.lbPorts.ItemHeight = 15;
      this.lbPorts.Location = new System.Drawing.Point(5, 151);
      this.lbPorts.Name = "lbPorts";
      this.lbPorts.Size = new System.Drawing.Size(463, 79);
      this.lbPorts.TabIndex = 8;
      // 
      // tbOs
      // 
      this.tbOs.Location = new System.Drawing.Point(52, 89);
      this.tbOs.Name = "tbOs";
      this.tbOs.ReadOnly = true;
      this.tbOs.Size = new System.Drawing.Size(416, 21);
      this.tbOs.TabIndex = 7;
      // 
      // tbRam
      // 
      this.tbRam.Location = new System.Drawing.Point(51, 60);
      this.tbRam.Name = "tbRam";
      this.tbRam.ReadOnly = true;
      this.tbRam.Size = new System.Drawing.Size(417, 21);
      this.tbRam.TabIndex = 6;
      // 
      // tbGpu
      // 
      this.tbGpu.Location = new System.Drawing.Point(52, 30);
      this.tbGpu.Name = "tbGpu";
      this.tbGpu.ReadOnly = true;
      this.tbGpu.Size = new System.Drawing.Size(416, 21);
      this.tbGpu.TabIndex = 5;
      // 
      // tbCpu
      // 
      this.tbCpu.Location = new System.Drawing.Point(51, 4);
      this.tbCpu.Name = "tbCpu";
      this.tbCpu.ReadOnly = true;
      this.tbCpu.Size = new System.Drawing.Size(417, 21);
      this.tbCpu.TabIndex = 4;
      // 
      // labelSerialOpen
      // 
      this.labelSerialOpen.Location = new System.Drawing.Point(5, 122);
      this.labelSerialOpen.Name = "labelSerialOpen";
      this.labelSerialOpen.Size = new System.Drawing.Size(463, 25);
      this.labelSerialOpen.TabIndex = 3;
      this.labelSerialOpen.Text = "Currently Opened Serial Port:";
      this.labelSerialOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(5, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 25);
      this.label4.TabIndex = 3;
      this.label4.Text = "OS/SP:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(5, 57);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "RAM:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(5, 28);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "GPU:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(5, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "CPU:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tabPageText
      // 
      this.tabPageText.Controls.Add(this.rtbReport);
      this.tabPageText.Location = new System.Drawing.Point(4, 24);
      this.tabPageText.Name = "tabPageText";
      this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageText.Size = new System.Drawing.Size(472, 447);
      this.tabPageText.TabIndex = 1;
      this.tabPageText.Text = "Plain Text";
      this.tabPageText.UseVisualStyleBackColor = true;
      // 
      // rtbReport
      // 
      this.rtbReport.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbReport.Location = new System.Drawing.Point(6, 8);
      this.rtbReport.Name = "rtbReport";
      this.rtbReport.ReadOnly = true;
      this.rtbReport.Size = new System.Drawing.Size(463, 433);
      this.rtbReport.TabIndex = 0;
      this.rtbReport.Text = "";
      // 
      // btnRefresh
      // 
      this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRefresh.Location = new System.Drawing.Point(14, 495);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(64, 25);
      this.btnRefresh.TabIndex = 2;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
      // 
      // fmrAbout
      // 
      this.fmrAbout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.fmrAbout.Location = new System.Drawing.Point(457, 495);
      this.fmrAbout.Name = "fmrAbout";
      this.fmrAbout.Size = new System.Drawing.Size(26, 25);
      this.fmrAbout.TabIndex = 3;
      this.fmrAbout.Text = "&?";
      this.fmrAbout.UseVisualStyleBackColor = true;
      this.fmrAbout.Click += new System.EventHandler(this.fmrAboutClick);
      // 
      // btnOutText
      // 
      this.btnOutText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOutText.Location = new System.Drawing.Point(105, 495);
      this.btnOutText.Name = "btnOutText";
      this.btnOutText.Size = new System.Drawing.Size(64, 25);
      this.btnOutText.TabIndex = 4;
      this.btnOutText.Text = "Get text file";
      this.btnOutText.UseVisualStyleBackColor = true;
      this.btnOutText.Click += new System.EventHandler(this.BtnOutTextClick);
      // 
      // lbStatus
      // 
      this.lbStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbStatus.ForeColor = System.Drawing.Color.Blue;
      this.lbStatus.Location = new System.Drawing.Point(175, 500);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(171, 20);
      this.lbStatus.TabIndex = 5;
      this.lbStatus.Text = "Updated! - 2019/07/14 05:00:00";
      this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(505, 529);
      this.Controls.Add(this.lbStatus);
      this.Controls.Add(this.btnOutText);
      this.Controls.Add(this.fmrAbout);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quick Spec";
      this.Load += new System.EventHandler(this.MainFormLoad);
      this.tabControl1.ResumeLayout(false);
      this.tabPageView.ResumeLayout(false);
      this.tabPageView.PerformLayout();
      this.tabPageText.ResumeLayout(false);
      this.ResumeLayout(false);

    }
    private System.Windows.Forms.Label labelSerialOpen;
    private System.Windows.Forms.ListBox lbPorts;
    private System.Windows.Forms.Label lbStatus;
    private System.Windows.Forms.TextBox tbGpu;
    private System.Windows.Forms.TextBox tbRam;
    private System.Windows.Forms.TextBox tbOs;
    private System.Windows.Forms.TextBox tbCpu;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnOutText;
    private System.Windows.Forms.RichTextBox rtbReport;
    private System.Windows.Forms.Button fmrAbout;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TabPage tabPageText;
    private System.Windows.Forms.TabPage tabPageView;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.Label labelHardDisks;
    private System.Windows.Forms.ListBox listBoxHardDisk;
  }
}
