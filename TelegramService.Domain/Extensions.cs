using sltlang.Common.TelegramService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramService.Domain
{
    public static class Extensions
    {
        public static string CreateString(this TelegramMessage message)
        {
            var sb = new StringBuilder();
            sb.Append(message.Message);

            if (message.Tags != null && message.Tags.Length > 0)
            {
                sb.AppendLine();
                sb.AppendLine();
                foreach (var tag in message.Tags)
                {
                    sb.AppendLine($"#{tag}");
                }
            }

            return sb.ToString();
        }
    }
}
