namespace Projeto_TCC
{
    partial class Cursos
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
            this.box_tec = new System.Windows.Forms.ComboBox();
            this.box_tecnico = new System.Windows.Forms.CheckBox();
            this.box_rapido = new System.Windows.Forms.CheckBox();
            this.box_rap = new System.Windows.Forms.ComboBox();
            this.box_industrial = new System.Windows.Forms.CheckBox();
            this.box_apr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // box_tec
            // 
            this.box_tec.FormattingEnabled = true;
            this.box_tec.Location = new System.Drawing.Point(456, 198);
            this.box_tec.Name = "box_tec";
            this.box_tec.Size = new System.Drawing.Size(121, 21);
            this.box_tec.TabIndex = 0;
            this.box_tec.Visible = false;
            this.box_tec.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // box_tecnico
            // 
            this.box_tecnico.AutoSize = true;
            this.box_tecnico.Location = new System.Drawing.Point(283, 202);
            this.box_tecnico.Name = "box_tecnico";
            this.box_tecnico.Size = new System.Drawing.Size(101, 17);
            this.box_tecnico.TabIndex = 1;
            this.box_tecnico.Text = "Cursos tecnicos";
            this.box_tecnico.UseVisualStyleBackColor = true;
            this.box_tecnico.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // box_rapido
            // 
            this.box_rapido.AutoSize = true;
            this.box_rapido.Location = new System.Drawing.Point(283, 280);
            this.box_rapido.Name = "box_rapido";
            this.box_rapido.Size = new System.Drawing.Size(95, 17);
            this.box_rapido.TabIndex = 1;
            this.box_rapido.Text = "Cursos rapidos";
            this.box_rapido.UseVisualStyleBackColor = true;
            this.box_rapido.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // box_rap
            // 
            this.box_rap.FormattingEnabled = true;
            this.box_rap.Location = new System.Drawing.Point(456, 276);
            this.box_rap.Name = "box_rap";
            this.box_rap.Size = new System.Drawing.Size(121, 21);
            this.box_rap.TabIndex = 0;
            this.box_rap.Visible = false;
            this.box_rap.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // box_industrial
            // 
            this.box_industrial.AutoSize = true;
            this.box_industrial.Location = new System.Drawing.Point(283, 362);
            this.box_industrial.Name = "box_industrial";
            this.box_industrial.Size = new System.Drawing.Size(137, 17);
            this.box_industrial.TabIndex = 1;
            this.box_industrial.Text = "Aprendizagem industrial";
            this.box_industrial.UseVisualStyleBackColor = true;
            this.box_industrial.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // box_apr
            // 
            this.box_apr.FormattingEnabled = true;
            this.box_apr.Location = new System.Drawing.Point(456, 358);
            this.box_apr.Name = "box_apr";
            this.box_apr.Size = new System.Drawing.Size(121, 21);
            this.box_apr.TabIndex = 0;
            this.box_apr.Visible = false;
            this.box_apr.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.box_industrial);
            this.Controls.Add(this.box_rapido);
            this.Controls.Add(this.box_tecnico);
            this.Controls.Add(this.box_apr);
            this.Controls.Add(this.box_rap);
            this.Controls.Add(this.box_tec);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box_tec;
        private System.Windows.Forms.CheckBox box_tecnico;
        private System.Windows.Forms.CheckBox box_rapido;
        private System.Windows.Forms.ComboBox box_rap;
        private System.Windows.Forms.CheckBox box_industrial;
        private System.Windows.Forms.ComboBox box_apr;
    }
}