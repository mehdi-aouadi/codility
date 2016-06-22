using System;
class Solution {
    public int solution(int[] A) {
        int length  = A.Length;
        int[] res   = new int[length];
        
        for(int i=0; i<length; i++)
            res[i]=0;
            
        for(int i=0; i<length; i++)
        {
            if(A[i]>length)
                return 0;
            if(res[A[i]-1] != 0)
                return 0;
            else
                res[A[i]-1]=1;            
        }
        
        if(Array.IndexOf(res, 0)==-1)
            return 1;
        return 0;        
    }
}
