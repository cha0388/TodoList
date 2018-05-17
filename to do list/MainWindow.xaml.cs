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

namespace to_do_list
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            TodoItem item = new TodoItem();

            TodoList.Children.Add(item);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            List<string> all = new List<string>();
            foreach(TodoItem item in TodoList.Children)
            {
                all.Add(item.GetTaskName());
            }
            System.IO.File.WriteAllLines(@"c:\tododata.txt", all);
        }

        

        private void Open_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
