using System;
class Solution {
    public int solution(int[] A) {
        int length  = A.Length;
        int[] flags = new int[length]; //Flag array : 1/0 -> element found/not found
        
        //Initialize the flag array : All elements to 0 (Not yet found)
        for(int i=0; i<length; i++)
            flags[i]=0;
            
        for(int i=0; i<length; i++)
        {
            //If an element is > to N
            if(A[i]>length)
                return 0;
            //If an element is already found
            if(flags[A[i]-1] != 0)
                return 0;
            else
                flags[A[i]-1]=1;            
        }
        
        //If any element is missing
        if(Array.IndexOf(flags, 0)==-1)
            return 1;
        return 0;        
    }
}
