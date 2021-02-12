using Portfolio.ViewModels;
using System.Collections.Generic;

namespace Portfolio.Pages.Contents.Works
{
    public partial class EWS
    {
        // Image Slider
        IList<ImageSliderVM> items = new List<ImageSliderVM>
        {
            new ImageSliderVM
            {
                Alt="EWS",
                Caption = "Early Warning System App",
                Header="EWS",
                Source = "/images/works/EWS.JPG"
            }
        };
    }
}
