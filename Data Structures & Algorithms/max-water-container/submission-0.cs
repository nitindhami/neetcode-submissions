public class Solution {
    public int MaxArea(int[] heights) 
    {
           int i =0;
           int j=heights.Length-1;
           int area =0;
           int areaMax =0; 
           while(i<j)
           {
            area = (j-i) * Math.Min(heights[i],heights[j]); 
            areaMax = Math.Max(areaMax,area);

            if (heights[i] < heights[j])
            {
                i++;
            }
            else
            {
                j--;
            }

           }
           return areaMax;
    }
}
