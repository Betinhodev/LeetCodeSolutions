public class SolutionHappy {
    public bool IsHappy(int n) {
        
        int copyOfN = n;
        int temp = 0;

        while(temp != 1)
        {
            int rem = n % 10;
            temp += rem * rem;
            n = n / 10;

            if(temp == 1)
            {
                break;
            }

            if(n == 0)
            {
                n += temp;
                temp -= n;
            }
            
        }

        if(temp == 1)
            return true;    
        else
            return false;
        
    }
}