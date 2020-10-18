namespace oop_6115261003_project
{
    partial class Milk
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
            this.txtMId = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtMPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butMAdd = new System.Windows.Forms.Button();
            this.butMEdit = new System.Windows.Forms.Button();
            this.butMDelete = new System.Windows.Forms.Button();
            this.butMDisplay = new System.Windows.Forms.Button();
            this.butMNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อเครื่องดื่ม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ราคา";
            // 
            // txtMId
            // 
            this.txtMId.Location = new System.Drawing.Point(147, 44);
            this.txtMId.Name = "txtMId";
            this.txtMId.Size = new System.Drawing.Size(100, 22);
            this.txtMId.TabIndex = 3;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(147, 92);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(100, 22);
            this.txtMName.TabIndex = 4;
            // 
            // txtMPrice
            // 
            this.txtMPrice.Location = new System.Drawing.Point(147, 142);
            this.txtMPrice.Name = "txtMPrice";
            this.txtMPrice.Size = new System.Drawing.Size(100, 22);
            this.txtMPrice.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(421, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // butMAdd
            // 
            this.butMAdd.Location = new System.Drawing.Point(301, 308);
            this.butMAdd.Name = "butMAdd";
            this.butMAdd.Size = new System.Drawing.Size(75, 35);
            this.butMAdd.TabIndex = 7;
            this.butMAdd.Text = "add";
            this.butMAdd.UseVisualStyleBackColor = true;
            this.butMAdd.Click += new System.EventHandler(this.butMAdd_Click);
            // 
            // butMEdit
            // 
            this.butMEdit.Location = new System.Drawing.Point(402, 308);
            this.butMEdit.Name = "butMEdit";
            this.butMEdit.Size = new System.Drawing.Size(75, 35);
            this.butMEdit.TabIndex = 8;
            this.butMEdit.Text = "edit";
            this.butMEdit.UseVisualStyleBackColor = true;
            this.butMEdit.Click += new System.EventHandler(this.butMEdit_Click);
            // 
            // butMDelete
            // 
            this.butMDelete.Location = new System.Drawing.Point(499, 308);
            this.butMDelete.Name = "butMDelete";
            this.butMDelete.Size = new System.Drawing.Size(75, 35);
            this.butMDelete.TabIndex = 9;
            this.butMDelete.Text = "delete";
            this.butMDelete.UseVisualStyleBackColor = true;
            this.butMDelete.Click += new System.EventHandler(this.butMDelete_Click);
            // 
            // butMDisplay
            // 
            this.butMDisplay.Location = new System.Drawing.Point(594, 308);
            this.butMDisplay.Name = "butMDisplay";
            this.butMDisplay.Size = new System.Drawing.Size(75, 35);
            this.butMDisplay.TabIndex = 10;
            this.butMDisplay.Text = "display";
            this.butMDisplay.UseVisualStyleBackColor = true;
            this.butMDisplay.Click += new System.EventHandler(this.butMDisplay_Click);
            // 
            // butMNext
            // 
            this.butMNext.Location = new System.Drawing.Point(691, 308);
            this.butMNext.Name = "butMNext";
            this.butMNext.Size = new System.Drawing.Size(75, 35);
            this.butMNext.TabIndex = 11;
            this.butMNext.Text = "next";
            this.butMNext.UseVisualStyleBackColor = true;
            this.butMNext.Click += new System.EventHandler(this.butMNext_Click);
            // 
            // Milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.butMNext);
            this.Controls.Add(this.butMDisplay);
            this.Controls.Add(this.butMDelete);
            this.Controls.Add(this.butMEdit);
            this.Controls.Add(this.butMAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMPrice);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtMId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Milk";
            this.Text = "Milk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMId;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtMPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butMAdd;
        private System.Windows.Forms.Button butMEdit;
        private System.Windows.Forms.Button butMDelete;
        private System.Windows.Forms.Button butMDisplay;
        private System.Windows.Forms.Button butMNext;
    }
}

