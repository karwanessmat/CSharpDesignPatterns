namespace Proxy7Demo
{
    public class Image4KProxy : IImage
    {
        private  Image4k Image;
        public Image4KProxy(string filePath)
        {
            FileName = Path.GetFileName(filePath);
        }
        public string FileName { get; }
        public void ShowImage()
        {
            if (Image is null)
            {
                Image = new Image4k(FileName);
            }
            Image.ShowImage();
        }
    }
}
