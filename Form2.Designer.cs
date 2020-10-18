namespace oop_6115261003_project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radButDDHot = new System.Windows.Forms.RadioButton();
            this.radButDDCool = new System.Windows.Forms.RadioButton();
            this.radButDDfrappe = new System.Windows.Forms.RadioButton();
            this.txtDDId = new System.Windows.Forms.TextBox();
            this.txtDDName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butDDAdd = new System.Windows.Forms.Button();
            this.butDDEdit = new System.Windows.Forms.Button();
            this.butDDDelete = new System.Windows.Forms.Button();
            this.butDDDisplay = new System.Windows.Forms.Button();
            this.butDDNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "รูปแบบ";
            // 
            // radButDDHot
            // 
            this.radButDDHot.AutoSize = true;
            this.radButDDHot.Location = new System.Drawing.Point(33, 186);
            this.radButDDHot.Name = "radButDDHot";
            this.radButDDHot.Size = new System.Drawing.Size(52, 21);
            this.radButDDHot.TabIndex = 3;
            this.radButDDHot.TabStop = true;
            this.radButDDHot.Text = "ร้อน";
            this.radButDDHot.UseVisualStyleBackColor = true;
            // 
            // radButDDCool
            // 
            this.radButDDCool.AutoSize = true;
            this.radButDDCool.Location = new System.Drawing.Point(106, 186);
            this.radButDDCool.Name = "radButDDCool";
            this.radButDDCool.Size = new System.Drawing.Size(49, 21);
            this.radButDDCool.TabIndex = 4;
            this.radButDDCool.TabStop = true;
            this.radButDDCool.Text = "เย็น";
            this.radButDDCool.UseVisualStyleBackColor = true;
            // 
            // radButDDfrappe
            // 
            this.radButDDfrappe.AutoSize = true;
            this.radButDDfrappe.Location = new System.Drawing.Point(177, 186);
            this.radButDDfrappe.Name = "radButDDfrappe";
            this.radButDDfrappe.Size = new System.Drawing.Size(46, 21);
            this.radButDDfrappe.TabIndex = 5;
            this.radButDDfrappe.TabStop = true;
            this.radButDDfrappe.Text = "ปั่น";
            this.radButDDfrappe.UseVisualStyleBackColor = true;
            // 
            // txtDDId
            // 
            this.txtDDId.Location = new System.Drawing.Point(135, 42);
            this.txtDDId.Name = "txtDDId";
            this.txtDDId.Size = new System.Drawing.Size(100, 22);
            this.txtDDId.TabIndex = 6;
            // 
            // txtDDName
            // 
            this.txtDDName.Location = new System.Drawing.Point(135, 89);
            this.txtDDName.Name = "txtDDName";
            this.txtDDName.Size = new System.Drawing.Size(100, 22);
            this.txtDDName.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 237);
            this.dataGridView1.TabIndex = 8;
            // 
            // butDDAdd
            // 
            this.butDDAdd.Location = new System.Drawing.Point(304, 317);
            this.butDDAdd.Name = "butDDAdd";
            this.butDDAdd.Size = new System.Drawing.Size(75, 31);
            this.butDDAdd.TabIndex = 9;
            this.butDDAdd.Text = "add";
            this.butDDAdd.UseVisualStyleBackColor = true;
            this.butDDAdd.Click += new System.EventHandler(this.butDDAdd_Click);
            // 
            // butDDEdit
            // 
            this.butDDEdit.Location = new System.Drawing.Point(402, 317);
            this.butDDEdit.Name = "butDDEdit";
            this.butDDEdit.Size = new System.Drawing.Size(75, 31);
            this.butDDEdit.TabIndex = 10;
            this.butDDEdit.Text = "edit";
            this.butDDEdit.UseVisualStyleBackColor = true;
            this.butDDEdit.Click += new System.EventHandler(this.butDDEdit_Click);
            // 
            // butDDDelete
            // 
            this.butDDDelete.Location = new System.Drawing.Point(505, 318);
            this.butDDDelete.Name = "butDDDelete";
            this.butDDDelete.Size = new System.Drawing.Size(75, 30);
            this.butDDDelete.TabIndex = 11;
            this.butDDDelete.Text = "delete";
            this.butDDDelete.UseVisualStyleBackColor = true;
            this.butDDDelete.Click += new System.EventHandler(this.butDDDelete_Click);
            // 
            // butDDDisplay
            // 
            this.butDDDisplay.Location = new System.Drawing.Point(605, 318);
            this.butDDDisplay.Name = "butDDDisplay";
            this.butDDDisplay.Size = new System.Drawing.Size(75, 30);
            this.butDDDisplay.TabIndex = 12;
            this.butDDDisplay.Text = "display";
            this.butDDDisplay.UseVisualStyleBackColor = true;
            this.butDDDisplay.Click += new System.EventHandler(this.butDDDisplay_Click);
            // 
            // butDDNext
            // 
            this.butDDNext.Location = new System.Drawing.Point(704, 317);
            this.butDDNext.Name = "butDDNext";
            this.butDDNext.Size = new System.Drawing.Size(75, 31);
            this.butDDNext.TabIndex = 13;
            this.butDDNext.Text = "next";
            this.butDDNext.UseVisualStyleBackColor = true;
            this.butDDNext.Click += new System.EventHandler(this.butDDNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.butDDNext);
            this.Controls.Add(this.butDDDisplay);
            this.Controls.Add(this.butDDDelete);
            this.Controls.Add(this.butDDEdit);
            this.Controls.Add(this.butDDAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDDName);
            this.Controls.Add(this.txtDDId);
            this.Controls.Add(this.radButDDfrappe);
            this.Controls.Add(this.radButDDCool);
            this.Controls.Add(this.radButDDHot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Milk Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radButDDHot;
        private System.Windows.Forms.RadioButton radButDDCool;
        private System.Windows.Forms.RadioButton radButDDfrappe;
        private System.Windows.Forms.TextBox txtDDId;
        private System.Windows.Forms.TextBox txtDDName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butDDAdd;
        private System.Windows.Forms.Button butDDEdit;
        private System.Windows.Forms.Button butDDDelete;
        private System.Windows.Forms.Button butDDDisplay;
        private System.Windows.Forms.Button butDDNext;
    }
}