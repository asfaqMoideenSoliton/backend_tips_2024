namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Executes the functions of async and await 
    /// </summary>
    public class AsyncAwait
    {
        /// <summary>
        /// Executes the Async and Await
        /// </summary>
        public async void ExecuteAsyncAwait()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://datausa.io/api/");
            var response = await client.GetAsync("data?drilldowns=Nation&measures=Population");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            await Console.Out.WriteLineAsync(json);
        }
    }
}
