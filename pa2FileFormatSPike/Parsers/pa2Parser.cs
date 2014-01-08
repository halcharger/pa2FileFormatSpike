using System;
using System.Collections.Generic;

namespace pa2FileFormatSPike.Parsers
{
    interface Pa2Parser
    {
        Pa2Record ParseRecord(string record, int lineNumber);
    }

    abstract class Pa2Parser<T> : Pa2Parser where T : Pa2Record, new()
    {
        protected readonly List<FieldDefinition<T>> fieldDefinitions = new List<FieldDefinition<T>>();

        public Pa2Parser()
        {
            ConfigureFieldDefinitions();
        }

        protected abstract void ConfigureFieldDefinitions();

        public virtual Pa2Record ParseRecord(string record, int lineNumber)
        {
            var r = new T { LineNumber = lineNumber };

            foreach (var fieldDefinition in fieldDefinitions)
            {
                fieldDefinition.SetPropertyValue(r, record.Substring(fieldDefinition.Start, fieldDefinition.Length));
            }

            return r;
        }
    }

    struct FieldDefinition<T> where T : Pa2Record
    {
        public FieldDefinition(int start, int length, Action<T, string> setPropVal)
        {
            Start = start;
            Length = length;
            SetPropertyValue = setPropVal;
        }

        public int Start;
        public int Length;
        public Action<T, string> SetPropertyValue;
    }
}
