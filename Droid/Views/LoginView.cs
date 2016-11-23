using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace BasicApp.Droid.Views
{
    [Activity(Label = "Login")]
    public class LoginView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginView);
        }
    }
}
