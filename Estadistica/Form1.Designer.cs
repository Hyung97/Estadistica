namespace Estadistica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnencontrara = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblAnswerTipica = new System.Windows.Forms.Label();
            this.btnEncontrarTipica = new System.Windows.Forms.Button();
            this.lblAnswerArmonica = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer.Location = new System.Drawing.Point(20, 72);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(29, 24);
            this.lblAnswer.TabIndex = 15;
            this.lblAnswer.Text = "X:";
            // 
            // btnencontrara
            // 
            this.btnencontrara.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnencontrara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencontrara.ForeColor = System.Drawing.Color.Black;
            this.btnencontrara.Location = new System.Drawing.Point(39, 149);
            this.btnencontrara.Margin = new System.Windows.Forms.Padding(1);
            this.btnencontrara.Name = "btnencontrara";
            this.btnencontrara.Size = new System.Drawing.Size(175, 35);
            this.btnencontrara.TabIndex = 14;
            this.btnencontrara.Text = "Calcular X";
            this.btnencontrara.UseVisualStyleBackColor = false;
            this.btnencontrara.Click += new System.EventHandler(this.btnencontrara_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.White;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.Color.Black;
            this.txtSerie.Location = new System.Drawing.Point(92, 20);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(1);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(235, 29);
            this.txtSerie.TabIndex = 13;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.Black;
            this.lblSerie.Location = new System.Drawing.Point(20, 23);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(70, 24);
            this.lblSerie.TabIndex = 12;
            this.lblSerie.Text = "SERIE:";
            // 
            // lblAnswerTipica
            // 
            this.lblAnswerTipica.AutoSize = true;
            this.lblAnswerTipica.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerTipica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerTipica.Location = new System.Drawing.Point(477, 72);
            this.lblAnswerTipica.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnswerTipica.Name = "lblAnswerTipica";
            this.lblAnswerTipica.Size = new System.Drawing.Size(0, 24);
            this.lblAnswerTipica.TabIndex = 19;
            // 
            // btnEncontrarTipica
            // 
            this.btnEncontrarTipica.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEncontrarTipica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncontrarTipica.ForeColor = System.Drawing.Color.Black;
            this.btnEncontrarTipica.Location = new System.Drawing.Point(39, 200);
            this.btnEncontrarTipica.Margin = new System.Windows.Forms.Padding(1);
            this.btnEncontrarTipica.Name = "btnEncontrarTipica";
            this.btnEncontrarTipica.Size = new System.Drawing.Size(175, 29);
            this.btnEncontrarTipica.TabIndex = 18;
            this.btnEncontrarTipica.Text = "Calcular Estandar";
            this.btnEncontrarTipica.UseVisualStyleBackColor = false;
            this.btnEncontrarTipica.Click += new System.EventHandler(this.btnencontrar_Click);
            // 
            // lblAnswerArmonica
            // 
            this.lblAnswerArmonica.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerArmonica.Location = new System.Drawing.Point(441, 149);
            this.lblAnswerArmonica.Name = "lblAnswerArmonica";
            this.lblAnswerArmonica.Size = new System.Drawing.Size(100, 23);
            this.lblAnswerArmonica.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(39, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Calcular Tipica";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 364);
            this.Controls.Add(this.lblAnswerArmonica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAnswerTipica);
            this.Controls.Add(this.btnEncontrarTipica);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnencontrara);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cálculos Básicos Estadisticas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnencontrara;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblAnswerTipica;
        private System.Windows.Forms.Button btnEncontrarTipica;
        private System.Windows.Forms.Label lblAnswerArmonica;
        private System.Windows.Forms.Button button1;
    }
}

