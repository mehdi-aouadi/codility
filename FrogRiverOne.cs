using System;

class Solution {
    public int solution(int X, int[] A) {
		int[] leaves = new int[X];	//Fallen leaves positions
		
		//Initializing the leaves positions array
        for(int i=0; i<X; i++)
			leaves[i] = 0;
			
        for(int i=0; i<A.Length; i++)
        {
			//Memorize the leaves fallen befin the opposite river bank
            if(A[i]<=X)
                leaves[A[i]-1]=A[i];	//Memorize the fallen leaf
            
			//If the number (i) of fallen leaves is inferiror to the distance (X) no need to check
			//If there is no more 0 values in the leaves memory array
			if(i >= X-1 && Array.IndexOf(leaves, 0 ) == -1)
				return i;
        }        
        return -1;
	}
}
