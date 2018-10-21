namespace Calculator.GUI
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyListView = new System.Windows.Forms.ListView();
            this.firstOperand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secondOperand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 57);
            this.panel1.TabIndex = 3;
            // 
            // historyListView
            // 
            this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstOperand,
            this.typeOperation,
            this.secondOperand,
            this.result});
            this.historyListView.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyListView.GridLines = true;
            this.historyListView.Location = new System.Drawing.Point(12, 63);
            this.historyListView.Name = "historyListView";
            this.historyListView.Size = new System.Drawing.Size(643, 503);
            this.historyListView.TabIndex = 4;
            this.historyListView.UseCompatibleStateImageBehavior = false;
            this.historyListView.View = System.Windows.Forms.View.Details;
            // 
            // firstOperand
            // 
            this.firstOperand.Text = "First Operand";
            this.firstOperand.Width = 150;
            // 
            // typeOperation
            // 
            this.typeOperation.Text = "Type Operation";
            this.typeOperation.Width = 50;
            // 
            // secondOperand
            // 
            this.secondOperand.Text = "Second Operand";
            this.secondOperand.Width = 150;
            // 
            // result
            // 
            this.result.Text = "Result";
            this.result.Width = 150;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 578);
            this.Controls.Add(this.historyListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "History";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView historyListView;
        private System.Windows.Forms.ColumnHeader firstOperand;
        private System.Windows.Forms.ColumnHeader typeOperation;
        private System.Windows.Forms.ColumnHeader secondOperand;
        private System.Windows.Forms.ColumnHeader result;
    }
}