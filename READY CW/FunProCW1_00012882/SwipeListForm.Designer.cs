
namespace FunProCW1_00012882
{
    partial class SwipeListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_swipe = new System.Windows.Forms.DataGridView();
            this.swipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd_Swipe = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_swipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_swipe
            // 
            this.dgv_swipe.AllowUserToAddRows = false;
            this.dgv_swipe.AllowUserToDeleteRows = false;
            this.dgv_swipe.AutoGenerateColumns = false;
            this.dgv_swipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_swipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.swipeDateDataGridViewTextBoxColumn,
            this.swipeInDataGridViewTextBoxColumn,
            this.swipeOutDataGridViewTextBoxColumn});
            this.dgv_swipe.DataSource = this.swipeBindingSource;
            this.dgv_swipe.Location = new System.Drawing.Point(12, 12);
            this.dgv_swipe.Name = "dgv_swipe";
            this.dgv_swipe.ReadOnly = true;
            this.dgv_swipe.Size = new System.Drawing.Size(544, 213);
            this.dgv_swipe.TabIndex = 0;
            // 
            // swipeBindingSource
            // 
            this.swipeBindingSource.DataSource = typeof(FunProCW1_00012882.DAL.Swipe);
            // 
            // btnAdd_Swipe
            // 
            this.btnAdd_Swipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd_Swipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd_Swipe.Location = new System.Drawing.Point(587, 12);
            this.btnAdd_Swipe.Name = "btnAdd_Swipe";
            this.btnAdd_Swipe.Size = new System.Drawing.Size(92, 213);
            this.btnAdd_Swipe.TabIndex = 1;
            this.btnAdd_Swipe.Text = "Add";
            this.btnAdd_Swipe.UseVisualStyleBackColor = true;
            this.btnAdd_Swipe.Click += new System.EventHandler(this.btnAdd_Swipe_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeDateDataGridViewTextBoxColumn
            // 
            this.swipeDateDataGridViewTextBoxColumn.DataPropertyName = "SwipeDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.swipeDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.swipeDateDataGridViewTextBoxColumn.HeaderText = "SwipeDate";
            this.swipeDateDataGridViewTextBoxColumn.Name = "swipeDateDataGridViewTextBoxColumn";
            this.swipeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeInDataGridViewTextBoxColumn
            // 
            this.swipeInDataGridViewTextBoxColumn.DataPropertyName = "SwipeIn";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.swipeInDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.swipeInDataGridViewTextBoxColumn.HeaderText = "SwipeIn";
            this.swipeInDataGridViewTextBoxColumn.Name = "swipeInDataGridViewTextBoxColumn";
            this.swipeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeOutDataGridViewTextBoxColumn
            // 
            this.swipeOutDataGridViewTextBoxColumn.DataPropertyName = "SwipeOut";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.swipeOutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.swipeOutDataGridViewTextBoxColumn.HeaderText = "SwipeOut";
            this.swipeOutDataGridViewTextBoxColumn.Name = "swipeOutDataGridViewTextBoxColumn";
            this.swipeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SwipeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 260);
            this.Controls.Add(this.btnAdd_Swipe);
            this.Controls.Add(this.dgv_swipe);
            this.Name = "SwipeListForm";
            this.Text = "Swipes";
            this.Load += new System.EventHandler(this.SwipeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_swipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_swipe;
        private System.Windows.Forms.BindingSource swipeBindingSource;
        private System.Windows.Forms.Button btnAdd_Swipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeOutDataGridViewTextBoxColumn;
    }
}