namespace Assignment18_MultiThreading
{
    /// <summary>
    /// Multilayer oeprations
    /// </summary>
    public class MultiLayeredOperation
    {
        /// <summary>
        /// Executes the multi layered operation
        /// </summary>
        private long _result = 1;

        /// <summary>
        /// Executes the operation
        /// </summary>
        public void ExecuteMultiLayerAsyncAwait()
        {
            this.PrintOperation();
        }

        private string CPUBoundOperation()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    long multiplier = 1;
                    this._result = multiplier * this._result;
                    multiplier++;
                }
            });
            return "data?drilldowns=Nation&measures=Population";
        }

        private async Task<string> IOBoundOperations()
        {
            string specificUrl = this.CPUBoundOperation();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://datausa.io/api/");
            var response = await client.GetAsync(specificUrl);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        private async void PrintOperation()
        {
            string result = await this.IOBoundOperations();
            await Console.Out.WriteLineAsync(result);
        }
    }
}