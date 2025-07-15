public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var sumDict = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            var complement = target - nums[i];
            if(sumDict.ContainsKey(complement))
            {
                return [i, sumDict[complement]];
            }
            sumDict[nums[i]] = i;
        }
        return [];
    }
}
