using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testTriggerWpf.Controls
{
    /// <summary>
    /// Логика взаимодействия для MyToggleButton.xaml
    /// </summary>
    public partial class MyToggleButton : UserControl
    {
        //private string OPENDATA = "M0,0L32,0 16,19.745z";
        //private string CLOSEDATA = "M16,0L32,19.745 0,19.745z";

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(MyToggleButton), new PropertyMetadata(false));




        public string ArrowData
        {
            get { return (string)GetValue(ArrowDataProperty); }
            set { SetValue(ArrowDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowDataProperty =
            DependencyProperty.Register("ArrowData", typeof(string), typeof(MyToggleButton), new PropertyMetadata("M0,0L32,0 16,19.745z"));



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MyToggleButton), new PropertyMetadata("", OnDPTextChange));

        private static void OnDPTextChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MyToggleButton myd && ((string)e.NewValue == ""))
            {
                //myd.Text = myd.ClosingText;
            }
        }

        public string OpeningText
        {
            get { return (string)GetValue(OpeningTextProperty); }
            set { SetValue(OpeningTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OpeningText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OpeningTextProperty =
            DependencyProperty.Register("OpeningText", typeof(string), typeof(MyToggleButton), new PropertyMetadata("настройка соединения"));



        public string ClosingText
        {
            get { return (string)GetValue(ClosingTextProperty); }
            set { SetValue(ClosingTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClosingText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClosingTextProperty =
            DependencyProperty.Register("ClosingText", typeof(string), typeof(MyToggleButton), new PropertyMetadata("закрыть настройку"));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Command.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(MyToggleButton), new PropertyMetadata(null));

        public MyToggleButton()
        {
            InitializeComponent();
            OpeningText = ClosingText = "настройки соединения";
            ArrowData = "M0,0L32,0 16,19.745z";
        }
    }
}
