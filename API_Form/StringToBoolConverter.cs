using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_Form
{
    internal class StringToBoolConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var str = reader.GetString();
                if(str == "true" || str == "1" || str.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if(str == "false" || str == "0" || str.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetBoolean();
            }

            // Throw an exception for unsupported token types or invalid input
            throw new JsonException($"Unexpected token {reader.TokenType} or invalid value when parsing boolean.");
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value);
        }
    }
}
