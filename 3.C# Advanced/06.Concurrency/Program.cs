using _06.Concurrency._02.Synchronization;

namespace _06.Concurrency
{
    class Program
    {
        private const string ProcessConnectToDatabase = "(Connecting to database)";
        private const string ProcessGetDataFromDatabase = "(Getting data from database)";

        static void Main(string[] args)
        {
            //_01_Tasks.StartTask();

            //_02_WaitingForTasks.StartTasks();

            //_03_ReturningValueAndStatus.ReturnValueAndTaskStatus();

            //_04_CancelTask.CancelTask();

            //_05_TaskRun.RunTask();
            //_05_TaskRun.AddNumbersTask(10,5,2,1);

            //Console.WriteLine("First we are inside the main()");
            //_06_AsyncAndAwait.RunProcess(1,1_000_000);

            var dbTask = ConnectToDatabaseProcessAndGetData();
            Console.WriteLine("Back to the main()");
            if (dbTask.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine($"Process {ProcessConnectToDatabase} is completed.");
            }
            else
            {
                Console.WriteLine($"Process {ProcessConnectToDatabase} is not completed.");
            }

            //_06_AsyncAndAwait.RunProcess(2, 1_000_000);



            //_07_ConcurrentCollections.ConcurrentCollectionsOperations();



            //_01_Basic.StartThreads();

            //_02_ParameterizedThreadStart.StartThread();

            //_03_DeadlocksAndLockKeyword.StartReadAndWrite();

            //_04_Mutex.StartProcess();

            _05_Semaphore.StartProcess();


            // Multithreading example with synchronization
            ExampleMultithreadingWithSynchronization();

            Console.WriteLine();

            // Asynchronous programming example with more complex operations
            ExampleAsynchronousProgramming();

            Console.WriteLine("Main thread execution complete. Press any key to exit...");

            Console.ReadLine();
        }

        public static async Task ConnectToDatabaseProcessAndGetData()
        {
            Console.WriteLine($"Control is with process {ProcessConnectToDatabase}");
            Console.WriteLine($"Process {ProcessConnectToDatabase} has started.");
            Console.WriteLine($"Process {ProcessConnectToDatabase} is running...");

            await Task.Run(() =>
            {
                Console.WriteLine("Start executing process in await block");
                Thread.Sleep(10000);
                Console.WriteLine("Process in the await block is complete!");
            });
            Console.WriteLine($"Process {ProcessConnectToDatabase} is complete!");
            Console.WriteLine($"Control is with process {ProcessGetDataFromDatabase} again");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Getting data...");
            }
            Console.WriteLine($"Process {ProcessGetDataFromDatabase} is complete!");
        }

        static void ExampleMultithreadingWithSynchronization()
        {
            Console.WriteLine("Multithreading with Synchronization:");

            // Using ManualResetEvent to synchronize threads
            ManualResetEvent mre = new ManualResetEvent(false);

            // Thread 1: Simulate downloading
            Thread thread1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1: Download started.");
                Thread.Sleep(2000); // Simulate download operation
                Console.WriteLine("Thread 1: Download completed.");
                mre.Set(); // Signal that download is complete
            });
            thread1.Start();

            // Thread 2: Simulate processing after download
            Thread thread2 = new Thread(() =>
            {
                Console.WriteLine("Thread 2: Waiting for download to complete.");
                mre.WaitOne(); // Wait until download is complete
                Console.WriteLine("Thread 2: Processing downloaded data.");
                Thread.Sleep(3000); // Simulate processing operation
                Console.WriteLine("Thread 2: Processing completed.");
            });
            thread2.Start();

            // Wait for threads to complete
            thread1.Join();
            thread2.Join();
        }



        static async void ExampleAsynchronousProgramming()
        {
            Console.WriteLine("Asynchronous Programming:");

            // Task 1: Simulate data retrieval from web API
            Task<string> task1 = GetDataAsync("https://jsonplaceholder.typicode.com/posts/1");
            Console.WriteLine("Task 1: Started.");

            // Task 2: Simulate data processing after retrieval
            string data = await task1;
            Task<int> task2 = ProcessDataAsync(data);
            Console.WriteLine("Task 2: Started.");

            // Task 3: Simulate saving processed data to database
            int processedResult = await task2;
            await SaveDataAsync(processedResult);
            Console.WriteLine("Task 3: Started.");
        }



        static async Task<string> GetDataAsync(string url)
        {
            // Simulate async operation to retrieve data from web API
            await Task.Delay(3000); // Simulate delay
            Console.WriteLine("Task 1: Data retrieval completed.");
            return "Sample data";
        }



        static async Task<int> ProcessDataAsync(string data)
        {
            // Simulate async operation to process data
            await Task.Delay(4000); // Simulate delay
            Console.WriteLine("Task 2: Data processing completed.");
            return data.Length;
        }



        static async Task SaveDataAsync(int result)
        {
            // Simulate async operation to save data to database
            await Task.Delay(2000); // Simulate delay
            Console.WriteLine($"Task 3: Data saved to database. Processed result: {result}");
        }
    }
}
