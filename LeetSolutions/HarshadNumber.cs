public class SolutionHarshad {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int copyOfX = x;
        int sum = 0;
        int lastDigit = 0;

        while(x > 0)
        {
        lastDigit = x % 10;
        sum = sum + lastDigit;
        x = x / 10;
        }

        if((copyOfX % sum) == 0){
            return sum;
        }
        else{
            return -1;
        }

    }
}