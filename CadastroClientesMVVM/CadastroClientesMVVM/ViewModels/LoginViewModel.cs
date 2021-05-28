using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CadastroClientesMVVM.ViewModels
{
    public class LoginViewModel
    {

        public MvvmHelpers.Commands.Command LoginCommand { get; }

        private INavigation _navigation;


        string _usuario;
        public string Usuario
        {
            get { return _usuario; }
            set
            {
                if (_usuario != value)
                {
                    _usuario = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }

        string _senha;
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (_senha != value)
                {
                    _senha = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }

        public LoginViewModel(INavigation navigation)
        {
            LoginCommand = new MvvmHelpers.Commands.Command<string>(VerificarLogin);
            _navigation = navigation;
        }

        public void VerificarLogin(string senha)
        {

        }

    }
}
