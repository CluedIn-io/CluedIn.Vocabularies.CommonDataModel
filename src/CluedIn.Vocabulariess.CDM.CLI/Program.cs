using CommandLine;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CluedIn.Vocabulariess.CDM.CLI
{
    internal class Program
    {
        public static async Task<int> Main(string[] args)
        {
            args = new[] { "read-manifest" };

            var result = Parser.Default.ParseArguments<ReadManifestOption>(args);

            result = await result.WithParsedAsync(ReadManifest.Run);
            result.WithNotParsed(HandleParseError);

            return 0;
        }

        private static void HandleParseError(IEnumerable<Error> errors)
        {
            foreach (var error in errors)
                Console.WriteLine($"[CDM.CLI] Error parsing console parameters, {error}");
        }
    }
}
