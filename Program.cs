// See https://aka.ms/new-console-template for more information



void ParseWaxFile (string waxFilePath) {
	Console.WriteLine($"Filepath: {waxFilePath}");
}

if (args.Length > 0) {
	ParseWaxFile(args[0]);
} else {
	Console.WriteLine("Usage:\n\twax hello.wax\n");
}
