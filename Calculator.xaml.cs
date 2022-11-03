using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Day09App
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Calculator : Page
    {
        public Calculator()
        {
            this.InitializeComponent();
        }

        // Add two numbers together
        public void Add(double a, double b)
        {
            //Console.WriteLine($"{a} + {b} = " + (a + b));
            ResultTextBox.Text = (a + b).ToString();
        }

        // Subtract two numbers
        public void Subtract(double a, double b)
        {
            //Console.WriteLine($"{a} - {b} = " + (a - b));
            ResultTextBox.Text = (a - b).ToString();
        }

        // Multiply two numbers
        public void Multiply(double a, double b)
        {
            //Console.WriteLine($"{a} * {b} = " + (a * b));
            ResultTextBox.Text = (a * b).ToString();
        }

        // Divide two numbers by one
        public async void Divide(double a, double b)
        {
            if (b == 0)
            {
                //Console.WriteLine("The divisor can not be zero!");
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "The divisor can not be zero!",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }
            else
            {
                //Console.WriteLine($"{a} / {b} = " + (a / b));
                ResultTextBox.Text = (a / b).ToString();
            }
        }

        // Radication
        public async void Radication(double a)
        {
            if (a < 0)
            {
                //Console.WriteLine("The radicand can not less than 0!");
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "The radicand can not less than 0!",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }
            else
            {
                //Console.WriteLine($"The square root of {a} is " + Math.Sqrt(a));
                ResultTextBox.Text = Math.Sqrt(a).ToString();
            }
        }

        // Power
        public void Power(double a, double b)
        {
            //Console.WriteLine($"{a} ^ {b} = " + Math.Pow(a, b));
            ResultTextBox.Text = Math.Pow(a, b).ToString();
        }

        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber;
            double secondNumber;

            if (!double.TryParse(FirstNumberTextBox.Text, out firstNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            if (!double.TryParse(SecondNumberTextBox.Text, out secondNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            this.Add(firstNumber, secondNumber);
        }

        private async void Subtract_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber;
            double secondNumber;

            if (!double.TryParse(FirstNumberTextBox.Text, out firstNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            if (!double.TryParse(SecondNumberTextBox.Text, out secondNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            this.Subtract(firstNumber, secondNumber);
        }

        private async void Multiply_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber;
            double secondNumber;

            if (!double.TryParse(FirstNumberTextBox.Text, out firstNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            if (!double.TryParse(SecondNumberTextBox.Text, out secondNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            this.Multiply(firstNumber, secondNumber);
        }

        private async void Divide_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber;
            double secondNumber;

            if (!double.TryParse(FirstNumberTextBox.Text, out firstNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            if (!double.TryParse(SecondNumberTextBox.Text, out secondNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            this.Divide(firstNumber, secondNumber);
        }

        private async void Radication_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber;

            if (!double.TryParse(FirstNumberTextBox.Text, out firstNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            this.Radication(firstNumber);
        }

        private async void Power_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber;
            double secondNumber;

            if (!double.TryParse(FirstNumberTextBox.Text, out firstNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            if (!double.TryParse(SecondNumberTextBox.Text, out secondNumber))
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    Title = "An error occurred in the calculation",
                    Content = "What you type does not conform to the mathematical rules, please check again.",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }

            this.Power(firstNumber, secondNumber);
        }
    }
}
