using LeTrungHieu_dtc235140044.ViewModel;

namespace LeTrungHieu_dtc235140044
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(DetailViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
