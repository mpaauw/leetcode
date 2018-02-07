public class Codec {

    private HashMap<String, String> map; // shortUrl, longUrl
    private final String PLACEHOLDER = "http://tinyurl.com/";
    private final Integer SHORT_URL_LENGTH = 6;

    public Codec() {
        this.map = new HashMap<>();
    }

    // Encodes a URL to a shortened URL.
    public String encode(String longUrl) {
        StringBuilder shortUrlBuilder = new StringBuilder();
        shortUrlBuilder.append(PLACEHOLDER);
        Random rand = new Random();
        boolean getNum = false;
        while(shortUrlBuilder.length() < SHORT_URL_LENGTH) {
            int num = rand.nextInt(Integer.MAX_VALUE);
            if(num < 0) {
                num *= -1;
            }
            if(getNum) {
                shortUrlBuilder.append(num);
            } else {
                char c = (char)num;
                shortUrlBuilder.append(c);
            }
        }
        String shortUrl = shortUrlBuilder.toString();
        map.put(shortUrl, longUrl);
        return shortUrl;
    }

    // Decodes a shortened URL to its original URL.
    public String decode(String shortUrl) {
        return this.map.get(shortUrl);
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));