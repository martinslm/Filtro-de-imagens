using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace EditorDeImagens
{
    class MenuViewModel
    {
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
            throw new NotImplementedException();
        }

        private void Limiarizacao()
        {
            throw new NotImplementedException();
        }

        private void Blur()
        {
            throw new NotImplementedException();
        }

        private void Ruidos()
        {
            throw new NotImplementedException();
        }

        private void Escalas()
        {
            throw new NotImplementedException();
        }

        private void Negativo()
        {
            throw new NotImplementedException();
        }
    }
}
