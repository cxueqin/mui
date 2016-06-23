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
using FirstFloor.ModernUI.Windows.Controls;

namespace FirstFloor.ModernUI.App.Content
{
    /// <summary>
    /// Interaction logic for LoremIpsumSplit.xaml
    /// </summary>
    public partial class LoremIpsumGrid : UserControl
    {
        public LoremIpsumGrid()
        {
            InitializeComponent();
            border = new Rectangle();
            jiugongGrid.Children.Add(border);
        }

        private void label_Copy7_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void label_Copy7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //ModernDialog是FirstFloor.ModernUI.Windows.Controls的控件，需要显示添加
            var dlg = new ModernDialog
            {
                Title = "Common dialog",
                Content = new LoremIpsum()
            };

            dlg.Buttons = new Button[] { dlg.OkButton, dlg.CancelButton };
            dlg.ShowDialog();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource.GetType() == typeof(TextBlock))
            {
                TextBlock block = (TextBlock)e.OriginalSource;
                //DependencyProperty dpr = block.GetValue(Grid.RowProperty)
                //DependencyProperty dpc = block.GetValue(Grid.ColumnProperty)

                int row = Grid.GetRow(block);
                int column = Grid.GetColumn(block);

                border.Fill = Brushes.Red;
                //border.setValue(Grid.RowProperty, row);
                //border.setValue(Grid.ColumnProperty, column);
                Grid.SetColumn(border, column);
                Grid.SetRow(border, row);
                Grid.SetZIndex(border, -10);
            }
        }
    }
}
