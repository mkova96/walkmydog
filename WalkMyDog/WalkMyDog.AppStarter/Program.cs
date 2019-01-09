using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkMyDog.BaseLib;
using WalkMyDog.PresentationLayer;
using WalkMyDog.Model;
using WalkMyDog.Controllers;
using System.Windows.Forms;
using WalkMyDog.MemoryBasedDAL.Repositories;

namespace WalkMyDog.AppStarter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            IWindowFormsFactory WindowsFormsFactory = new WindowFormsFactory();

            UserRepository UserRepository = new UserRepository();
            AdRepository AdRepository = new AdRepository();

            MainFormController MainController = new MainFormController(WindowsFormsFactory, UserRepository, AdRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WalkMyDog.PresentationLayer.MainForm(MainController));
        }
    }
}
