using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Runtime;

namespace CSE
{
    [Activity(Label = "CSE", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ImageButton ImageButtonsPlayerSouris;
        private ImageButton ImageButtonsPlayerChat;
        private ImageButton ImageButtonsPlayerElephant;

        private string ImagePlayerSelected;
        private string ImageComputerSelected;
        private string ResultOfPlay;

        private TextView ScoreComputer;
        private TextView ScorePlayer;

        private TextView ResultOfMatch;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ImageButtonsPlayerSouris = FindViewById<ImageButton>(Resource.Id.ibtnPlayerSouris);
            ImageButtonsPlayerChat = FindViewById<ImageButton>(Resource.Id.ibtnPlayerChat);
            ImageButtonsPlayerElephant = FindViewById<ImageButton>(Resource.Id.ibtnPlayerElephant);

            ScoreComputer = FindViewById<TextView>(Resource.Id.txvScoreComputer);
            ScorePlayer = FindViewById<TextView>(Resource.Id.txvScorePlayer);

            ImageButtonsPlayerSouris.SetImageResource(Resource.Mipmap.souris);
            ImageButtonsPlayerChat.SetImageResource(Resource.Mipmap.chat);
            ImageButtonsPlayerElephant.SetImageResource(Resource.Mipmap.elephant);

            ImageButtonsPlayerSouris.Click += ImageButtonsPlayerSouris_Click;
            ImageButtonsPlayerChat.Click += ImageButtonsPlayerChat_Click;
            ImageButtonsPlayerElephant.Click += ImageButtonsPlayerElephant_Click;

            ResultOfMatch = FindViewById<TextView>(Resource.Id.txtResult);

        }

        private void ImageButtonsPlayerSouris_Click(object sender, System.EventArgs e)
        {
            ImagePlayerSelected = "souris";
            SetRandomPickForComupter();
            ComparePicks();
        }

        private void ImageButtonsPlayerChat_Click(object sender, System.EventArgs e)
        {
            ImagePlayerSelected = "chat";
            SetRandomPickForComupter();
            ComparePicks();
        }

        private void ImageButtonsPlayerElephant_Click(object sender, System.EventArgs e)
        {
            ImagePlayerSelected = "elephant";
            SetRandomPickForComupter();
            ComparePicks();
        }



        private void SetRandomPickForComupter()
        {
            Random rnd = new Random();
            int value = rnd.Next(0,3);

            switch (value)
            {
                case 0:
                    ImageComputerSelected = "souris";
                    break;
                case 1:
                    ImageComputerSelected = "chat";
                    break;
                case 2:
                    ImageComputerSelected = "elephant";
                    break;
                default:
                    break;
            }
        }

        private void ComparePicks()
        {
            ResultOfPlay = string.Empty;
            if (ImageComputerSelected == ImagePlayerSelected)
            {
                ResultOfPlay = "Égalité";
            }
            else if ((ImageComputerSelected == "souris" && ImagePlayerSelected == "chat") ||
                     (ImageComputerSelected == "chat" && ImagePlayerSelected == "elephant") ||
                     (ImageComputerSelected == "elephant" && ImagePlayerSelected == "souris"))
            {
                ScorePlayer.Text = Convert.ToString(Convert.ToInt32(ScorePlayer.Text) + 1);
                ResultOfPlay = "Gagné";
            }
            else if ((ImageComputerSelected == "souris" && ImagePlayerSelected == "elephant") ||
                     (ImageComputerSelected == "chat" && ImagePlayerSelected == "souris") ||
                     (ImageComputerSelected == "elephant" && ImagePlayerSelected == "chat"))
            {
                ScoreComputer.Text = Convert.ToString(Convert.ToInt32(ScoreComputer.Text) + 1);
                ResultOfPlay = "Perdu";
            }

            Intent result = new Intent(this, typeof(ResultActivity));
            result.PutExtra("resultat", ResultOfPlay);
            this.SetResult(Result.Ok, result);
            StartActivityForResult(result, 0);
            Console.WriteLine(ResultOfPlay);
        }
    }
}

