using System.Reflection;
using Android.App;
using Android.OS;
using Android.Runtime;
using Xamarin.Android.NUnitLite;

namespace XamarinUnitTestsVsts.Android.Service.Test
{
    [Activity(Label = "XamarinUnitTestsVsts.Android.Service.Test", MainLauncher = true, Icon = "@drawable/icon")]
    [Register("XamarinUnitTestsVsts.Android.Service.Test.MainActivity")]
    public class MainActivity : TestSuiteActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            // tests can be inside the main assembly
            AddTest(Assembly.GetExecutingAssembly());
            // or in any reference assemblies
            // AddTest (typeof (Your.Library.TestClass).Assembly);

            // Once you called base.OnCreate(), you cannot add more assemblies.
            base.OnCreate(bundle);
        }
    }
}

