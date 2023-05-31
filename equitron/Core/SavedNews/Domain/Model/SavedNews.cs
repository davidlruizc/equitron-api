using System;
using Utilities.Domain;

namespace Core.SavedNews.Domain.Model
{
	public class SavedNews : BaseEntity
	{
		public Guid UserId { get; set; }
		public Guid NewsId { get; set; }
		public string Title { get; set; }
	}
}

