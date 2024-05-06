using System.Globalization;

public class SolutionMoney {
    public int TotalMoney(int n) {
        
        int[] money = new int[n];
        int count = 0;

        money[0] = count;
        for(int i = 0;i < money.Length; i++){
            count++;
            money[i] = count;
        }

        int sum = money.Sum();
        return sum;

    }
}