using System;
class Solution {
    public int solution(int N) {
        int 	result 		= 0;					// Final result : Binary Gap Lenght
	int 	count 		= 0;					// Temporary binary gap count
        int 	index 		= 0;					// Iterations index
        int 	lastOccurence 	= 0;					// Index of the last occurence of 1
        char[] 	binary 		= Convert.ToString(N, 2).ToCharArray(); // Binary representation of N in char array

	// Retrieving the last position of 1 (No need to go further)
        lastOccurence 	= Array.LastIndexOf(binary, '1');
        
	// Exit if there is only one 1 OR if there is no zero
        if((lastOccurence == 0) || Array.IndexOf(binary, '0') == -1)
            return result;
			
        //Iterating while the last 1 is not hit
        while(index < lastOccurence)
        {
		index++;
			
		//If the following bit is 0, increment the counter
		if(binary[index] == '0')
                count++;
                
		//If the following bit is 1
		else
		{
			//Save the max binary gap lenght
			if(count > result)
				result = count;
			//Reset the binary gap counter
			count = 0;
		}
        }
        return result;        
    }
}
