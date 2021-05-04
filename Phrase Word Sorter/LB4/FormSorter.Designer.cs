
namespace LB4
{
    partial class FormPhraseSorter
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
            this.textBoxPhrase = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelSortedPhrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPhrase
            // 
            this.textBoxPhrase.Location = new System.Drawing.Point(38, 55);
            this.textBoxPhrase.Name = "textBoxPhrase";
            this.textBoxPhrase.Size = new System.Drawing.Size(568, 38);
            this.textBoxPhrase.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(38, 115);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(195, 38);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelSortedPhrase
            // 
            this.labelSortedPhrase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSortedPhrase.Location = new System.Drawing.Point(38, 176);
            this.labelSortedPhrase.Name = "labelSortedPhrase";
            this.labelSortedPhrase.Size = new System.Drawing.Size(568, 208);
            this.labelSortedPhrase.TabIndex = 2;
            // 
            // FormPhraseSorter
            // 
            this.AcceptButton = this.buttonSort;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 420);
            this.Controls.Add(this.labelSortedPhrase);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxPhrase);
            this.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormPhraseSorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorted Phrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPhrase;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelSortedPhrase;
    }
}

