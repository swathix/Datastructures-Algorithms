t will find the one missing number for any size(array is sorted considering as my input)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace array
{
	class Class1
	{
   	public  static int  getNumber(int[] arr, int n)
    	{
       	int  sum=0;     	
        	for(int i=0; i<arr.Length; i++)
        	{
            	sum+=arr[i];
        	}
        	int actualsum = (n) * (n + 1) / 2;
        	int MissingNumber = actualsum - sum;
        	return MissingNumber;
	}
    	}
    	}






