using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfCustomUserControlWithParamsDemo.UserControls
{
    /// <summary>
    /// Interaction logic for ImageRowUC.xaml
    /// </summary>
    public partial class ImageRowUC : UserControl
    {
        #region Fields

        // Register the dependency property (identifier, data type of property, type of the user control carrying
        // that property and optionally metadata, e.g. default value)
        // and give it an identifier

        public static readonly DependencyProperty AltImgPathProperty = DependencyProperty.Register("AltImgPath", typeof(string), typeof(ImageRowUC));

        public static readonly DependencyProperty ImgPathProperty = DependencyProperty.Register("ImgPath", typeof(string), typeof(ImageRowUC));

        public static readonly DependencyProperty ImgTitleProperty = DependencyProperty.Register("ImgTitle", typeof(string), typeof(ImageRowUC));
        #endregion Fields

        #region Properties

        public string AltImgPath
        {
            get { return (string)GetValue(AltImgPathProperty); }
            set { SetValue(AltImgPathProperty, value); }
        }

        public string ImgPath
        {
            get { return (string)GetValue(ImgPathProperty); }
            set { SetValue(ImgPathProperty, value); }
        }

        // Define CLR wrappers for the DependencyProperties using GetValue and SetValue

        public string ImgTitle
        {
            get { return (string)GetValue(ImgTitleProperty); }
            set { SetValue(ImgTitleProperty, value); }
        }
        #endregion Properties

        #region Constructors

        public ImageRowUC()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UC_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(AltImgPath, UriKind.Relative));
        }

        private void UC_MouseLeave(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(ImgPath, UriKind.Relative));
        }

        #endregion Methods
    }
}
