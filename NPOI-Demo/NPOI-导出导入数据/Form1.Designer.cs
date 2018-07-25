namespace NPOI_Demo1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvListImport = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.dgvListExport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListExport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(117, 168);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvListImport
            // 
            this.dgvListImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListImport.Location = new System.Drawing.Point(12, 12);
            this.dgvListImport.Name = "dgvListImport";
            this.dgvListImport.RowTemplate.Height = 23;
            this.dgvListImport.Size = new System.Drawing.Size(442, 150);
            this.dgvListImport.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 168);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "查询数据";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 240);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvListExport
            // 
            this.dgvListExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListExport.Location = new System.Drawing.Point(12, 287);
            this.dgvListExport.Name = "dgvListExport";
            this.dgvListExport.RowTemplate.Height = 23;
            this.dgvListExport.Size = new System.Drawing.Size(442, 150);
            this.dgvListExport.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 507);
            this.Controls.Add(this.dgvListExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvListImport);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvListImport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView dgvListExport;
    }
}

