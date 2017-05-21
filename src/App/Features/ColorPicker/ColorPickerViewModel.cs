using System;
using System.Drawing;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ColorPicker
{
    public class ColorPickerViewModel : ReactiveObject
    {
        public ColorPickerViewModel()
        {
            this.WhenAnyValue(
                    viewModel => viewModel.Red,
                    viewModel => viewModel.Green,
                    viewModel => viewModel.Blue, Color.FromArgb)
                .ToPropertyEx(this, vm => vm.Color);

            this.WhenAnyValue(viewModel => viewModel.Color, ToHexidecimal)
                .ToPropertyEx(this, viewModel => viewModel.ColorAsHexidecimal);
        }

        [Reactive]
        public int Red { get; set; }

        [Reactive]
        public int Green { get; set; }

        [Reactive]
        public int Blue { get; set; }

        public extern Color Color { [ObservableAsProperty] get; }
        public extern string ColorAsHexidecimal { [ObservableAsProperty] get; }

        private string ToHexidecimal(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}