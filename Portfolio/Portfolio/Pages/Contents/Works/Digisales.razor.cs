using Portfolio.ViewModels;
using System.Collections.Generic;

namespace Portfolio.Pages.Contents.Works
{
    public partial class Digisales
    {
        // Image Slider
        IList<ImageSliderVM> items = new List<ImageSliderVM>
        {
            new ImageSliderVM
            {
                Alt="Digisales",
                Caption = "Digisales",
                Header="Digisales",
                Source = "/images/works/digisales.JPG"
            },
            new ImageSliderVM
            {
                Alt="Digisales1",
                Caption = "Digisales 1",
                Header="Digisales 1",
                Source = "/images/works/DIGISALES1.JPG"
            },
            new ImageSliderVM
            {
                Alt="Digisales2",
                Caption = "Digisales 2",
                Header="Digisales 2",
                Source = "/images/works/DIGISALESMB.JPG"
            }
        };
    }
}
