/*
 * 
 * Created By Vineet Choudhary
 * 
 */

namespace Common.RestClient
{
    public class ContentType
    {
        public const string ANY = "*/*";

        //Application
        public const string Application = "application/*";
        public const string JSON = "application/json";
        public const string Javascript = "application/javascript";
        public const string URLEncoded = "application/x-www-form-urlencoded";
        public const string XML = "application/xml";
        public const string ZIP = "application/zip";
        public const string PDF = "application/pdf";

        //Multipart
        public const string MultipartFormData = "multipart/form-data";
        public const string MultipartByteRanges = "multipart/byteranges";

        //Text
        public const string PlainText = "text/plain";
        public const string CSS = "text/css";
        public const string HTML = "text/html";
        public const string CSV = "text/csv";

        //Audio
        public const string Audio = "audio/*";
        public const string AudioMPEG = "audio/mpeg";
        public const string AudioWEBM = "audio/webm";
        public const string AudioOGG = "audio/ogg";
        public const string AudioWAV = "audio/wav";
        public const string AudioMIDI = "audio/midi";

        //Video 
        public const string Video = "video/*";
        public const string VideoWEBM = "video/webm";
        public const string VideoOGG = "video/ogg";

        //Images
        public const string PNG = "image/png";
        public const string JPEG = "image/jpeg";
        public const string GIF = "image/gif";
        public const string SVG = "image/svg+xml";
    }
}
