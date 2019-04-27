using System;
using System.Drawing;
using System.Windows.Forms;

namespace EditorForms
{
    public partial class Menu : MaterialSkin.Controls.MaterialForm
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
            if (AbrirTelaSelecaoImagem())
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
                pictureBox.Image = imagemOriginal;
            }
        }

        private void btnLimiarizacao_Click(object sender, EventArgs e)
        {
            if (AbrirTelaSelecaoImagem())
            {

            }
        }

        private void btnEscalasDeCinza_Click(object sender, EventArgs e)
        {
            if (AbrirTelaSelecaoImagem())
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
                pictureBox.Image = imagemOriginal;
            }
        }

        private void btnRuido_Click(object sender, EventArgs e)
        {
            int contador = 1;
            //larissa
            if (AbrirTelaSelecaoImagem())
            {
                for (int larg = 0; larg < larguraImagem; larg++)
                {
                    for (int alt = 0; alt < alturaImagem; alt++)
                    {
                        Color pixel = imagemOriginal.GetPixel(larg, alt);

                        int a = pixel.A;

                        if (contador % 7 == 0)
                            imagemOriginal.SetPixel(larg, alt, Color.FromArgb(a, 0, 0, 0));
                        if (contador % 11 == 0)
                            imagemOriginal.SetPixel(larg, alt, Color.FromArgb(a, 216, 216, 191));
                        contador++;
                    }
                }
                pictureBox.Image = imagemOriginal;
            }
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            if (AbrirTelaSelecaoImagem())
            {
                //int largura = imagemOriginal.Width;
                //int altura = imagemOriginal.Height;
                int quantBlur = 10;

                for (int larg = quantBlur; larg < larguraImagem - quantBlur; larg++)
                {
                    for (int alt = quantBlur; alt < alturaImagem - quantBlur; alt++)
                    {
                        Color c = imagemOriginal.GetPixel(larg, alt);
                        Color n = imagemOriginal.GetPixel(larg - quantBlur, alt);
                        Color s = imagemOriginal.GetPixel(larg + quantBlur, alt);
                        Color o = imagemOriginal.GetPixel(larg, alt - quantBlur);
                        Color l = imagemOriginal.GetPixel(larg, alt + quantBlur);
                        Color no = imagemOriginal.GetPixel(larg - quantBlur, alt - quantBlur);
                        Color so = imagemOriginal.GetPixel(larg + quantBlur, alt - quantBlur);
                        Color ne = imagemOriginal.GetPixel(larg - quantBlur, alt + quantBlur);
                        Color se = imagemOriginal.GetPixel(larg + quantBlur, alt + quantBlur);

                        int avgR = (int)((n.R + s.R + o.R + l.R + no.R + so.R + ne.R + se.R + c.R) / 9);
                        int avgG = (int)((n.G + s.G + o.G + l.G + no.G + so.G + ne.G + se.G + c.R) / 9);
                        int avgB = (int)((n.B + s.B + o.B + l.B + no.B + so.B + ne.B + se.B + c.R) / 9);

                        imagemOriginal.SetPixel(larg, alt, Color.FromArgb(avgR, avgG, avgB));
                    }

                }
                pictureBox.Image = imagemOriginal;
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            //ver com a Lari sobre isso
            if (AbrirTelaSelecaoImagem())
            {
                int largura = imagemOriginal.Width;
                int altura = imagemOriginal.Height;
                for (int larg = 0; larg < largura; larg++)
                {
                    for (int alt = 0; alt < altura; alt++)
                    {
                        Color pixel = imagemOriginal.GetPixel(larg, alt);
                        int r = pixel.R;
                        int g = pixel.G;
                        int b = pixel.B;
                        int media = (r + g + b) / 3;
                        int limiar=0;

                        if (media < limiar)
                            imagemOriginal.SetPixel(larg, alt, Color.Black);
                        else
                            imagemOriginal.SetPixel(larg, alt, Color.White);
                    }
                }
                pictureBox.Image = imagemOriginal;
            }
        }

        private void BtnSepia_Click_Click(object sender, EventArgs e)
        {
            if (AbrirTelaSelecaoImagem())
            {
                int largura = imagemOriginal.Width;
                int altura = imagemOriginal.Height;

                Color pixel;

                for (int larg = 0; larg < altura; larg++)
                {
                    for (int alt = 0; alt < largura; alt++)
                    {
                        pixel = imagemOriginal.GetPixel(alt, larg);

                        int r = pixel.R;
                        int g = pixel.G;
                        int b = pixel.B;

                        int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                        if (tr > 255)
                        {
                            r = 255;
                        }
                        else
                        {
                            r = tr;
                        }

                        if (tg > 255)
                        {
                            g = 255;
                        }
                        else
                        {
                            g = tg;
                        }

                        if (tb > 255)
                        {
                            b = 255;
                        }
                        else
                        {
                            b = tb;
                        }

                        imagemOriginal.SetPixel(alt, larg, Color.FromArgb(r, g, b));
                    }
                }

                pictureBox.Image = imagemOriginal;
            }
        }

        private void Btn_red_Click(object sender, EventArgs e)
        {
            if (AbrirTelaSelecaoImagem())
            {
                for (int larg = 0; larg < imagemOriginal.Height; larg++)
                {
                    for (int alt = 0; alt < imagemOriginal.Width; alt++)
                    {
                        Color p = imagemOriginal.GetPixel(alt, larg);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        imagemOriginal.SetPixel(alt, larg, Color.FromArgb(a, r, 0, 0));

                    }
                }
                pictureBox.Image = imagemOriginal;
            }
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
            resultado.Text = "Nenhuma imagem foi selecionada";
            return false;
        }

        private void SalvarImagem()
        {

            SaveFileDialog salvarfoto = new SaveFileDialog();
            salvarfoto.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (salvarfoto.ShowDialog() == DialogResult.OK)
            {
                imagemOriginal.Save(salvarfoto.FileName);
                resultado.Text = "Imagem salva com sucesso!";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarImagem();
        }

    }
}
