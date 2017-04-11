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
using System.Windows.Shapes;
//using System.Windows.Forms;

namespace Tree
{
    /* Окно для входа под определенным пользователем, для изменения данных
     * о своих родственниках
     */
    public partial class EnterToAccount : Window
    {
        public EnterToAccount()
        {
            InitializeComponent();
            
            

        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
        /*private void KeyEvents(object sender, KeyEventArgs e)
        {
            
            if(Keyboard.Modifiers == ModifierKeys.Control && Keyboard.Modifiers == ModifierKeys.Shift && e.Key == Key.Space)
            //if (e. == Keys.Control & e.KeyCode == Keys.Shift & e.KeyCode == Keys.Space)
            {
                System.Windows.MessageBox.Show("Enter Key Pressed ");
            }
        }*/
    }
}
