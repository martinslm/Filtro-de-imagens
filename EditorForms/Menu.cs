using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorForms
{
    public partial class Menu : Form
    {
        Bitmap imagemOriginal;
        int larguraImagem;
        int alturaImagem;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            if(AbrirTelaSelecaoImagem())
            {
                for (int larg = 0; larg < larguraImagem; larg++)
                {
                    for (int alt = 0; alt < alturaImagem; alt++)
                    {
                        Color pixel = imagemOriginal.GetPixel(larg, alt);

                        int a = pixel.A;
                        int r = pixel.R;
                        int g = pixel.G;
                        int b = pixel.B;

                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        imagemOriginal.SetPixel(larg, alt, Color.FromArgb(a, r, g, b));
                    }
                }
                SalvarImagem();
            }
        }

        private void btnLimiarizacao_Click(object sender, EventArgs e)
        {
            if(AbrirTelaSelecaoImagem())
            {

            }
        }

        private void btnEscalasDeCinza_Click(object sender, EventArgs e)
        {
            if(AbrirTelaSelecaoImagem())
            {
                for (int larg = 0; larg < larguraImagem; larg++)
                {
                    for (int alt = 0; alt < alturaImagem; alt++)
                    {
                        Color pixel = imagemOriginal.GetPixel(larg, alt);

                        int a = pixel.A;
                        int r = pixel.R;
                        int g = pixel.G;
                        int b = pixel.B;

                        int rgb = (r + g + b) / 3;

                        imagemOriginal.SetPixel(larg, alt, Color.FromArgb(a, rgb, rgb, rgb));
                    }
                }
                SalvarImagem();

            }
        }

        private void btnRuido_Click(object sender, EventArgs e)
        {
            int contador = 1;
            //larissa
            if(AbrirTelaSelecaoImagem())
            {
                for (int larg = 0; larg < larguraImagem; larg++)
                {
                    for (int alt = 0; alt < alturaImagem; alt++)
                    {
                        Color pixel = imagemOriginal.GetPixel(larg, alt);
  
                        int a = pixel.A;

                        if (contador % 2500 == 0)
                            imagemOriginal.SetPixel(larg, alt, Color.FromArgb(a, 0, 0, 0));
                        if (contador % 2500.5 == 0)
                            imagemOriginal.SetPixel(larg, alt, Color.FromArgb(a, 216, 216, 191));
                        contador++;
                    }
                }
                SalvarImagem();
            }
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            if(AbrirTelaSelecaoImagem())
            {

            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            if(AbrirTelaSelecaoImagem())
            { }
        }

        private bool AbrirTelaSelecaoImagem()
        {
            var imagem = new OpenFileDialog();
            imagem.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            imagem.ShowDialog();
            if (imagem.FileName != string.Empty)
            {
                imagemOriginal = new Bitmap(imagem.FileName);
                larguraImagem = imagemOriginal.Width;
                alturaImagem = imagemOriginal.Height;
                return true;
            }
            labelResultado.Text = "Nenhuma imagem foi selecionada";
            return false;
        }

        private void SalvarImagem()
        {

            SaveFileDialog salvarfoto = new SaveFileDialog();
            salvarfoto.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (salvarfoto.ShowDialog() == DialogResult.OK)
            {
                imagemOriginal.Save(salvarfoto.FileName);
                labelResultado.Text = "Imagem salva com sucesso!";
            }
        }
    }
}
