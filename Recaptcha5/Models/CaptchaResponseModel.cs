namespace Recaptcha5.Models
{
    public class CaptchaResponseModel
    {
        public string Token { get; set; }
        public byte[] Image { get; set; }
    }
}
