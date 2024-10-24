﻿using Newtonsoft.Json;

namespace TsundokuTraducoes.Helpers.DTOs.Public.Retorno
{
    public class RetornoObras
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UrlCapaPrincipal { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UrlCapaVolume { get; set; }
        
        public string UrlCapa { get; set; }
        public string Alias { get; set; }        
        public string Autor { get; set; }
        public string DescritivoVolume { get; set; }
        public string Slug { get; set; }
        public Guid Id { get; set; }
    }
}
