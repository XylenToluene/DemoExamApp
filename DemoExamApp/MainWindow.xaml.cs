using DemoExamApp.DB;
using Microsoft.EntityFrameworkCore;
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

namespace DemoExamApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            MyContext Db = new MyContext();
            User user = new User();

            try
            {
                  
                user = Db.Users.Include(u=>u.userStatus).SingleOrDefault(x => x.Login == tbLogin.Text
                && x.Password == tbPassword.Password.ToString()
                );

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            switch (user.userStatus.Id)
            {
                case 1:
                    {
                        MessageBox.Show("Вы вошли как user");
                        return;
                    }
                case 2:
                    {
                        MessageBox.Show("Вы вошли как manager");
                        return;
                    }
                case 3:
                    {
                        MessageBox.Show("Вы вошли как admin");
                        return;
                    }
            }
        }

        private void btLoginGuest_Click(object sender, RoutedEventArgs e)
        {
            MyForms.GuestWindow guestWindow = new MyForms.GuestWindow();
            guestWindow.Show();
            Close();
        }
    }
}
