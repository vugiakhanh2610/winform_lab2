﻿namespace DemoCRUD.Views {
  partial class MainView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnShowPetView = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnShowPetView);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(269, 1048);
      this.panel1.TabIndex = 0;
      // 
      // btnShowPetView
      // 
      this.btnShowPetView.Location = new System.Drawing.Point(3, 74);
      this.btnShowPetView.Name = "btnShowPetView";
      this.btnShowPetView.Size = new System.Drawing.Size(266, 95);
      this.btnShowPetView.TabIndex = 0;
      this.btnShowPetView.Text = "Pets";
      this.btnShowPetView.UseVisualStyleBackColor = true;
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1900, 1048);
      this.Controls.Add(this.panel1);
      this.IsMdiContainer = true;
      this.Name = "MainView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MainView";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnShowPetView;
  }
}