using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WikiIntegrator.Providers.Wikipedia.Models
{
    public class WikipediaContent
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("displaytitle", NullValueHandling = NullValueHandling.Ignore)]
        public string Displaytitle { get; set; }

        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public Namespace Namespace { get; set; }

        [JsonProperty("wikibase_item", NullValueHandling = NullValueHandling.Ignore)]
        public string WikibaseItem { get; set; }

        [JsonProperty("titles", NullValueHandling = NullValueHandling.Ignore)]
        public Titles Titles { get; set; }

        [JsonProperty("pageid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pageid { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Originalimage Thumbnail { get; set; }

        [JsonProperty("originalimage", NullValueHandling = NullValueHandling.Ignore)]
        public Originalimage Originalimage { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }

        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public string Dir { get; set; }

        [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
        public long? Revision { get; set; }

        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Tid { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("content_urls", NullValueHandling = NullValueHandling.Ignore)]
        public ContentUrls ContentUrls { get; set; }

        [JsonProperty("api_urls", NullValueHandling = NullValueHandling.Ignore)]
        public ApiUrls ApiUrls { get; set; }

        [JsonProperty("extract", NullValueHandling = NullValueHandling.Ignore)]
        public string Extract { get; set; }

        [JsonProperty("extract_html", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtractHtml { get; set; }
    }

    public partial class ApiUrls
    {
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Summary { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Metadata { get; set; }

        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public Uri References { get; set; }

        [JsonProperty("media", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Media { get; set; }

        [JsonProperty("edit_html", NullValueHandling = NullValueHandling.Ignore)]
        public Uri EditHtml { get; set; }

        [JsonProperty("talk_page_html", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TalkPageHtml { get; set; }
    }

    public partial class ContentUrls
    {
        [JsonProperty("desktop", NullValueHandling = NullValueHandling.Ignore)]
        public Desktop Desktop { get; set; }

        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public Desktop Mobile { get; set; }
    }

    public partial class Desktop
    {
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        [JsonProperty("revisions", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Revisions { get; set; }

        [JsonProperty("edit", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Edit { get; set; }

        [JsonProperty("talk", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Talk { get; set; }
    }

    public partial class Namespace
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }

    public partial class Originalimage
    {
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Source { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }
    }

    public partial class Titles
    {
        [JsonProperty("canonical", NullValueHandling = NullValueHandling.Ignore)]
        public string Canonical { get; set; }

        [JsonProperty("normalized", NullValueHandling = NullValueHandling.Ignore)]
        public string Normalized { get; set; }

        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }
    }
}
