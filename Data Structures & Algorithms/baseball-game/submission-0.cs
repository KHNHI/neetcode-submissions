public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> score = new Stack<int>();
        foreach(var op in operations){
            if(op=="+"){
                int top = score.Pop();
                int newTop = top + score.Peek();
                score.Push(top);
                score.Push(newTop);
            }else if (op == "D"){
                score.Push(2 * score.Peek());
            }else if (op == "C"){
                score.Pop();
            }else{
                score.Push(int.Parse(op));
            }
        } 
        int total =0;
        foreach(var s in score){
            total +=s;
        }
        return total;
    }
}