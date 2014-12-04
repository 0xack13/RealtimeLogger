using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


namespace RealtimeLogger.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendMessage(this StringBuilder sb, string text, Func<string, bool> predicate = null)
        {
            if (predicate != null)
            {
                if (predicate(text))
                {
                    sb.Append(" ");
                    sb.Append(text);
                }
            }
            else
            {
                sb.Append(" ");
                sb.Append(text);
            }

            return sb;
        }
    }
}