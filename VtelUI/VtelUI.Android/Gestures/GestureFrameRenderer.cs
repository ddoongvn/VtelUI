using System;
using Xamarin.Forms.Platform.Android;
using SimpleCustomGesureFrame;
using SimpleCustomGesureFrame.Android;
using Xamarin.Forms;
using Android.Views;
using Android.Content;

[assembly: ExportRenderer(typeof(GestureFrame), typeof(GestureFrameRenderer))]
namespace SimpleCustomGesureFrame.Android
{
	public class GestureFrameRenderer : ScrollViewRenderer
	{
		private readonly CustomGestureListener _listener;
		private readonly GestureDetector _detector;

		
		public GestureFrameRenderer(Context context) : base(context)

		{
			_listener = new CustomGestureListener();
			_detector = new GestureDetector(context, _listener);
		}

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.NewElement == null)
			{
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
				_listener.OnSwipeLeft -= HandleOnSwipeLeft;
				_listener.OnSwipeRight -= HandleOnSwipeRight;
			}

			if (e.OldElement == null)
			{
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
				_listener.OnSwipeLeft += HandleOnSwipeLeft;
				_listener.OnSwipeRight += HandleOnSwipeRight;
			}
		}

		void HandleTouch(object sender, TouchEventArgs e)
		{
			_detector.OnTouchEvent(e.Event);
		}

		void HandleGenericMotion(object sender, GenericMotionEventArgs e)
		{
			_detector.OnTouchEvent(e.Event);
		}

		void HandleOnSwipeLeft(object sender, EventArgs e)
		{
			GestureFrame _gi = (GestureFrame)this.Element;
			_gi.OnSwipeLeft();
		}

		void HandleOnSwipeRight(object sender, EventArgs e)
		{
			GestureFrame _gi = (GestureFrame)this.Element;
			_gi.OnSwipeRight();
		}

		//void HandleOnSwipeTop(object sender, EventArgs e)
		//{
		//	GestureFrame _gi = (GestureFrame)this.Element;
		//	_gi.OnSwipeTop();
		//}

		//void HandleOnSwipeDown(object sender, EventArgs e)
		//{
		//	GestureFrame _gi = (GestureFrame)this.Element;			
		//	_gi.OnSwipeDown();
		//}
		public override bool OnInterceptTouchEvent(MotionEvent ev)
		{
			return base.OnInterceptTouchEvent(ev);

		}
		public override bool OnTouchEvent(MotionEvent ev)
		{
			return base.OnTouchEvent(ev);
		}
	}
}