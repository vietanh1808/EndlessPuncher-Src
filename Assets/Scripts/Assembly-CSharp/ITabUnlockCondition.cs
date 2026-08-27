public interface ITabUnlockCondition
{
	bool IsUnlocked { get; }

	string LockedMessage { get; }
}
