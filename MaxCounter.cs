using System;
class Solution {
    public int[] solution(int N, int[] A) {
        int 	length 			= A.Length;
        int 	max 			= 0;
        int 	lastIncrement 	= 0;
        int[] 	result 			= new int[N];
		
        for(int i=0; i<N; i++)
            result[i]=0;
        
        for(int i=0; i<length; i++)
        {			
            if(A[i] == N+1)
                max = lastIncrement;
                
            if(A[i]<=N)
            {               
				if(result[A[i]-1]<max)
					result[A[i]-1]=max+1;
				else
					result[A[i]-1]++;
				
				if(result[A[i]-1] > lastIncrement)
				    lastIncrement = result[A[i]-1];		 
            }   
        }
			
        for(int i=0; i<N; i++)
		    result[i] = result[i]<max?max:result[i];
				
        return result;
    }
}
