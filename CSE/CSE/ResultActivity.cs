using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;


namespace CSE
{
    [Activity(Label = "ResultActivity")]
    public class ResultActivity : Activity
    {
        private Button btn;
        private TextView resultat;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultView);

            btn = FindViewById<Button>(Resource.Id.BtnOk);
            resultat = FindViewById<TextView>(Resource.Id.txtResult);

            resultat.Text = Intent.GetStringExtra("resultat");

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}