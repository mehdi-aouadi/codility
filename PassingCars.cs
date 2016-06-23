using System;
class Solution {
    public int solution(int[] A) {
        int increment	= 0;			//Cars going to the east counter
        int result	= 0;			//Number of pairs
        int firstEast 	= Array.IndexOf(A, 0);	//The first car going to the east
        
        //If there is no cars going to the east
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
