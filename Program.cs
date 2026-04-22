namespace cs_working_with_apis
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            FakerBookResponse? res = await FakerBooks.GetBooksAsync(2);
            if (res != null)
            {
                Console.WriteLine(res.Data[0].Id);
            }
        }
    }
}
