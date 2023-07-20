public class Solution {
    //Time Complexity O(n)
    public IList<string> FizzBuzz(int n) {
        string[] answer = new string[n];

        for(int i = 1; i <= n; i++)
        {
            bool divisibleBy3 = i % 3 == 0;
            bool divisibleBy5 = i % 5 == 0;
            
            if(divisibleBy3 && divisibleBy5){
                answer[i-1] = "FizzBuzz";
            }
                else if(divisibleBy3){
                    answer[i-1] = "Fizz";
                }
                else if(divisibleBy5){
                    answer[i-1] = "Buzz";
                    }
                    else{
                        answer[i-1] = i.ToString();
                    }
            }
            return answer;
        }
    }
