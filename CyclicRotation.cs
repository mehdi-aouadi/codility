using System;
class Solution {
  public int[] solution(int[] A, int K) {
	
	//Extreme cases : null / empty / only one element
  if(A == null || A.Length == 0 || A.Length ==1)
    return A;
		
  int 	  length 	= A.Length;
	int[] 	result 	= new int[length];
  int 	  shift	  = K % length;      		
      
	//No rotation
  if(shift == 0)
    return A;
		
  for(int i = 0; i < length; i++)
  {
    //If the shift exceeds the border
    if(i+shift >= length)
      result[shift - (length - i)] = A[i];
    else
      result[i+shift] = A[i];
  }        
  return result;
  }
}
