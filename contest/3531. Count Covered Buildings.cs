public class Solution {
       public int CountCoveredBuildings(int n, int[][] buildings)
       {
           Array.Sort(buildings, (a, b) =>
           {
               if (a[0] != b[0]) return a[0].CompareTo(b[0]);//先比X
               else return a[1].CompareTo(b[1]);
           });

           int curX = buildings[0][0];
           int min = int.MaxValue;
           int max = int.MinValue;
           //x map
           Dictionary<int, int[]> xPole = new Dictionary<int, int[]>();
           
           for(int i = 0; i < buildings.Length; i++)
           {
               int x = buildings[i][0];
               int y = buildings[i][1];

               //不一樣就加入dictionary 結束這一回合 找下一個x
               if (x != curX)
               {
                   xPole.Add(curX, new int[] { min, max });
                   curX = x;
                   min = int.MaxValue;
                   max = int.MinValue;
               } 
                   min = Math.Min(min, y);
                   max = Math.Max(max, y);
           }

           //以Y排序
           Array.Sort(buildings, (a, b) =>
           {
               if (a[1] != b[1]) return a[1].CompareTo(b[1]);//先比X
               else return a[0].CompareTo(b[0]);
           });

           int curY = buildings[0][1];
           min = int.MaxValue;
           max = int.MinValue;
           //y map
           Dictionary<int, int[]> yPole = new Dictionary<int, int[]>();


           for (int i = 0; i < buildings.Length; i++)
           {
               int x = buildings[i][0];
               int y = buildings[i][1];

               //不一樣就加入dictionary 結束這一回合 找下一個x
               if (y != curY)
               {
                   yPole.Add(curY, new int[] { min, max });
                   curY = y;
                   min = int.MaxValue;
                   max = int.MinValue;
               }
               min = Math.Min(min, x);
               max = Math.Max(max, x);
           }

           int res = 0;
           foreach(var coordinate in buildings)
           {
               int x = coordinate[0];
               int y = coordinate[1];
               bool xInMiddle = false;
               bool yInMiddle = false;

               //如果X有在端點中間 && Y有在端點中間 就是有被包覆

               if (xPole.TryGetValue(x, out int[] range))
               {
                   if (range[1] > y && y > range[0]) yInMiddle = true;
               }

               if (yPole.TryGetValue(y, out int[] range2))
               {
                   if (range2[1] > x && x > range2[0]) xInMiddle = true;
               }

               if (xInMiddle && yInMiddle) res++;

           }

           return res;
       }
}
