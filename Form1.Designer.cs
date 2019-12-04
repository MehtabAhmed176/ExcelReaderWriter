namespace ReadWriteExcelWinform
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._save_Input_Btn = new System.Windows.Forms.Button();
            this._input_Txt = new System.Windows.Forms.TextBox();
            this.browse_Excel_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._load_DataGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 0;
            // 
            // _save_Input_Btn
            // 
            this._save_Input_Btn.Location = new System.Drawing.Point(321, 92);
            this._save_Input_Btn.Name = "_save_Input_Btn";
            this._save_Input_Btn.Size = new System.Drawing.Size(107, 23);
            this._save_Input_Btn.TabIndex = 1;
            this._save_Input_Btn.Text = "Save";
            this._save_Input_Btn.UseVisualStyleBackColor = true;
            this._save_Input_Btn.Click += new System.EventHandler(this._save_Input_Btn_Click);
            // 
            // _input_Txt
            // 
            this._input_Txt.Location = new System.Drawing.Point(193, 96);
            this._input_Txt.Name = "_input_Txt";
            this._input_Txt.Size = new System.Drawing.Size(122, 20);
            this._input_Txt.TabIndex = 3;
            // 
            // browse_Excel_Btn
            // 
            this.browse_Excel_Btn.Location = new System.Drawing.Point(321, 57);
            this.browse_Excel_Btn.Name = "browse_Excel_Btn";
            this.browse_Excel_Btn.Size = new System.Drawing.Size(107, 23);
            this.browse_Excel_Btn.TabIndex = 4;
            this.browse_Excel_Btn.Text = "Browse Excel";
            this.browse_Excel_Btn.UseVisualStyleBackColor = true;
            this.browse_Excel_Btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Value to Save";
            // 
            // Column
            // 
            this.Column.AutoSize = true;
            this.Column.Location = new System.Drawing.Point(89, 137);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(64, 13);
            this.Column.TabIndex = 6;
            this.Column.Text = "Total Rows:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // _load_DataGrid
            // 
            this._load_DataGrid.Location = new System.Drawing.Point(88, 342);
            this._load_DataGrid.Name = "_load_DataGrid";
            this._load_DataGrid.Size = new System.Drawing.Size(105, 23);
            this._load_DataGrid.TabIndex = 8;
            this._load_DataGrid.Text = "Load Excel Data";
            this._load_DataGrid.UseVisualStyleBackColor = true;
            this._load_DataGrid.Click += new System.EventHandler(this._load_DataGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._load_DataGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Column);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browse_Excel_Btn);
            this.Controls.Add(this._input_Txt);
            this.Controls.Add(this._save_Input_Btn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _save_Input_Btn;
        private System.Windows.Forms.TextBox _input_Txt;
        private System.Windows.Forms.Button browse_Excel_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Column;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button _load_DataGrid;
    }
}

