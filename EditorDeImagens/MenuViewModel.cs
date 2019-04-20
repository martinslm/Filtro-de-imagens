using System;
using System.Windows.Input;
using System.Windows;

namespace EditorDeImagens
{
    class MenuViewModel
    {
        public ColorConvertedBitmapExtension imagemSelecionada;
        private ICommand _filtroNegativoCommand;
        private ICommand _filtroEscalasCommand;
        private ICommand _filtroRuidosCommand;
        private ICommand _filtroBlurCommand;
        private ICommand _filtroLimiarizacaoCommand;
        private ICommand _filtroBinarioCommand;

        public ICommand FiltroNegativoCommand
        {
            get { return _filtroNegativoCommand; }
        }
        public ICommand FiltroEscalasCommand
        {
            get { return _filtroEscalasCommand; }
        }
        public ICommand FiltroRuidosCommand
        {
            get { return _filtroRuidosCommand; }
        }
        public ICommand FiltroBlurCommand
        {
            get { return _filtroBlurCommand; }
        }
        public ICommand FiltroLimiarizacaoCommand
        {
            get { return _filtroLimiarizacaoCommand; }
        }
        public ICommand FiltroBinarioCommand
        {
            get { return _filtroBinarioCommand; }
        }
        public Action AbrirTelaSelecaoImagem { get; set; }

        public MenuViewModel()
        {
            InstanciarCommands();
        }

        private void InstanciarCommands()
        {
           _filtroNegativoCommand = new CommandHandler(p => Negativo());
           _filtroEscalasCommand = new CommandHandler(p => Escalas());
           _filtroRuidosCommand = new CommandHandler(p => Ruidos());
           _filtroBlurCommand = new CommandHandler(p => Blur()); 
           _filtroLimiarizacaoCommand = new CommandHandler(p => Limiarizacao());
           _filtroBinarioCommand = new CommandHandler(p => Binario());

        }

        private void Binario()
        {
            AbrirTelaSelecaoImagem();
     
        }

        private void Limiarizacao()
        {
            AbrirTelaSelecaoImagem();
        }

        private void Blur()
        {
            AbrirTelaSelecaoImagem();
        }

        private void Ruidos()
        {
            AbrirTelaSelecaoImagem();
            
            //larissa
        }

        private void Escalas()
        {
            AbrirTelaSelecaoImagem();
            //larissa
        }

        private void Negativo()
        {
            AbrirTelaSelecaoImagem();
            //larissa
        }
    }
}
