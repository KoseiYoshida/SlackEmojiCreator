﻿using System.Text.Json.Serialization;

namespace SlackAPI.Upload
{
    /// <summary>
    /// Response of failured emoji upload.
    /// </summary>
    /// <remarks>See details at <see cref="https://api.slack.com/methods/admin.emoji.add"/></remarks>
    public sealed class FailureResponse
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }
        [JsonPropertyName("error")]
        public string Error { get; set; }
        [JsonPropertyName("response_metadata")]
        public ResponseMetaData ResponseMetaData { get; set; }
    }

    public sealed class ResponseMetaData
    {
        [JsonPropertyName("messages")]
        public string[] Messages { get; set; }
    }
}
