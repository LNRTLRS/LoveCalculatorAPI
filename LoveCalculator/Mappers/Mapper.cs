using LoveCalculator.Model;

namespace LoveCalculator.Mappers
{
    public class Mapper
    {
        public static LoveResult Map(int percentage, string comment)
        {
            LoveResult result = new LoveResult
            {
                MatchPercentage = percentage,
                MatchComment = comment
            };
            return result;
        }
    }
}
