using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {

        public Result(bool success, string massage) : this(success)
        {
            Massage = massage;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Massage { get; }
    }
}
