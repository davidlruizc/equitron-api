namespace Utilities.Domain
{
	public abstract class BaseEntity
	{
		public Guid Id { get; set; }
		public DateTime Creation { get; set; }

		public void InitializeBase()
		{
            Id = Guid.NewGuid();
            Creation = DateTime.Now;
        }
	}
}