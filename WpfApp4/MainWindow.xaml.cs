using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MahApps.Metro.Controls;

namespace WpfApp4
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        #region DataModel

        public class Albums
        {
            public string Name { get; set; }
            public string Title { get; set; }
        }
        private ObservableCollection<Albums> _Artists = new ObservableCollection<Albums>();
        public ObservableCollection<Albums> Artists
        {
            get
            {
                return _Artists;
            } }
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            Artists.Add(new Albums(){Name =  "Test1", Title =  "TestTitle1"});
            this.DataContext = Artists;
        }
    }
}
