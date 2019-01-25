using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailPriceCalculator
{
    public class ImageLocation
    {
        enum ImageLoc
        { US, CND, MEX, EURO};

        private string _imageName;

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

    }
}
