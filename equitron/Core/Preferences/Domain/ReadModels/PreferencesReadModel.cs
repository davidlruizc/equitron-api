namespace Core.Preferences.Domain.ReadModels
{
    public class PreferencesReadModel
    {
        public Guid Id { get; set; }
        public string Symbol { get; set; }
        public Guid UserId { get; set; }
    }
}
