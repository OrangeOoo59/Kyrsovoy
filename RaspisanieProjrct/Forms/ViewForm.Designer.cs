
namespace RaspisanieProjrct.Forms
{
    partial class ViewForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lGroup = new System.Windows.Forms.Label();
            this.lWeek = new System.Windows.Forms.Label();
            this.bUpdatePair = new System.Windows.Forms.Button();
            this.bRemovePair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(16, 40);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(339, 262);
            this.dataGrid.TabIndex = 0;
            // 
            // lGroup
            // 
            this.lGroup.AutoSize = true;
            this.lGroup.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGroup.Location = new System.Drawing.Point(12, 9);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(78, 23);
            this.lGroup.TabIndex = 19;
            this.lGroup.Text = "Группа ";
            // 
            // lWeek
            // 
            this.lWeek.AutoSize = true;
            this.lWeek.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWeek.Location = new System.Drawing.Point(200, 9);
            this.lWeek.Name = "lWeek";
            this.lWeek.Size = new System.Drawing.Size(82, 23);
            this.lWeek.TabIndex = 20;
            this.lWeek.Text = "Неделя ";
            // 
            // bUpdatePair
            // 
            this.bUpdatePair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUpdatePair.Location = new System.Drawing.Point(354, 9);
            this.bUpdatePair.Name = "bUpdatePair";
            this.bUpdatePair.Size = new System.Drawing.Size(94, 25);
            this.bUpdatePair.TabIndex = 21;
            this.bUpdatePair.Text = "Изменить";
            this.bUpdatePair.UseVisualStyleBackColor = true;
            this.bUpdatePair.Click += new System.EventHandler(this.bUpdatePair_Click);
            // 
            // bRemovePair
            // 
            this.bRemovePair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRemovePair.Location = new System.Drawing.Point(454, 10);
            this.bRemovePair.Name = "bRemovePair";
            this.bRemovePair.Size = new System.Drawing.Size(94, 25);
            this.bRemovePair.TabIndex = 22;
            this.bRemovePair.Text = "Удалить";
            this.bRemovePair.UseVisualStyleBackColor = true;
            this.bRemovePair.Click += new System.EventHandler(this.bRemovePair_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 470);
            this.Controls.Add(this.bRemovePair);
            this.Controls.Add(this.bUpdatePair);
            this.Controls.Add(this.lWeek);
            this.Controls.Add(this.lGroup);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ViewForm";
            this.Text = "Таблица расписания";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.Resize += new System.EventHandler(this.ViewForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lGroup;
        private System.Windows.Forms.Label lWeek;
        private System.Windows.Forms.Button bUpdatePair;
        private System.Windows.Forms.Button bRemovePair;
    }
}