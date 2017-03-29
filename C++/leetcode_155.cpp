//LeetCode.com
//#155: Min Stack

class MinStack {
private:
    vector<int> _myVector;
    vector<int> _myMins;
public:
    void push(int x) {
        _myVector.push_back(x);        
    }

    void pop() {
        
        if(_myVector.size() > 0)
        {
            _myVector.pop_back();
        }
    }

    int top() {
        if(_myVector.size() > 0)
        {
            return _myVector.back();
        }
    }

    int getMin() {
        int min = 0;
        for(int i = 0; i < _myVector.size() - 1; i++)
        {
            if(_myVector[i] < min)
            {
                min = _myVector[i];
            }
        }
        return min;
    }
};