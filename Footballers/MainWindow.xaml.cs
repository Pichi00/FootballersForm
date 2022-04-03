using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Footballers
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listBoxFootballers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lbox = sender as ListBox;
            var item = lbox.SelectedItem as Footballer;
            if ((lbox.SelectedItems.Count > -1) && (item != null))
            {
                textBoxName.Text = item.Name;
                textBoxSurname.Text = item.Surname;
                textBoxWeight.Text = item.Weight.ToString();
                textBoxHeight.Text = item.Height.ToString();
                comboBoxPosition.Text = item.Position.ToString();
            }
        }

        private bool isNotEmpty(TextBoxWithErrorProvider tb)
        {
            if (tb.Text.Trim() == "")
            {
                tb.SetError("Field cannot be empty.");
                return false;
            }
            tb.SetError("");
            return true;
        }

        private bool isNum(TextBoxWithErrorProvider tb)
        {
            if(int.TryParse(tb.Text, out int num)) 
            {
                tb.SetError("");
                return true; 
            }
            tb.SetError("The value has to be an intiger number");
            return false;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if(isNotEmpty(textBoxName) & isNotEmpty(textBoxSurname) & (isNotEmpty(textBoxHeight) && isNum(textBoxHeight)) & (isNotEmpty(textBoxWeight) && isNum(textBoxWeight)) )
            {
                var n = textBoxName.Text;
                var s = textBoxSurname.Text;
                var h = int.Parse(textBoxHeight.Text);
                var w = int.Parse(textBoxWeight.Text);
                var p = (Position) comboBoxPosition.SelectedIndex;
                var f1 = new Footballer(n, s, h, w, p);
                listBoxFootballers.Items.Add(f1);
            }
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if ((isNotEmpty(textBoxName) & isNotEmpty(textBoxSurname) & (isNotEmpty(textBoxHeight) && isNum(textBoxHeight)) & (isNotEmpty(textBoxWeight) && isNum(textBoxWeight))) && (listBoxFootballers.SelectedItem != null))
            {
                var f1 = new Footballer(listBoxFootballers.SelectedItem as Footballer);

                f1.Name = textBoxName.Text;
                f1.Surname = textBoxSurname.Text;
                f1.Height = int.Parse(textBoxHeight.Text.ToString());
                f1.Weight = int.Parse(textBoxWeight.Text.ToString());
                f1.Position = (Position) comboBoxPosition.SelectedIndex;

                listBoxFootballers.Items[listBoxFootballers.SelectedIndex] = f1;
            }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxFootballers.SelectedItem != null)
            {
                listBoxFootballers.Items.Remove(listBoxFootballers.SelectedItem);
            }
        }
    }
}
