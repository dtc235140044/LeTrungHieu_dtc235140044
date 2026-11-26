using LeTrungHieu_dtc235140044.ViewModel;

namespace LeTrungHieu_dtc235140044
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
