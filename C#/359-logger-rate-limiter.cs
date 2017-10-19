public class Logger {

    private Dictionary<string, int> memory;

    /** Initialize your data structure here. */
    public Logger() {
        this.memory = new Dictionary<string, int>();
    }
    
    /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
        If this method returns false, the message will not be printed.
        The timestamp is in seconds granularity. */
    public bool ShouldPrintMessage(int timestamp, string message) {
        if(message == null) { // edge case
            return false;
        }
        if(this.memory.ContainsKey(message)) {
            if(timestamp - this.memory[message] >= 10) { // if enough time has elapsed, replace old timestamp and authorize a print
                this.memory[message] = timestamp; // replace existing timestamp with new one
                return true;
            }
            else { // not enough time has elapsed, do not authorize print
                return false;
            }
        }
        else { // message has not yet been seen, authorize a print and add to memory
            this.memory.Add(message, timestamp);
            return true;
        }
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */