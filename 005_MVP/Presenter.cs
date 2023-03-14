using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_MVP
{
    class Presenter
    {
        readonly Model model;
        readonly MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.MyEvent += MainWindow_MyEvent;
        }

        private void MainWindow_MyEvent(object sender, EventArgs e)
        {
            this.mainWindow.textBox1.Text = this.model.SomeMethod(this.mainWindow.textBox1.Text);
        }
    }
}
