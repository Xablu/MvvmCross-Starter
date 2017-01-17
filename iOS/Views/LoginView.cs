using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace BasicApp.iOS.Views
{
    public partial class LoginView : MvxViewController
    {
        public LoginView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<LoginView, Core.ViewModels.LoginViewModel>();
            //set.Bind(Label).To(vm => vm.Hello);
            //set.Bind(TextField).To(vm => vm.Hello);
            set.Apply();
        }
    }
}
