using SocialSlider.Core.Interfaces;

namespace SocialSlider.Core.Servants
{
    public class ImageServant : IImageServant
    {

        private readonly IInstagramServant InstagramServant;

        public ImageServant()
        { }

        public ImageServant(IInstagramServant instragramServant)
        {
            InstagramServant = instragramServant;
        }


    }
}
