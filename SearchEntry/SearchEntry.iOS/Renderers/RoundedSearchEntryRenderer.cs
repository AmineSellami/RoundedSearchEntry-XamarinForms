using CoreGraphics;
using SearchEntry.Controls;
using SearchEntry.iOS.Renderers;
using System.Drawing;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(RoundedSearchEntry), typeof(RoundedSearchEntryRenderer))]
namespace SearchEntry.iOS.Renderers
{
    public class RoundedSearchEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || e.NewElement == null)
                return;

            var element = (RoundedSearchEntry)Element;
            Control.Layer.CornerRadius = element.BorderRadius;
            Control.Layer.BorderWidth = element.BorderWidth;
            Control.Layer.BorderColor = element.BorderColor.ToCGColor();
            Control.Layer.BackgroundColor = element.Color.ToCGColor();

            Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
            Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;

            //Image Part

            if (!string.IsNullOrEmpty(element.Image))
            {
                switch (element.ImageAlignment)
                {
                    case ImageAlignment.Left:
                        Control.LeftViewMode = UITextFieldViewMode.Always;
                        Control.LeftView = GetImageView(element.Image, element.ImageHeight, element.ImageWidth);
                        break;
                    case ImageAlignment.Right:
                        Control.RightViewMode = UITextFieldViewMode.Always;
                        Control.RightView = GetImageView(element.Image, element.ImageHeight, element.ImageWidth);
                        break;
                }
            }

            Control.BorderStyle = UITextBorderStyle.None;
        }

        private UIView GetImageView(string imagePath, int height, int width)
        {
            var uiImageView = new UIImageView(UIImage.FromBundle(imagePath))
            {
                Frame = new RectangleF(0, 0, width, height)
            };
            UIView objLeftView = new UIView(new System.Drawing.Rectangle(0, 0, width + 10, height));
            objLeftView.AddSubview(uiImageView);

            return objLeftView;
        }
    }
}