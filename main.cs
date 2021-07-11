// find the smallest duplicate number in an arry. c#
using System;
class HelloWorld {
  static void Main() {
    int[] allnums={4,3,5,6,1};
      
    if(smallestduplicate(allnums) != -1)
        //Console.WriteLine(smallestduplicate(allnums));
    else
        Console.WriteLine("no duplicate number");
  }
  
  static int smallestduplicate(int[] nums){
      int sd=-1;
      for(int i=0;i<nums.Length;i++){
          for(int j=0;j<nums.Length;j++){
              if(nums[i]==nums[j] && i<j && (sd > nums[i] || sd==-1))
              sd=nums[i];
          }
      }
      return sd;
  }
}
