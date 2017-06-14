using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using View;
using System.Collections;

namespace OrderApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserView view = new UserView();
            view.Visible = false;

            // Add some dummy data
            IList users = new ArrayList();
            users.Add(new User("Syed", "Rafi", "122", "gmail", "Dhaka"));
            users.Add(new User("Kazi", "Mostofa", "123", "gmail", "USA"));
            users.Add(new User("Refat", "Harper", "124", "gmail", "Canada"));

            UserController controller = new UserController(view, users);

            controller.LoadView();
            view.ShowDialog();
            
        }
    }
}
