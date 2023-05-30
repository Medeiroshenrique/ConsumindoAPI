using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConsumindoAPIRest;

public class CepResponse
{
    [JsonProperty("cep")]
    public string CEP { get; set; }
    [JsonProperty("logradouro")]
    public string Logradouro { get; set; }
    [JsonProperty("complemento")]
    public string Complemtento { get; set; }
    [JsonProperty("bairro")]
    public string Bairro { get; set; }
    [JsonProperty("localidade")]
    public string Localidade { get; set; }
    [JsonProperty("uf")]
    public string Uf { get; set; }
    [JsonProperty("ibge")]
    public string IBGE { get; set; }
    [JsonProperty("gia")]
    public string GIA { get; set; }
    [JsonProperty("ddd")]
    public string DDD { get; set; }
    [JsonProperty("siafi")]
    public string SIAFI { get; set; }
}