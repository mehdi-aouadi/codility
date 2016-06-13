using System;
class Solution {
    public int solution(int[] A) {
		int result 	= 0;	//The missing element
		int sum 	= 0;	//Sum of 1 to N
		
		for(int i=0; i<A.Length; i++)
		{
			result+=i+1;
			sum+=A[i];
		} 
		
		//The result is the difference between the Sum of 1...N+1 (Adding the last element A.Length+1) and the Sum of all the elements in A
		return result+A.Length+1-sum;
    }
}
