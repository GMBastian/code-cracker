public class Solution {
    public string GetSmallestString(string s) {
        char[] c=s.ToCharArray();
        for(int i=0;i<c.Length-1;i++){
            if((c[i]-c[i+1])%2==0){
            if(c[i]-'0'>c[i+1]-'0'){
               
                char ch=c[i];
                c[i]=c[i+1];
                c[i+1]=ch;
                return new String(c);
            } 
            }

        }
        
        return s;
        
    }
}
