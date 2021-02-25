using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages.Contents.Works
{
    public partial class CSMT
    {
        // Image Slider
        IList<ImageSliderVM> items = new List<ImageSliderVM>
        {
            new ImageSliderVM
            {
                Alt="CSMT",
                Caption = "Corporate Strategy Monitoring Tools",
                Header="CSMT",
                Source = "/images/works/CSMT.JPG"
            }
        };
    }
}
