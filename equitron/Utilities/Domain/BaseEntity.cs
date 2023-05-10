namespace Utilities.Domain
{
	public abstract class BaseEntity
	{
		public Guid Id { get; set; }
		public DateTime Creation { get; set; }
	}
}