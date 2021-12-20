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
using Microsoft.Win32;
using System.IO;

namespace Lab_13
{
    /// <summary>
    /// Логика взаимодействия для Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public int RowSave { get; private set; }
        public int ColumnSave { get; private set; }
        public Options(int rowCount = 0, int columnCount = 0)
        {
            InitializeComponent();
            RowSave = rowCount;
            ColumnSave = columnCount;
            newRow.Text = rowCount.ToString();
            newColumn.Text = columnCount.ToString();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(newRow.Text, out int row))
            {
                data1.RowMatrix = row;
            }
            else
            {
                MessageBox.Show("Ошибка в номере строки");
                newRow.Focus();
                return;
            }

            if (int.TryParse(newColumn.Text, out int column))
            {
                data1.ColumnMatrix = column;
            }
            else
            {
                MessageBox.Show("Ошибка в номере столбца");
                newColumn.Focus();
                return;
            }
            RowSave = row;
            ColumnSave = column;
            this.Close();
         }

        private void Window_Activated(object sender, EventArgs e)
        {
            newRow.Focus();
            newRow.Text = data1.RowMatrix.ToString();
            newColumn.Text = data1.ColumnMatrix.ToString();
        }
    }
}
