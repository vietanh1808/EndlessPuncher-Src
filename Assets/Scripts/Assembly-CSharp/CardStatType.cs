using System;

[Flags]
public enum CardStatType
{
	damage = 1,
	defence = 2,
	duration = 4,
	coolDown = 8,
	effect = 0x10,
	count = 0x20
}
