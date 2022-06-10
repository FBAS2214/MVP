namespace MVP.Views
{
    partial class MainView
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
            this.txt_Make = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Transmission = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.listBox_Cars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_Make
            // 
            this.txt_Make.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Make.Location = new System.Drawing.Point(46, 39);
            this.txt_Make.Name = "txt_Make";
            this.txt_Make.PlaceholderText = "Make";
            this.txt_Make.Size = new System.Drawing.Size(225, 48);
            this.txt_Make.TabIndex = 0;
            // 
            // txt_Model
            // 
            this.txt_Model.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Model.Location = new System.Drawing.Point(46, 119);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.PlaceholderText = "Model";
            this.txt_Model.Size = new System.Drawing.Size(225, 48);
            this.txt_Model.TabIndex = 0;
            // 
            // txt_Color
            // 
            this.txt_Color.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Color.Location = new System.Drawing.Point(46, 199);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.PlaceholderText = "Color";
            this.txt_Color.Size = new System.Drawing.Size(225, 48);
            this.txt_Color.TabIndex = 0;
            // 
            // txt_Year
            // 
            this.txt_Year.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Year.Location = new System.Drawing.Point(46, 279);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.PlaceholderText = "Year";
            this.txt_Year.Size = new System.Drawing.Size(225, 48);
            this.txt_Year.TabIndex = 0;
            // 
            // txt_Transmission
            // 
            this.txt_Transmission.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Transmission.Location = new System.Drawing.Point(46, 359);
            this.txt_Transmission.Name = "txt_Transmission";
            this.txt_Transmission.PlaceholderText = "Transmission";
            this.txt_Transmission.Size = new System.Drawing.Size(225, 48);
            this.txt_Transmission.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSize = true;
            this.btn_Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(46, 439);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(225, 59);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // listBox_Cars
            // 
            this.listBox_Cars.FormattingEnabled = true;
            this.listBox_Cars.ItemHeight = 25;
            this.listBox_Cars.Location = new System.Drawing.Point(368, 114);
            this.listBox_Cars.Name = "listBox_Cars";
            this.listBox_Cars.Size = new System.Drawing.Size(524, 379);
            this.listBox_Cars.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 536);
            this.Controls.Add(this.listBox_Cars);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Transmission);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Make);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Make;
        private TextBox txt_Model;
        private TextBox txt_Color;
        private TextBox txt_Year;
        private TextBox txt_Transmission;
        private Button btn_Add;
        private ListBox listBox_Cars;
    }
}