using BasicApp.Core.Interfaces;
using MvvmCross.Core.ViewModels;

namespace BasicApp.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _username;
        public string Username
        { 
            get { return _username; }
            set { SetProperty (ref _username, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private readonly ILoginService _loginService;

        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;
        }

        private IMvxCommand _loginCommand;
        public  IMvxCommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new MvxCommand(AttemptLogin);
                return _loginCommand;
            }
        }

        private void AttemptLogin()
        {
            if (_loginService.Login(Username, Password))
            {
                ShowViewModel<MainViewModel>();
            }
        }
    }
}
