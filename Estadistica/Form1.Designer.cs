﻿namespace Estadistica
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
            this.lblAnswerSerie = new System.Windows.Forms.Label();
            this.btnencontrara = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnswerSerie
            // 
            this.lblAnswerSerie.AutoSize = true;
            this.lblAnswerSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerSerie.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerSerie.Location = new System.Drawing.Point(20, 72);
            this.lblAnswerSerie.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnswerSerie.Name = "lblAnswerSerie";
            this.lblAnswerSerie.Size = new System.Drawing.Size(29, 24);
            this.lblAnswerSerie.TabIndex = 15;
            this.lblAnswerSerie.Text = "X:";
            // 
            // btnencontrara
            // 
            this.btnencontrara.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnencontrara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencontrara.ForeColor = System.Drawing.Color.Black;
            this.btnencontrara.Location = new System.Drawing.Point(351, 18);
            this.btnencontrara.Margin = new System.Windows.Forms.Padding(1);
            this.btnencontrara.Name = "btnencontrara";
            this.btnencontrara.Size = new System.Drawing.Size(126, 35);
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
            this.txtSerie.Location = new System.Drawing.Point(102, 20);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 244);
            this.Controls.Add(this.lblAnswerSerie);
            this.Controls.Add(this.btnencontrara);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Cálculos Básicos Estadisticas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswerSerie;
        private System.Windows.Forms.Button btnencontrara;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
    }
}

