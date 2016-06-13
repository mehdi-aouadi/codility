using System;
class Solution {
    public int solution(int[] A) {
        int right   = 0;    //right elements sum
        int left    = A[0]; //left element sum : First element to start
        int result  = 0;    //min absolute difference
        
        //First step : Sum all the left element from A[1]
        for(int i=1; i<A.Length; i++)
            right+=A[i];
        //First difference    
        result = Math.Abs(left - right);
        
        //If A contains only two elements, the calculated difference in the only one -> return
        if(A.Length == 2)
            return result;
        //For each iteration, add the next element to the left sum, subtract it from the right sum
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
