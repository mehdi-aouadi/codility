using System;
class Solution {
    public int solution(int[] A) {
        int right = 0;
        int left = A[0];
        int result = 0;
        for(int i=1; i<A.Length; i++)
        {
            right+=A[i];            
        }
        result = Math.Abs(left - right);
        if(A.Length == 2)
            return result;
        for(int i=1; i<A.Length-1; i++)
        {
            left+=A[i];
            right-=A[i];
            if(Math.Abs(left - right) < result)
                result = Math.Abs(left - right);
        }
        
        return result;
    }
}
