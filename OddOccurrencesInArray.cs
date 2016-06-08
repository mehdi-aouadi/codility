using System;
class Solution {
	public int solution(int[] A) {
	int result = 0;
		
	// Using the XOR operator, each pair of duplicated elements will be canceled : A XOR A = 0 and B XOR 0 = B
	for(int i=0; i<A.Length; i++)
		result ^= A[i];
		
	return result;
	}
}
