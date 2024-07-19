using System.IO;



void ParseWaxFile (string waxFilePath) {
	if (!File.Exists(waxFilePath)) {
		Console.WriteLine($"Not found: {waxFilePath}");
		return;
	}

	Console.WriteLine($"Found: {waxFilePath}");
}

if (args.Length > 0) {
	ParseWaxFile(args[0]);
} else {
	Console.WriteLine("Usage:\n\twax hello.wax\n");
}
