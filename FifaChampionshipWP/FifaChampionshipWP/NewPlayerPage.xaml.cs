using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace FifaChampionshipWP
{
    public partial class NewPlayer : PhoneApplicationPage
    {

        private CameraCaptureTask cameraCaptureTask;


        public NewPlayer()
        {
            InitializeComponent();
            Transitions.UseSlideTransition(this, SlideTransitionMode.SlideUpFadeIn, SlideTransitionMode.SlideUpFadeOut);
            cameraCaptureTask = new CameraCaptureTask();
            cameraCaptureTask.Completed += new EventHandler<PhotoResult>(cameraCaptureTask_Completed);
            
        }

        private void cameraCaptureTask_Completed(object sender, PhotoResult e)
        {
            var bitmap = new BitmapImage();
            bitmap.SetSource(e.ChosenPhoto);
            this.ImageBox.Source = bitmap;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.cameraCaptureTask.Show();
        }
    }
}