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
            this.btnLimiarizacao = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBinario = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBlur = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRuido = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelResultado = new MaterialSkin.Controls.MaterialLabel();
            this.resultado = new MaterialSkin.Controls.MaterialLabel();
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
            // btnLimiarizacao
            // 
            this.btnLimiarizacao.AutoSize = true;
            this.btnLimiarizacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimiarizacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimiarizacao.Depth = 0;
            this.btnLimiarizacao.Location = new System.Drawing.Point(98, 116);
            this.btnLimiarizacao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimiarizacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimiarizacao.Name = "btnLimiarizacao";
            this.btnLimiarizacao.Primary = false;
            this.btnLimiarizacao.Size = new System.Drawing.Size(106, 36);
            this.btnLimiarizacao.TabIndex = 2;
            this.btnLimiarizacao.Text = "Limiarização";
            this.btnLimiarizacao.UseVisualStyleBackColor = false;
            this.btnLimiarizacao.Click += new System.EventHandler(this.btnLimiarizacao_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.AutoSize = true;
            this.btnBinario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBinario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBinario.Depth = 0;
            this.btnBinario.Location = new System.Drawing.Point(207, 164);
            this.btnBinario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBinario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Primary = false;
            this.btnBinario.Size = new System.Drawing.Size(65, 36);
            this.btnBinario.TabIndex = 3;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = false;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
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
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.resultado.ForeColor = System.Drawing.Color.Lime;
            this.resultado.Location = new System.Drawing.Point(20, 219);
            this.resultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 18);
            this.resultado.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnRuido);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnLimiarizacao);
            this.Controls.Add(this.btnEscalasDeCinza);
            this.Controls.Add(this.btnNegativo);
            this.Name = "Menu";
            this.Text = "Selecione um Filtro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnNegativo;
        private MaterialSkin.Controls.MaterialFlatButton btnEscalasDeCinza;
        private MaterialSkin.Controls.MaterialFlatButton btnLimiarizacao;
        private MaterialSkin.Controls.MaterialFlatButton btnBinario;
        private MaterialSkin.Controls.MaterialFlatButton btnBlur;
        private MaterialSkin.Controls.MaterialFlatButton btnRuido;
        private MaterialSkin.Controls.MaterialLabel labelResultado;
        private MaterialSkin.Controls.MaterialLabel resultado;
    }
}

