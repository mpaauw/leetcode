/**
Efficiency: O(n)
 */
public int numJewelsInStones(String J, String S) {
    int jewelCount = 0;
    HashSet<Character> jewels = new HashSet<>();
    for(Character jewel : J.toCharArray()) { 
        jewels.add(jewel);
    }

    for(Character stone : S.toCharArray()) { 
        if(jewels.contains(stone)) {
            jewelCount++;
        }
    }
    return jewelCount;
}