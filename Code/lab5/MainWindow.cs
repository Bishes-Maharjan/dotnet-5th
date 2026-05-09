using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia;
using System;

namespace AvaloniaCalc
{
    public class MainWindow : Window
    {
        private TextBox txtInput1, txtInput2, txtOutput;

        public MainWindow()
        {
            Title = "Simple Calculator";
            Width = 300;
            Height = 280;
            CanResize = false;

            // Input 1
            var lblInput1 = new TextBlock { Text = "Input 1:", VerticalAlignment = VerticalAlignment.Center };
            txtInput1 = new TextBox { Text = "5", Width = 160 };
            var row1 = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Spacing = 10,
                Children = { lblInput1, txtInput1 }
            };

            // Input 2
            var lblInput2 = new TextBlock { Text = "Input 2:", VerticalAlignment = VerticalAlignment.Center };
            txtInput2 = new TextBox { Text = "5", Width = 160 };
            var row2 = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Spacing = 10,
                Children = { lblInput2, txtInput2 }
            };

            // Output
            var lblOutput = new TextBlock { Text = "Output:", VerticalAlignment = VerticalAlignment.Center };
            txtOutput = new TextBox { IsReadOnly = true, Width = 160 };
            var row3 = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Spacing = 10,
                Children = { lblOutput, txtOutput }
            };

            // Buttons
            var btnAdd      = new Button { Content = "+", Width = 60, Height = 40 };
            var btnSubtract = new Button { Content = "-", Width = 60, Height = 40 };
            var btnDivide   = new Button { Content = "÷", Width = 60, Height = 40 };
            var btnMultiply = new Button { Content = "×", Width = 60, Height = 40 };

            btnAdd.Click      += (s, e) => Calculate("+");
            btnSubtract.Click += (s, e) => Calculate("-");
            btnDivide.Click   += (s, e) => Calculate("÷");
            btnMultiply.Click += (s, e) => Calculate("×");

            var buttonRow1 = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Spacing = 8,
                HorizontalAlignment = HorizontalAlignment.Center,
                Children = { btnAdd, btnSubtract, btnDivide }
            };

            var buttonRow2 = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center,
                Children = { btnMultiply }
            };

            // Main layout
            Content = new StackPanel
            {
                Margin = new Thickness(20),
                Spacing = 14,
                Children = { row1, row2, row3, buttonRow1, buttonRow2 }
            };
        }

        private void Calculate(string operation)
        {
            try
            {
                double num1 = double.Parse(txtInput1.Text ?? "");
                double num2 = double.Parse(txtInput2.Text ?? "");
                double result;

                switch (operation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "×": result = num1 * num2; break;
                    case "÷":
                        if (num2 == 0)
                            throw new DivideByZeroException("Error: divide by zero");
                        result = num1 / num2;
                        break;
                    default: return;
                }

                txtOutput.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                txtOutput.Text = ex.Message;
            }
            catch (FormatException)
            {
                txtOutput.Text = "Error: enter valid numbers";
            }
            finally
            {
                // finally always runs regardless of success or error
                Console.WriteLine("Calculation attempted.");
            }
        }
    }
}