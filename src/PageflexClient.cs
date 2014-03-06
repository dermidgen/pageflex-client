using System;
using Pageflex.ServerClient;

public class PageflexClient {

	public static void Main() {
		Console.WriteLine("Init");

		Console.WriteLine("ServerHelpers connecting to Pageflex Server...");
		ServerHelpers helpers = new ServerHelpers("10.0.0.110", 8008);
		Console.WriteLine("Connected");

		Console.WriteLine("ServerHelpers fetching queue length...");
		int QueueLength = helpers.GetQueueLength("pfclient-test");
		Console.WriteLine("Queue Length:\t{0}", QueueLength);
	}
}