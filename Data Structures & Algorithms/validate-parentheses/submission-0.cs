public class Solution {
    public bool IsValid(string s) {
        Stack <char> charStack = new Stack<char>();
        Dictionary<char,char> closeToOpen = new Dictionary<char,char>{
            {'}','{'}, 
            {')','('},
            {']','['}
        };
        foreach(char c in s){
            if(closeToOpen.ContainsKey(c)){
                if(charStack.Count > 0 && charStack.Peek()==closeToOpen[c] ){
                   charStack.Pop();
                }else{
                    return false;
                }
            }else{
                charStack.Push(c);
            }
        }
        return charStack.Count ==0;
    }
}
