using System;
class Solution {
    public int solution(int N) {
        int result = 0;
		int res = 0;
        int firstOccurence = 0;
        int lastOccurence = 0;
        char[] binary = Convert.ToString(N, 2).ToCharArray();
        
        firstOccurence = Array.IndexOf(binary, '1');
        lastOccurence = Array.LastIndexOf(binary, '1');
        
        if((firstOccurence == lastOccurence) || (firstOccurence == lastOccurence-1) || Array.IndexOf(binary, '0') == -1)
            return result;
        
        while(firstOccurence < lastOccurence)
        {
			firstOccurence++;
            if(binary[firstOccurence] == '0')
                res++;
            else
			{		    
				if(res > result)
					result = res;
				res = 0;
			}
        }
        return result;        
    }
}
