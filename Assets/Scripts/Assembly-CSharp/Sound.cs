using System;
using UnityEngine;

[Serializable]
public class Sound
{
	public AudioSource source;

	public float volume;

	public string name;

	public bool isFadingOut;

	public bool isFadingIn;

	public AudioClip clip;

	public bool loop;

	public float pitch;
}
