    public class Codec
    {

        private const string placeholder = "tinyurl.com/";
        private const string leaderReg = "http://";
        private const string leaderSedc = "https://";
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        private const int urlTailLength = 6;

        private string storeUrlLong = "";
        private string storeUrlShort = "";

        private static Random random = new Random();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            this.storeUrlLong = longUrl;
            return this.compress(longUrl);
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return this.storeUrlLong;
        }

        private string compress(string word)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(leaderReg + placeholder + this.generateRandomString());
            this.storeUrlShort = builder.ToString();
            return this.storeUrlShort;
        }

        private string generateRandomString()
        {
            return new string(Enumerable.Repeat(chars, urlTailLength)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(url));