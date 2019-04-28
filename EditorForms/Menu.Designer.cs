namespace EditorForms
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNegativo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEscalasDeCinza = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBlur = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRuido = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelResultado = new MaterialSkin.Controls.MaterialLabel();
            this.resultado = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_red = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRed = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNegativo
            // 
            this.btnNegativo.AutoSize = true;
            this.btnNegativo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNegativo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNegativo.Depth = 0;
            this.btnNegativo.Location = new System.Drawing.Point(11, 116);
            this.btnNegativo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNegativo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Primary = false;
            this.btnNegativo.Size = new System.Drawing.Size(79, 36);
            this.btnNegativo.TabIndex = 0;
            this.btnNegativo.Text = "Negativo";
            this.btnNegativo.UseVisualStyleBackColor = false;
            this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
            // 
            // btnEscalasDeCinza
            // 
            this.btnEscalasDeCinza.AutoSize = true;
            this.btnEscalasDeCinza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEscalasDeCinza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEscalasDeCinza.Depth = 0;
            this.btnEscalasDeCinza.Location = new System.Drawing.Point(220, 116);
            this.btnEscalasDeCinza.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEscalasDeCinza.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEscalasDeCinza.Name = "btnEscalasDeCinza";
            this.btnEscalasDeCinza.Primary = false;
            this.btnEscalasDeCinza.Size = new System.Drawing.Size(38, 36);
            this.btnEscalasDeCinza.TabIndex = 1;
            this.btnEscalasDeCinza.Text = "P&B";
            this.btnEscalasDeCinza.UseVisualStyleBackColor = false;
            this.btnEscalasDeCinza.Click += new System.EventHandler(this.btnEscalasDeCinza_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.AutoSize = true;
            this.btnBlur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBlur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBlur.Depth = 0;
            this.btnBlur.Location = new System.Drawing.Point(108, 164);
            this.btnBlur.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBlur.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Primary = false;
            this.btnBlur.Size = new System.Drawing.Size(76, 36);
            this.btnBlur.TabIndex = 4;
            this.btnBlur.Text = "Box Blur";
            this.btnBlur.UseVisualStyleBackColor = false;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnRuido
            // 
            this.btnRuido.AutoSize = true;
            this.btnRuido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRuido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRuido.Depth = 0;
            this.btnRuido.Location = new System.Drawing.Point(21, 164);
            this.btnRuido.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRuido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRuido.Name = "btnRuido";
            this.btnRuido.Primary = false;
            this.btnRuido.Size = new System.Drawing.Size(52, 36);
            this.btnRuido.TabIndex = 5;
            this.btnRuido.Text = "Ruído";
            this.btnRuido.UseVisualStyleBackColor = false;
            this.btnRuido.Click += new System.EventHandler(this.btnRuido_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Depth = 0;
            this.labelResultado.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelResultado.Location = new System.Drawing.Point(0, 213);
            this.labelResultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 19);
            this.labelResultado.TabIndex = 7;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Depth = 0;
            this.resultado.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultado.Location = new System.Drawing.Point(20, 219);
            this.resultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 19);
            this.resultado.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(302, 81);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(229, 223);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(77, 238);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(136, 35);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar Imagem";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btn_red
            // 
            this.btn_red.AutoSize = true;
            this.btn_red.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_red.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_red.Depth = 0;
            this.btn_red.Location = new System.Drawing.Point(133, 116);
            this.btn_red.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_red.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_red.Name = "btn_red";
            this.btn_red.Primary = false;
            this.btn_red.Size = new System.Drawing.Size(37, 36);
            this.btn_red.TabIndex = 11;
            this.btn_red.Text = "Red";
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.Btn_red_Click);
            // 
            // btnRed
            // 
            this.btnRed.AutoSize = true;
            this.btnRed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRed.Depth = 0;
            this.btnRed.Location = new System.Drawing.Point(220, 164);
            this.btnRed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRed.Name = "btnRed";
            this.btnRed.Primary = false;
            this.btnRed.Size = new System.Drawing.Size(50, 36);
            this.btnRed.TabIndex = 12;
            this.btnRed.Text = "Sépia";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.BtnSepia_Click_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(543, 316);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnRuido);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.btnEscalasDeCinza);
            this.Controls.Add(this.btnNegativo);
            this.Name = "Menu";
            this.Text = "Selecione um Filtro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnNegativo;
        private MaterialSkin.Controls.MaterialFlatButton btnEscalasDeCinza;
        private MaterialSkin.Controls.MaterialFlatButton btnBlur;
        private MaterialSkin.Controls.MaterialFlatButton btnRuido;
        private MaterialSkin.Controls.MaterialLabel labelResultado;
        private MaterialSkin.Controls.MaterialLabel resultado;
        private System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btn_red;
        private MaterialSkin.Controls.MaterialFlatButton btnRed;
    }
}

