using SocialSlider.Interfaces;

namespace SocialSlider.Servants
{
    public class ImageServant : IImageServant
    {
        private readonly IInstagramServant InstagramServant;

        public ImageServant() { }

        public ImageServant(IInstagramServant instragramServant)
        {
            InstagramServant = instragramServant;
        }
    }
}
