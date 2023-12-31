public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> dict = new Dictionary<int, int>();  
    for(int i = 0; i < nums.Length; i++){
     int dif = target - nums[i]; 
    if(dict.ContainsKey(dif))
        return new int[]{dict[dif], i}; 
     if(!dict.ContainsKey(nums[i]))
        dict.Add(nums[i], i); 
    }
        return new int[0];
    }
}
