using System;
using Pageflex.ServerClient;

public class PageflexClient {

	public static void Main() {
		Console.WriteLine("Init");

		ServerHelpers helpers = new ServerHelpers('locahost', 8008);
		int QueueLength = helpers.GetQueueLength('pfclient-test');
		Console.WriteLine("Queue Length:\t{0,8:c}", QueueLength);
	}

}