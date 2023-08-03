// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
public class Asteriod
{
    public int [] AuteriodCollision(int [] auteriods)
    {
        List<int> listofauteriods = new List<int>();

        for (int i = 0; i < listofauteriods.Count; i++)
        {

            for (int j = 0; j < listofauteriods.Count; j++)
            {
                if (i==j)
                {
                    return auteriods;
                }
                else if (auteriods[i] == 1)
                {

                }
            }

           
        }
        return auteriods;
    }
}

//class Solution
//{
//    public int[] asteroidCollision(int[] asteroids)
//    {
//        Stack<Integer> stack = new Stack();
//        for (int ast: asteroids)
//        {
//        collision:
//            {
//                while (!stack.isEmpty() && ast < 0 && 0 < stack.peek())
//                {
//
//                   peek =remove from the top of stack
//
//
//                   if (stack.peek() < -ast)
//                    
                            // pop = to remove
//                        stack.pop();
//                        continue;
//                    }

//                    else if (stack.peek() == -ast)
//                    {
//                        stack.pop();
//                    }
//                    break collision;
//                }
                       // push = To add to stack

//                stack.push(ast);
//            }
//        }

//        int[] ans = new int[stack.size()];
//        for (int t = ans.length - 1; t >= 0; --t)
//        {
//            ans[t] = stack.pop();
//        }
//        return ans;
//    }
