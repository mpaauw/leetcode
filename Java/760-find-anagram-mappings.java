// Efficiency: O(n)
public int[] anagramMappings(int[] A, int[] B) {
    HashMap<Integer, Integer> map = new HashMap<>();
    int[] indexArr = new int[B.length]; 
    for(int i = 0; i < B.length; i++) { // O(n)
        map.put(B[i], i);
    }
    for(int i = 0; i < A.length; i++) { // O(n)
        indexArr[i] = map.get(A[i]);
    }
    return indexArr;
}