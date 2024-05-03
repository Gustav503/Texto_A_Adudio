namespace Texto_y_Audio
{
    partial class Texto_Audio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTexto = new System.Windows.Forms.RichTextBox();
            this.btnHablar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnReproducirMP3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTexto
            // 
            this.rTexto.Location = new System.Drawing.Point(46, 47);
            this.rTexto.Name = "rTexto";
            this.rTexto.Size = new System.Drawing.Size(715, 122);
            this.rTexto.TabIndex = 0;
            this.rTexto.Text = "";
            this.rTexto.TextChanged += new System.EventHandler(this.rTexto_TextChanged);
            // 
            // btnHablar
            // 
            this.btnHablar.Location = new System.Drawing.Point(50, 206);
            this.btnHablar.Name = "btnHablar";
            this.btnHablar.Size = new System.Drawing.Size(75, 23);
            this.btnHablar.TabIndex = 1;
            this.btnHablar.Text = "Hablar";
            this.btnHablar.UseVisualStyleBackColor = true;
            this.btnHablar.Click += new System.EventHandler(this.btnHablar_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(131, 206);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(133, 26);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir a Audio";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnReproducirMP3
            // 
            this.btnReproducirMP3.Location = new System.Drawing.Point(288, 206);
            this.btnReproducirMP3.Name = "btnReproducirMP3";
            this.btnReproducirMP3.Size = new System.Drawing.Size(139, 26);
            this.btnReproducirMP3.TabIndex = 4;
            this.btnReproducirMP3.Text = "ReproducirMP3";
            this.btnReproducirMP3.UseVisualStyleBackColor = true;
            this.btnReproducirMP3.Click += new System.EventHandler(this.btnReproducirMP3_Click);
            // 
            // Texto_Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.btnReproducirMP3);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnHablar);
            this.Controls.Add(this.rTexto);
            this.Name = "Texto_Audio";
            this.Text = "Texto_Audio";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rTexto;
        private Button btnHablar;
        private Button btnConvertir;
        private Button btnReproducirMP3;
    }
}