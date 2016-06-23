using System;
class Solution {
    public int[] solution(int N, int[] A) {
        int 	lengt		= A.Length;	//Retrieve A Length once
        int 	max		= 0;		//Actual maximum value
        int 	lastIncrement 	= 0;		//Last incremented value
        int[] 	result		= new int[N];	//The result array
	
	//Initializing the result array : All elements to 0
        for(int i=0; i<N; i++)
            result[i]=0;
        
        for(int i=0; i<length; i++)
        {
        	//Max counter operation : Save the max value
        	if(A[i] == N+1)
			max = lastIncrement;
                //Increase one counter
		if(A[i]<=N)
		{        
			//If a max counter operation has been performed : The counter took tha max value + increase operation
			if(result[A[i]-1]<max)
				result[A[i]-1]=max+1;
			else
				result[A[i]-1]++;
			//Save the last incremented value
			if(result[A[i]-1] > lastIncrement)
				lastIncrement = result[A[i]-1];		 
		}   
        }
	
	//Set all the non increased elements to the last max value when a max counter operation has been performed
        for(int i=0; i<N; i++)
		result[i] = result[i]<max?max:result[i];
				
        return result;
    }
}
