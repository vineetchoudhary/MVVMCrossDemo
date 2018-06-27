using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CrossMVVM.Models
{
    public class Article
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public string AuthorName { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
