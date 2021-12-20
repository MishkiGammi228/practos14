using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_13
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (txtPass.Password == "123") Close();
            else
            {
                MessageBox.Show("Пароль введен неверно");
                txtPass.Focus();
            }
        }

        private void Exite_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
