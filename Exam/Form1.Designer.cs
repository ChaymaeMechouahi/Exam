namespace Exam
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
            this.lbl_examde = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.box_matiere = new System.Windows.Forms.ComboBox();
            this.box_date = new System.Windows.Forms.ComboBox();
            this.box_durée = new System.Windows.Forms.ComboBox();
            this.lbl_note = new System.Windows.Forms.Label();
            this.box_note = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_examde
            // 
            this.lbl_examde.AutoSize = true;
            this.lbl_examde.Location = new System.Drawing.Point(97, 73);
            this.lbl_examde.Name = "lbl_examde";
            this.lbl_examde.Size = new System.Drawing.Size(54, 13);
            this.lbl_examde.TabIndex = 0;
            this.lbl_examde.Text = "Exam de :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(97, 106);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(97, 149);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(39, 13);
            this.lbl_duration.TabIndex = 2;
            this.lbl_duration.Text = "Durée:";
            // 
            // box_matiere
            // 
            this.box_matiere.FormattingEnabled = true;
            this.box_matiere.Location = new System.Drawing.Point(165, 65);
            this.box_matiere.Name = "box_matiere";
            this.box_matiere.Size = new System.Drawing.Size(159, 21);
            this.box_matiere.TabIndex = 3;
            // 
            // box_date
            // 
            this.box_date.FormattingEnabled = true;
            this.box_date.Location = new System.Drawing.Point(167, 103);
            this.box_date.Name = "box_date";
            this.box_date.Size = new System.Drawing.Size(157, 21);
            this.box_date.TabIndex = 4;
            // 
            // box_durée
            // 
            this.box_durée.FormattingEnabled = true;
            this.box_durée.Location = new System.Drawing.Point(167, 141);
            this.box_durée.Name = "box_durée";
            this.box_durée.Size = new System.Drawing.Size(157, 21);
            this.box_durée.TabIndex = 5;
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(97, 192);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(50, 13);
            this.lbl_note.TabIndex = 6;
            this.lbl_note.Text = "Note sur:";
            // 
            // box_note
            // 
            this.box_note.FormattingEnabled = true;
            this.box_note.Location = new System.Drawing.Point(167, 189);
            this.box_note.Name = "box_note";
            this.box_note.Size = new System.Drawing.Size(159, 21);
            this.box_note.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 532);
            this.Controls.Add(this.box_note);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.box_durée);
            this.Controls.Add(this.box_date);
            this.Controls.Add(this.box_matiere);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_examde);
            this.Name = "Form1";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_examde;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.ComboBox box_matiere;
        private System.Windows.Forms.ComboBox box_date;
        private System.Windows.Forms.ComboBox box_durée;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.ComboBox box_note;
    }
}

