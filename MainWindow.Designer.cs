namespace MouseTester
{
  partial class MainWindow
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      logLabel = new System.Windows.Forms.Label();
      SuspendLayout();
      // 
      // logLabel
      // 
      logLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      logLabel.Location = new System.Drawing.Point(0, 0);
      logLabel.Name = "logLabel";
      logLabel.Size = new System.Drawing.Size(800, 450);
      logLabel.TabIndex = 0;
      logLabel.Text = "Awaiting input";
      logLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainWindow
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(800, 450);
      Controls.Add(this.logLabel);
      FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      Name = "MainWindow";
      Text = "Mouse Tester";
      ResumeLayout(false);
    }

    #endregion

    private Label logLabel;
  }
}