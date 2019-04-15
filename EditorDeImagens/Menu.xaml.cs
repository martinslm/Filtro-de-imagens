using System;
using System.Windows;

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
        }

        private void InicializarDelegates()
        {
            _viewModel.AbrirTelaSelecaoImagem = AbrirTelaSelecaoImagem;
        }

        private void AbrirTelaSelecaoImagem()
        {
            //CRIAR TELA AQUI 
            throw new NotImplementedException();
        }
    }
}
