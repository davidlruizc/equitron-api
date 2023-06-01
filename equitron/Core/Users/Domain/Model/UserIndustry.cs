using Utilities.Domain;

namespace Core.Users.Domain.Model
{
	public class UserIndustry : BaseEntity
	{
        public Guid UserId { get; set; }
        public Guid IndustryId { get; set; }

        private UserIndustry(Guid id, Guid userId, Guid industryId)
        {
            Id = id;
            UserId = userId;
            IndustryId = industryId;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static UserIndustry Of(Guid userId, Guid industryId)
        {
            return new UserIndustry(Guid.Empty, userId, industryId);
        }
    }
}

