using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Requital
{
    public class Assets
    {
        public BitmapImage ex = new BitmapImage();
        // MAPS \\
        public BitmapImage cave = new BitmapImage();

        // ROUGE \\
        public BitmapImage rouge_left_1 = new BitmapImage();
        public BitmapImage rouge_left_2 = new BitmapImage();
        public BitmapImage rouge_left_3 = new BitmapImage();
        public BitmapImage rouge_left_4 = new BitmapImage();
        public BitmapImage rouge_left_5 = new BitmapImage();
        public BitmapImage rouge_left_6 = new BitmapImage();
        public BitmapImage rouge_left_7 = new BitmapImage();
        public BitmapImage rouge_left_8 = new BitmapImage();
        public BitmapImage rouge_right_1 = new BitmapImage();
        public BitmapImage rouge_right_2 = new BitmapImage();
        public BitmapImage rouge_right_3 = new BitmapImage();
        public BitmapImage rouge_right_4 = new BitmapImage();
        public BitmapImage rouge_right_5 = new BitmapImage();
        public BitmapImage rouge_right_6 = new BitmapImage();
        public BitmapImage rouge_right_7 = new BitmapImage();
        public BitmapImage rouge_right_8 = new BitmapImage();
        public BitmapImage rouge_up_1 = new BitmapImage();
        public BitmapImage rouge_up_2 = new BitmapImage();
        public BitmapImage rouge_up_3 = new BitmapImage();
        public BitmapImage rouge_up_4 = new BitmapImage();
        public BitmapImage rouge_up_5 = new BitmapImage();
        public BitmapImage rouge_up_6 = new BitmapImage();
        public BitmapImage rouge_up_7 = new BitmapImage();
        public BitmapImage rouge_up_8 = new BitmapImage();
        public BitmapImage rouge_down_1 = new BitmapImage();
        public BitmapImage rouge_down_2 = new BitmapImage();
        public BitmapImage rouge_down_3 = new BitmapImage();
        public BitmapImage rouge_down_4 = new BitmapImage();
        public BitmapImage rouge_down_5 = new BitmapImage();
        public BitmapImage rouge_down_6 = new BitmapImage();
        public BitmapImage rouge_down_7 = new BitmapImage();
        public BitmapImage rouge_down_8 = new BitmapImage();

        //Title Image
        public BitmapImage title = new BitmapImage();

        //Dessert to Cave
        public BitmapImage dToC = new BitmapImage();

        // Desert to Town
        public BitmapImage dToT = new BitmapImage();

        // Cave Battle screen
        public BitmapImage cave_battle = new BitmapImage();

        //Desert battle screen
        public BitmapImage desert_battle = new BitmapImage();

        public void LoadImages()
        {
            ex.BeginInit();
            ex.UriSource = new Uri("pack://application:,,,/Requital;component/assets/ex.png");
            ex.EndInit();

            // MAPS \\
            cave.BeginInit();
            cave.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Maps/Cave.png");
            cave.EndInit();

            // ROUGE \\

            // left
            rouge_left_1.BeginInit();
            rouge_left_1.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/1.png");
            rouge_left_1.EndInit();

            rouge_left_2.BeginInit();
            rouge_left_2.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/2.png");
            rouge_left_2.EndInit();

            rouge_left_3.BeginInit();
            rouge_left_3.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/3.png");
            rouge_left_3.EndInit();

            rouge_left_4.BeginInit();
            rouge_left_4.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/4.png");
            rouge_left_4.EndInit();

            rouge_left_5.BeginInit();
            rouge_left_5.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/5.png");
            rouge_left_5.EndInit();

            rouge_left_6.BeginInit();
            rouge_left_6.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/6.png");
            rouge_left_6.EndInit();

            rouge_left_7.BeginInit();
            rouge_left_7.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/7.png");
            rouge_left_7.EndInit();

            rouge_left_8.BeginInit();
            rouge_left_8.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_left/8.png");
            rouge_left_8.EndInit();

            // right
            rouge_right_1.BeginInit();
            rouge_right_1.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/1.png");
            rouge_right_1.EndInit();

            rouge_right_2.BeginInit();
            rouge_right_2.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/2.png");
            rouge_right_2.EndInit();

            rouge_right_3.BeginInit();
            rouge_right_3.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/3.png");
            rouge_right_3.EndInit();

            rouge_right_4.BeginInit();
            rouge_right_4.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/4.png");
            rouge_right_4.EndInit();

            rouge_right_5.BeginInit();
            rouge_right_5.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/5.png");
            rouge_right_5.EndInit();

            rouge_right_6.BeginInit();
            rouge_right_6.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/6.png");
            rouge_right_6.EndInit();

            rouge_right_7.BeginInit();
            rouge_right_7.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/7.png");
            rouge_right_7.EndInit();

            rouge_right_8.BeginInit();
            rouge_right_8.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_right/8.png");
            rouge_right_8.EndInit();

            // down
            rouge_down_1.BeginInit();
            rouge_down_1.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/1.png");
            rouge_down_1.EndInit();

            rouge_down_2.BeginInit();
            rouge_down_2.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/2.png");
            rouge_down_2.EndInit();

            rouge_down_3.BeginInit();
            rouge_down_3.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/3.png");
            rouge_down_3.EndInit();

            rouge_down_4.BeginInit();
            rouge_down_4.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/4.png");
            rouge_down_4.EndInit();

            rouge_down_5.BeginInit();
            rouge_down_5.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/5.png");
            rouge_down_5.EndInit();

            rouge_down_6.BeginInit();
            rouge_down_6.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/6.png");
            rouge_down_6.EndInit();

            rouge_down_7.BeginInit();
            rouge_down_7.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/7.png");
            rouge_down_7.EndInit();

            rouge_down_8.BeginInit();
            rouge_down_8.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_down/8.png");
            rouge_down_8.EndInit();

            // up
            rouge_up_1.BeginInit();
            rouge_up_1.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/1.png");
            rouge_up_1.EndInit();

            rouge_up_2.BeginInit();
            rouge_up_2.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/2.png");
            rouge_up_2.EndInit();

            rouge_up_3.BeginInit();
            rouge_up_3.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/3.png");
            rouge_up_3.EndInit();

            rouge_up_4.BeginInit();
            rouge_up_4.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/4.png");
            rouge_up_4.EndInit();

            rouge_up_5.BeginInit();
            rouge_up_5.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/5.png");
            rouge_up_5.EndInit();

            rouge_up_6.BeginInit();
            rouge_up_6.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/6.png");
            rouge_up_6.EndInit();

            rouge_up_7.BeginInit();
            rouge_up_7.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/7.png");
            rouge_up_7.EndInit();

            rouge_up_8.BeginInit();
            rouge_up_8.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rouge/moving_up/8.png");
            rouge_up_8.EndInit();

            //Title Screen
            title.BeginInit();
            title.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Transition/Title.png");
            title.EndInit();

            //Desert to Cave
            dToC.BeginInit();
            dToC.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Transition/SandtoCaveTransition.png");
            dToC.EndInit();

            // Desert to town
            dToT.BeginInit();
            dToT.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Transition/Townpicture.jpg");
            dToT.EndInit();

            //Cave Battle Screen
            cave_battle.BeginInit();
            cave_battle.UriSource = new Uri("pack://application:,,,/Requital;component/assets/BattleScreen/CaveBackground.jpg", UriKind.Absolute);
            cave_battle.EndInit();

            //Desert Battle Screen
            desert_battle.BeginInit();
            desert_battle.UriSource = new Uri("pack://application:,,,/Requital;component/assets/BattleScreen/DesertBackground.jpg");
            desert_battle.EndInit();
        }
    }
}
