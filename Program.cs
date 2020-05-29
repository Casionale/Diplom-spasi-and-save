using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom2.Choose;
using Diplom2.Theory;
using Diplom2.Test;

namespace Diplom2
{
    static class Program
    {
        static public ChooseForm chooseForm;
        static public FormDiagram formDiagram;
        static public TestForm testForm;
        static public TheoryForm theoryForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChooseForm());
        }
    }
}
