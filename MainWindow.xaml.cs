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
using Library1;
using WpfCustomControlLibrary1;

namespace Library
{
    public partial class MainWindow : Window
    {
        private MyClass myObject = new MyClass() { Name = "John", Age = 30 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Serialize_Click(object sender, RoutedEventArgs e)
        {
            SerializationHelper.Serialize("test", myObject);
            textBox.Text = "Объект успешно сохранён.";
        }
    }

    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
