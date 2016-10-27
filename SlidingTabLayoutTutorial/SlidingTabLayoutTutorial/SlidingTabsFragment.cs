using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Java.Lang;
using System.Threading.Tasks;
using System.IO;
using Java.Util;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View;

namespace SlidingTabLayoutTutorial
{
    public class SlidingTabsFragment : Fragment
    {
        private SlidingTabScrollView mSlidingTabScrollView;
        private ViewPager mViewPager;
        private EditText editText;
        private Button speak;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_sample, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            mSlidingTabScrollView = view.FindViewById<SlidingTabScrollView>(Resource.Id.sliding_tabs);
            mViewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);
            editText = view.FindViewById<EditText>(Resource.Id.editText);
            speak = view.FindViewById<Button>(Resource.Id.speak);
            mViewPager.Adapter = new SamplePagerAdapter();

            mSlidingTabScrollView.ViewPager = mViewPager;
        }

        public class SamplePagerAdapter : PagerAdapter
        {
            List<string> items = new List<string>();

            public SamplePagerAdapter() : base()
            {
                items.Add("Phrases");
                items.Add("Words");
                items.Add("More Words");
                items.Add("Practice");
                items.Add("Customize");
            }

            public override int Count
            {
                get { return items.Count; }
            }

            public override bool IsViewFromObject(View view, Java.Lang.Object obj)
            {
                return view == obj;
            }

            public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
            {
                int pos = position + 1;

                View view = LayoutInflater.From(container.Context).Inflate(Resource.Layout.phrases, container, false);
                

                //TextView txtTitle = view.FindViewById<TextView>(Resource.Id.item_title);
                //txtTitle.Text = pos.ToString();

                EditText editText = view.FindViewById<EditText>(Resource.Id.editText);
                Button helloMyNameIs = view.FindViewById<Button>(Resource.Id.helloMyNameIs);
                Button ralph = view.FindViewById<Button>(Resource.Id.ralph);
                Button speak = view.FindViewById<Button>(Resource.Id.speak);
                Button tired = view.FindViewById<Button>(Resource.Id.tired);
                Button goodbye = view.FindViewById<Button>(Resource.Id.goodbye);
                Button Hello = view.FindViewById<Button>(Resource.Id.niceToMeetYou);
                Button thankyou = view.FindViewById<Button>(Resource.Id.thankYou);
                Button thirsty = view.FindViewById<Button>(Resource.Id.thirsty);
                Button hungry = view.FindViewById<Button>(Resource.Id.hungry);
                Button potty = view.FindViewById<Button>(Resource.Id.potty);
                Button run = view.FindViewById<Button>(Resource.Id.runAway);
                Button love = view.FindViewById<Button>(Resource.Id.iLoveYou);
                Button play = view.FindViewById<Button>(Resource.Id.wantToPlay);

                container.AddView(view);

                //return view;

                if (pos == 1)
                { }

                if (pos == 2)
                {
                    view = LayoutInflater.From(container.Context).Inflate(Resource.Layout.words, container, false);

                    //var editText = view.FindViewById<EditText>(Resource.Id.editText);
                    var I = view.FindViewById<Button>(Resource.Id.I);
                    var you = view.FindViewById<Button>(Resource.Id.you);
                    var they = view.FindViewById<Button>(Resource.Id.they);
                    var feel = view.FindViewById<Button>(Resource.Id.feel);
                    var happy = view.FindViewById<Button>(Resource.Id.happy);
                    var angry = view.FindViewById<Button>(Resource.Id.angry);
                    var come = view.FindViewById<Button>(Resource.Id.come);
                    var give = view.FindViewById<Button>(Resource.Id.give);
                    var go = view.FindViewById<Button>(Resource.Id.go);
                   // var speak = view.FindViewById<Button>(Resource.Id.speak);
                    var please = view.FindViewById<Button>(Resource.Id.please);
                    var help = view.FindViewById<Button>(Resource.Id.help);
                    var home = view.FindViewById<Button>(Resource.Id.home);

                    container.AddView(view);



                    


                }
                return view;
            }

            public string GetHeaderTitle (int position)
            {
                return items[position];
            }

            public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object obj)
            {
                container.RemoveView((View)obj);
            }
        }
    }
}