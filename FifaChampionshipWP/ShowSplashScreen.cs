using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace FifaChampionshipWP
{
    public class ShowSplashScreen
    {
        private static Popup _popup;
        private static BackgroundWorker backroungWorker;

        /// <summary>
        /// Show a load screen for 5 seconds
        /// </summary>
        /// <param name="screen"></param>
        public static void Show(UIElement screen)
        {
            _popup = new Popup();
            _popup.Child = screen;
            _popup.IsOpen = true;
            StartLoadingData();
        }

        private static void StartLoadingData()
        {
            backroungWorker = new BackgroundWorker();
            backroungWorker.DoWork += new DoWorkEventHandler(backroungWorker_DoWork);
            backroungWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backroungWorker_RunWorkerCompleted);
            backroungWorker.RunWorkerAsync();
        }

        static void backroungWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
        }
        static void backroungWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _popup.IsOpen = false;
        }
    }
}
