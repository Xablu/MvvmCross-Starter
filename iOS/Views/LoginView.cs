using BasicApp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace BasicApp.iOS.Views
{
    public partial class LoginView : MvxViewController<LoginViewModel>
    {
        public LoginView() : base("LoginView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<LoginView, LoginViewModel>();
            set.Bind(txtUsername).To(vm => vm.Username);
            set.Bind(txtPassword).To(vm => vm.Password);
            set.Bind(btnLogin).To(vm => vm.LoginCommand);
            set.Apply();
        }
    }
}
