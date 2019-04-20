using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EditorDeImagens
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Menu : Window
    {
        private readonly MenuViewModel _viewModel;
        public Menu()
        {
            _viewModel = new MenuViewModel();
            InitializeComponent();
            InicializarDelegates();
            DataContext = _viewModel;
        }

        private void InicializarDelegates()
        {
            _viewModel.AbrirTelaSelecaoImagem = AbrirTelaSelecaoImagem;
        }

        private void AbrirTelaSelecaoImagem()
        {
            var imagem = new OpenFileDialog();
            imagem.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            imagem.ShowDialog();
            if(imagem.FileName != string.Empty)
            {
                _viewModel.imagemSelecionada = new ColorConvertedBitmapExtension(imagem.FileName);
            }
                            //pictureBox1.Imagem = Image.FromFile(imagem.filename);
            
            //pictureBox.Image.Save(@"Caminho para salvar imagem",ImageFormat.Jpeg); SALVA A IMAGEM
        }
    }
}
