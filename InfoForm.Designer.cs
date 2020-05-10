/*
 * Created by SharpDevelop.
 * User: ZHANITEST
 * Date: 2019-07-14
 * Time: 오전 2:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuickSpecs
{
  partial class InfoForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.buttonOk = new System.Windows.Forms.Button();
      this.pictureBoxRdLogo = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRdLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 143);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(220, 29);
      this.label1.TabIndex = 1;
      this.label1.Text = "Quick Spec";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 182);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(220, 36);
      this.label2.TabIndex = 2;
      this.label2.Text = "Quick Specs of your current system";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(81, 221);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(75, 23);
      this.buttonOk.TabIndex = 3;
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.Button1Click);
      // 
      // pictureBoxRdLogo
      // 
      this.pictureBoxRdLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pictureBoxRdLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRdLogo.Image")));
      this.pictureBoxRdLogo.InitialImage = null;
      this.pictureBoxRdLogo.Location = new System.Drawing.Point(16, 12);
      this.pictureBoxRdLogo.Name = "pictureBoxRdLogo";
      this.pictureBoxRdLogo.Size = new System.Drawing.Size(216, 128);
      this.pictureBoxRdLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxRdLogo.TabIndex = 0;
      this.pictureBoxRdLogo.TabStop = false;
      // 
      // InfoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(244, 291);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBoxRdLogo);
      this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InfoForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quick Spec";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRdLogo)).EndInit();
      this.ResumeLayout(false);

    }
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBoxRdLogo;
  }
}
