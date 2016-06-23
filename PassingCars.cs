using System;
class Solution {
    public int solution(int[] A) {
        int increment 	= 0;
        int result 		= 0;
        int firstEast 	= Array.IndexOf(A, 0);
        
        if(firstEast == -1)
            return 0;
        
        for(int i=firstEast+1; i<A.Length; i++)
        {
            if(A[i]!=0)
			{
				result+=increment+1;
				if(result>1000000000)
					return -1;
			}                
            else
                increment++;
        }
		return result;
    }
}
