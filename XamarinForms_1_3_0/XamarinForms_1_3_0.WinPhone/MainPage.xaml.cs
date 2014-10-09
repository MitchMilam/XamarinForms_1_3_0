using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace XamarinForms_1_3_0.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();

            LoadApplication(new MyApp());
        }
    }
}
