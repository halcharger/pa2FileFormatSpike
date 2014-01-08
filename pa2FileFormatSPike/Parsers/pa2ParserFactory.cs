using System.Collections.Generic;
using System.Linq;

namespace pa2FileFormatSPike.Parsers
{
    class Pa2ParserFactory
    {
        private Dictionary<string, Pa2Parser> parserDictionary;

        public Pa2ParserFactory()
        {
            parserDictionary = new Dictionary<string, Pa2Parser>
            {
                {"0", new Type0Parser()}
            };
        }

        public Pa2Parser GetParser(string line)
        {
            var firstCharOfLine = line.First().ToString();
            if (parserDictionary.ContainsKey(firstCharOfLine))
                return parserDictionary[firstCharOfLine];

            return null;
        }
    }
}
