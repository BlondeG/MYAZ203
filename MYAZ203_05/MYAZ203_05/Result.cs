public class Result
{
    public bool Status { get; set; }
    public string Message { get; set; }

    public Result()
    {

    }

    public Result(bool status, string message)
    {
        Status = status;
        Message = message;
    }

}
