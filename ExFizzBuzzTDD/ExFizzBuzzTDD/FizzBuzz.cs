namespace ExFizzBuzzTDD
{
    public class FizzBuzz : IRules
    {

        public string IsBuzz(int num)
        {
            if (num%5==0)
            {
                return "Buzz";
            }
            return string.Empty;
        }
        public string IsFizz(int num)
        {
            if (num%3==0)
            {
                return "Fizz";
            }
            return string.Empty;
        }

        public bool IsEmpty(string result)
        {
            if (result == string.Empty)
            {
                return true;
            }
            return false;
        }

        public string Apply(int num)
        {
            string result = string.Empty;
            result += IsFizz(num);
            result += IsBuzz(num);
            result += IsEmpty(result) ? num.ToString(): "";

            return result;
        }
    }
}
