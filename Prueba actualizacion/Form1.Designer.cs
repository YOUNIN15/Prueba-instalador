﻿namespace Prueba_actualizacion
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.cirpbreloj = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblsegundos = new System.Windows.Forms.Label();
            this.tmhora = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cirpbreloj.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 100);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar Actualización";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cirpbreloj
            // 
            this.cirpbreloj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cirpbreloj.Controls.Add(this.lblfecha);
            this.cirpbreloj.Controls.Add(this.lblhora);
            this.cirpbreloj.Controls.Add(this.lblsegundos);
            this.cirpbreloj.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cirpbreloj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cirpbreloj.ForeColor = System.Drawing.Color.White;
            this.cirpbreloj.Location = new System.Drawing.Point(213, 12);
            this.cirpbreloj.Minimum = 0;
            this.cirpbreloj.Name = "cirpbreloj";
            this.cirpbreloj.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cirpbreloj.Size = new System.Drawing.Size(426, 426);
            this.cirpbreloj.TabIndex = 10;
            this.cirpbreloj.Text = "guna2CircleProgressBar1";
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(160, 360);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(100, 24);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "12/12/2023";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(167, 201);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(83, 37);
            this.lblhora.TabIndex = 1;
            this.lblhora.Text = "00:00";
            // 
            // lblsegundos
            // 
            this.lblsegundos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsegundos.AutoSize = true;
            this.lblsegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundos.ForeColor = System.Drawing.Color.Black;
            this.lblsegundos.Location = new System.Drawing.Point(194, 45);
            this.lblsegundos.Name = "lblsegundos";
            this.lblsegundos.Size = new System.Drawing.Size(30, 24);
            this.lblsegundos.TabIndex = 0;
            this.lblsegundos.Text = "00";
            // 
            // tmhora
            // 
            this.tmhora.Enabled = true;
            this.tmhora.Tick += new System.EventHandler(this.tmhora_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cirpbreloj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cirpbreloj.ResumeLayout(false);
            this.cirpbreloj.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cirpbreloj;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblsegundos;
        private System.Windows.Forms.Timer tmhora;
        private System.Windows.Forms.Panel panel1;
    }
}

