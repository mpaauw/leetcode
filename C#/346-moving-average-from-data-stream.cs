public class MovingAverage {

    private int totalSize, currentSize;
    List<int> structure;

    /** Initialize your data structure here. */
    public MovingAverage(int size) {
        this.totalSize = size;
        this.currentSize = 0;
        this.structure = new List<int>();
    }
    
    public double Next(int val) {
        this.currentSize += 1;
        structure.Add(val);
        if(structure.Count > this.currentSize) {
            structure.RemoveAt(0);
            this.currentSize -= 1;
        }
        double sum = 0.0;
        foreach(int item in structure) {
            sum += item;
        }
        return sum / currentSize;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */