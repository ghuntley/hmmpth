using System.Windows.Forms;
using ReactiveUI;

namespace ColorPicker
{
    public partial class ColorPickerControl : UserControl, IViewFor<ColorPickerViewModel>
    {
        public ColorPickerControl()
        {
            InitializeComponent();

            ViewModel = new ColorPickerViewModel();

            ViewModel.Blue = 255;

            this.Bind(ViewModel, viewModel => viewModel.Red, view => view.RedTrackBar.Value);
            this.Bind(ViewModel, viewModel => viewModel.Green, view => view.GreenTrackBar.Value);
            this.Bind(ViewModel, viewModel => viewModel.Blue, view => view.BlueTrackBar.Value);

            this.OneWayBind(ViewModel, viewModel => viewModel.Red, view => view.RedValue.Text);
            this.OneWayBind(ViewModel, viewModel => viewModel.Green, view => view.GreenValue.Text);
            this.OneWayBind(ViewModel, viewModel => viewModel.Blue, view => view.BlueValue.Text);
        }


        public ColorPickerViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ColorPickerViewModel)value; }
        }
    }
}