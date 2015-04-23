namespace FundaAssignment
{
    partial class FormFundaAssignment
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
            this.dataGridViewMostObjects = new System.Windows.Forms.DataGridView();
            this.groupBoxMostObjects = new System.Windows.Forms.GroupBox();
            this.buttonPopulateMostObjects = new System.Windows.Forms.Button();
            this.buttonPopulateMostObjectsWithTuin = new System.Windows.Forms.Button();
            this.groupBoxMostObjectsWithTuin = new System.Windows.Forms.GroupBox();
            this.dataGridViewMostObjectsWithTuin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostObjects)).BeginInit();
            this.groupBoxMostObjects.SuspendLayout();
            this.groupBoxMostObjectsWithTuin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostObjectsWithTuin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostObjects
            // 
            this.dataGridViewMostObjects.AllowUserToAddRows = false;
            this.dataGridViewMostObjects.AllowUserToDeleteRows = false;
            this.dataGridViewMostObjects.AllowUserToOrderColumns = true;
            this.dataGridViewMostObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMostObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostObjects.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewMostObjects.Name = "dataGridViewMostObjects";
            this.dataGridViewMostObjects.RowHeadersVisible = false;
            this.dataGridViewMostObjects.RowTemplate.Height = 28;
            this.dataGridViewMostObjects.Size = new System.Drawing.Size(414, 461);
            this.dataGridViewMostObjects.TabIndex = 0;
            // 
            // groupBoxMostObjects
            // 
            this.groupBoxMostObjects.Controls.Add(this.dataGridViewMostObjects);
            this.groupBoxMostObjects.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMostObjects.Name = "groupBoxMostObjects";
            this.groupBoxMostObjects.Size = new System.Drawing.Size(426, 492);
            this.groupBoxMostObjects.TabIndex = 1;
            this.groupBoxMostObjects.TabStop = false;
            this.groupBoxMostObjects.Text = "Most Objects";
            // 
            // buttonPopulateMostObjects
            // 
            this.buttonPopulateMostObjects.Location = new System.Drawing.Point(126, 510);
            this.buttonPopulateMostObjects.Name = "buttonPopulateMostObjects";
            this.buttonPopulateMostObjects.Size = new System.Drawing.Size(170, 50);
            this.buttonPopulateMostObjects.TabIndex = 2;
            this.buttonPopulateMostObjects.Text = "Populate";
            this.buttonPopulateMostObjects.UseVisualStyleBackColor = true;
            this.buttonPopulateMostObjects.Click += new System.EventHandler(this.buttonPopulateMostObjects_Click);
            // 
            // buttonPopulateMostObjectsWithTuin
            // 
            this.buttonPopulateMostObjectsWithTuin.Location = new System.Drawing.Point(575, 511);
            this.buttonPopulateMostObjectsWithTuin.Name = "buttonPopulateMostObjectsWithTuin";
            this.buttonPopulateMostObjectsWithTuin.Size = new System.Drawing.Size(170, 50);
            this.buttonPopulateMostObjectsWithTuin.TabIndex = 4;
            this.buttonPopulateMostObjectsWithTuin.Text = "Populate";
            this.buttonPopulateMostObjectsWithTuin.UseVisualStyleBackColor = true;
            this.buttonPopulateMostObjectsWithTuin.Click += new System.EventHandler(this.buttonPopulateMostObjectsWithTuin_Click);
            // 
            // groupBoxMostObjectsWithTuin
            // 
            this.groupBoxMostObjectsWithTuin.Controls.Add(this.dataGridViewMostObjectsWithTuin);
            this.groupBoxMostObjectsWithTuin.Location = new System.Drawing.Point(456, 12);
            this.groupBoxMostObjectsWithTuin.Name = "groupBoxMostObjectsWithTuin";
            this.groupBoxMostObjectsWithTuin.Size = new System.Drawing.Size(426, 492);
            this.groupBoxMostObjectsWithTuin.TabIndex = 3;
            this.groupBoxMostObjectsWithTuin.TabStop = false;
            this.groupBoxMostObjectsWithTuin.Text = "Most Objects With Tuin";
            // 
            // dataGridViewMostObjectsWithTuin
            // 
            this.dataGridViewMostObjectsWithTuin.AllowUserToAddRows = false;
            this.dataGridViewMostObjectsWithTuin.AllowUserToDeleteRows = false;
            this.dataGridViewMostObjectsWithTuin.AllowUserToOrderColumns = true;
            this.dataGridViewMostObjectsWithTuin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMostObjectsWithTuin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostObjectsWithTuin.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewMostObjectsWithTuin.Name = "dataGridViewMostObjectsWithTuin";
            this.dataGridViewMostObjectsWithTuin.RowHeadersVisible = false;
            this.dataGridViewMostObjectsWithTuin.RowTemplate.Height = 28;
            this.dataGridViewMostObjectsWithTuin.Size = new System.Drawing.Size(414, 461);
            this.dataGridViewMostObjectsWithTuin.TabIndex = 0;
            // 
            // FormFundaAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 586);
            this.Controls.Add(this.buttonPopulateMostObjectsWithTuin);
            this.Controls.Add(this.groupBoxMostObjectsWithTuin);
            this.Controls.Add(this.buttonPopulateMostObjects);
            this.Controls.Add(this.groupBoxMostObjects);
            this.Name = "FormFundaAssignment";
            this.Text = "Funda Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostObjects)).EndInit();
            this.groupBoxMostObjects.ResumeLayout(false);
            this.groupBoxMostObjectsWithTuin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostObjectsWithTuin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMostObjects;
        private System.Windows.Forms.GroupBox groupBoxMostObjects;
        private System.Windows.Forms.Button buttonPopulateMostObjects;
        private System.Windows.Forms.Button buttonPopulateMostObjectsWithTuin;
        private System.Windows.Forms.GroupBox groupBoxMostObjectsWithTuin;
        private System.Windows.Forms.DataGridView dataGridViewMostObjectsWithTuin;
    }
}

