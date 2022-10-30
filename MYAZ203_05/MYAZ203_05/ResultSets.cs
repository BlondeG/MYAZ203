public static class ResultSets
{
    public static Result Action01()
    {
        return new Successed();
    }

    public static Result Action02()
    {
        return new Successed("Islem basarılı tamamlandı!");
    }

    public static Result Action03()
    {
        return new Failed();
    }

    public static Result Action04()
    {
        return new Failed("Islem basarısız tamamlandı!");
    }

}
