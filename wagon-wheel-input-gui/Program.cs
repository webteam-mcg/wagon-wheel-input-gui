using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wagon_wheel_input_gui
{
    public class Program
    {
        public static int X, Y;
        public static String Sess;
        public static ArrayList PlayerList1,PlayerList2;

        public Program()
        {
            PlayerList1 = new ArrayList();
            PlayerList2 = new ArrayList();
            /*PlayerList1.Add("Player 1");
            PlayerList1.Add("Player 2");
            PlayerList2.Add("Player 1");
            PlayerList2.Add("Player 2");*/
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Program();
            try
            {
                RequestHandler.playerList();
                RequestHandler.addShotAsync("888", "MCG", 76, 6, 1920, 1080);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUi());
        }
    }
}
