using UnityEngine;

public class CommentaryAudio : MonoBehaviour
{
    public AudioSource source;

    public void Play(AudioClip clip)
    {
        if (source && clip) source.PlayOneShot(clip);
    }
}
