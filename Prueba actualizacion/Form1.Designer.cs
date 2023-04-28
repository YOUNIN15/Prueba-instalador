namespace Prueba_actualizacion
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
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.gunaRadioButton1 = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaMetroTrackBar1 = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(173, 93);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.gunaVScrollBar1.TabIndex = 0;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // gunaProgressBar1
            // 
            this.gunaProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaProgressBar1.Location = new System.Drawing.Point(407, 110);
            this.gunaProgressBar1.Name = "gunaProgressBar1";
            this.gunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.Size = new System.Drawing.Size(200, 23);
            this.gunaProgressBar1.TabIndex = 1;
            this.gunaProgressBar1.Value = 78;
            // 
            // gunaRadioButton1
            // 
            this.gunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaRadioButton1.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton1.Location = new System.Drawing.Point(242, 198);
            this.gunaRadioButton1.Name = "gunaRadioButton1";
            this.gunaRadioButton1.Size = new System.Drawing.Size(124, 20);
            this.gunaRadioButton1.TabIndex = 2;
            this.gunaRadioButton1.Text = "gunaRadioButton1";
            // 
            // gunaMetroTrackBar1
            // 
            this.gunaMetroTrackBar1.Location = new System.Drawing.Point(338, 311);
            this.gunaMetroTrackBar1.Name = "gunaMetroTrackBar1";
            this.gunaMetroTrackBar1.Size = new System.Drawing.Size(100, 23);
            this.gunaMetroTrackBar1.TabIndex = 4;
            this.gunaMetroTrackBar1.TrackColor = System.Drawing.Color.DimGray;
            this.gunaMetroTrackBar1.TrackHoverColor = System.Drawing.Color.Gray;
            this.gunaMetroTrackBar1.TrackIdleColor = System.Drawing.Color.Silver;
            this.gunaMetroTrackBar1.TrackPressedColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alturomelomama15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaMetroTrackBar1);
            this.Controls.Add(this.gunaRadioButton1);
            this.Controls.Add(this.gunaProgressBar1);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton1;
        private Guna.UI.WinForms.GunaMetroTrackBar gunaMetroTrackBar1;
        private System.Windows.Forms.Label label1;
    }
}

