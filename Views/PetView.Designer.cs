namespace DemoCRUD.Views {
  partial class PetView {
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
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPagePetList = new System.Windows.Forms.TabPage();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.btnCreate = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.inputKeyword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tabPagePetDetail = new System.Windows.Forms.TabPage();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.inputPetName = new System.Windows.Forms.TextBox();
      this.inputPetColor = new System.Windows.Forms.TextBox();
      this.inputPetId = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.tabPagePetList.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.tabPagePetDetail.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(41, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "PETS";
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1170, 90);
      this.panel1.TabIndex = 1;
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPagePetList);
      this.tabControl.Controls.Add(this.tabPagePetDetail);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(1170, 711);
      this.tabControl.TabIndex = 2;
      // 
      // tabPagePetList
      // 
      this.tabPagePetList.Controls.Add(this.dataGridView);
      this.tabPagePetList.Controls.Add(this.btnCreate);
      this.tabPagePetList.Controls.Add(this.btnUpdate);
      this.tabPagePetList.Controls.Add(this.btnDelete);
      this.tabPagePetList.Controls.Add(this.btnSearch);
      this.tabPagePetList.Controls.Add(this.inputKeyword);
      this.tabPagePetList.Controls.Add(this.label2);
      this.tabPagePetList.Location = new System.Drawing.Point(8, 39);
      this.tabPagePetList.Name = "tabPagePetList";
      this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
      this.tabPagePetList.Size = new System.Drawing.Size(1154, 664);
      this.tabPagePetList.TabIndex = 0;
      this.tabPagePetList.Text = "Pet list";
      this.tabPagePetList.UseVisualStyleBackColor = true;
      // 
      // dataGridView
      // 
      this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Location = new System.Drawing.Point(44, 153);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowHeadersWidth = 82;
      this.dataGridView.RowTemplate.Height = 33;
      this.dataGridView.Size = new System.Drawing.Size(922, 393);
      this.dataGridView.TabIndex = 6;
      // 
      // btnCreate
      // 
      this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCreate.Location = new System.Drawing.Point(999, 153);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(102, 65);
      this.btnCreate.TabIndex = 5;
      this.btnCreate.Text = "Create";
      this.btnCreate.UseVisualStyleBackColor = true;
      // 
      // btnUpdate
      // 
      this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnUpdate.Location = new System.Drawing.Point(999, 237);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(102, 64);
      this.btnUpdate.TabIndex = 4;
      this.btnUpdate.Text = "Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDelete.Location = new System.Drawing.Point(999, 325);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(102, 60);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.Location = new System.Drawing.Point(864, 77);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(102, 47);
      this.btnSearch.TabIndex = 2;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      // 
      // inputKeyword
      // 
      this.inputKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.inputKeyword.Location = new System.Drawing.Point(44, 77);
      this.inputKeyword.Name = "inputKeyword";
      this.inputKeyword.Size = new System.Drawing.Size(805, 31);
      this.inputKeyword.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(56, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(118, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "Search Pet";
      // 
      // tabPagePetDetail
      // 
      this.tabPagePetDetail.Controls.Add(this.btnCancel);
      this.tabPagePetDetail.Controls.Add(this.btnSave);
      this.tabPagePetDetail.Controls.Add(this.inputPetName);
      this.tabPagePetDetail.Controls.Add(this.inputPetColor);
      this.tabPagePetDetail.Controls.Add(this.inputPetId);
      this.tabPagePetDetail.Controls.Add(this.label5);
      this.tabPagePetDetail.Controls.Add(this.label4);
      this.tabPagePetDetail.Controls.Add(this.label3);
      this.tabPagePetDetail.Location = new System.Drawing.Point(8, 39);
      this.tabPagePetDetail.Name = "tabPagePetDetail";
      this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
      this.tabPagePetDetail.Size = new System.Drawing.Size(1154, 664);
      this.tabPagePetDetail.TabIndex = 1;
      this.tabPagePetDetail.Text = "Pet detail";
      this.tabPagePetDetail.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(316, 340);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(119, 51);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(71, 340);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(119, 51);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // inputPetName
      // 
      this.inputPetName.Location = new System.Drawing.Point(60, 157);
      this.inputPetName.Name = "inputPetName";
      this.inputPetName.Size = new System.Drawing.Size(191, 31);
      this.inputPetName.TabIndex = 5;
      // 
      // inputPetColor
      // 
      this.inputPetColor.Location = new System.Drawing.Point(60, 260);
      this.inputPetColor.Name = "inputPetColor";
      this.inputPetColor.Size = new System.Drawing.Size(191, 31);
      this.inputPetColor.TabIndex = 4;
      // 
      // inputPetId
      // 
      this.inputPetId.Location = new System.Drawing.Point(60, 64);
      this.inputPetId.Name = "inputPetId";
      this.inputPetId.ReadOnly = true;
      this.inputPetId.Size = new System.Drawing.Size(191, 31);
      this.inputPetId.TabIndex = 3;
      this.inputPetId.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(55, 129);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(103, 25);
      this.label5.TabIndex = 2;
      this.label5.Text = "Pet name";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(55, 232);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(97, 25);
      this.label4.TabIndex = 1;
      this.label4.Text = "Pet color";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(55, 36);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 25);
      this.label3.TabIndex = 0;
      this.label3.Text = "Pet ID";
      // 
      // PetView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1170, 711);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.panel1);
      this.Name = "PetView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PetView";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl.ResumeLayout(false);
      this.tabPagePetList.ResumeLayout(false);
      this.tabPagePetList.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.tabPagePetDetail.ResumeLayout(false);
      this.tabPagePetDetail.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPagePetList;
    private System.Windows.Forms.TabPage tabPagePetDetail;
    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox inputKeyword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox inputPetName;
    private System.Windows.Forms.TextBox inputPetColor;
    private System.Windows.Forms.TextBox inputPetId;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
  }
}