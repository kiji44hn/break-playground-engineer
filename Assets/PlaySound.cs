using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    // �A�j���[�V�����C�x���g�ŌĂяo�����֐�
    public void PlaySoundEffect()
    {
        audioSource.Play();
    }
}