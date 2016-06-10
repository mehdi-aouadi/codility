using System;
class Solution {
    public int solution(int X, int Y, int D) {
		int distance = X-Y;
        return distance%D != 0 ? distance/D+1 : distance/D;        
    }
}
