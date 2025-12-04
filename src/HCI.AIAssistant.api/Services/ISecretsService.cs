using HCI.AIAssistant.api.Models.CustomTypes;

namespace HCI.AIAssistant.API.Services;

public interface ISecretsService
{
    public AIAssistantSecrets? AIAssistantSecrets { get; set; }
    public IoTHubSecrets? IoTHubSecrets { get; set; }
}