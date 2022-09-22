public class AuthContext {
    public const string Microsoft = "AzureAd";
    public const string Google = "GoogleCloud";
    public string Instance{ get; set; } = String.Empty;
    public string Domain{ get; set; } = String.Empty;
    public string TenantId{ get; set; } = String.Empty;
    public string ClientId{ get; set; } = String.Empty;

    public string Scopes{ get; set; } = String.Empty;
    public string CallbackPath{ get; set; } = String.Empty;
    public string Secret{ get; set; } = String.Empty;
}