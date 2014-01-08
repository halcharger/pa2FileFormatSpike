using System.Collections.Generic;
using System.IO;
using pa2FileFormatSPike.Parsers;

namespace pa2FileFormatSPike
{
    class Pa2FileParser
    {
        readonly Pa2ParserFactory parsers = new Pa2ParserFactory();

        public IEnumerable<Pa2Record> Parse(string file)
        {
            var lines = File.ReadAllLines(file);
            var records = new List<Pa2Record>();
            var lineNumber = 0;

            foreach (var line in lines)
            {
                var parser = parsers.GetParser(line);

                lineNumber++;

                if (parser != null) 
                    records.Add(parser.ParseRecord(line, lineNumber));
            }

            return records;
        }
    }
}
