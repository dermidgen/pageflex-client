using System;
using Pageflex.ServerClient;

public class PageflexClient {

	public static void Main() {
		Console.WriteLine("Init");

		Console.WriteLine("ServerHelpers connecting to Pageflex Server...");
		ServerHelpers helpers = new ServerHelpers("locahost", 8008);
		Console.WriteLine("Connected");

		Console.WriteLine("ServerHelpers fetching queue length...");
		int QueueLength = helpers.GetQueueLength("pfclient-test");
		Console.WriteLine("Queue Length:\t{0,8:c}", QueueLength);
	}

}