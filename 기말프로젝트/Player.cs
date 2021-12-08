using UnityEngine;

public class Player : MonoBehaviour
{
    public static int cnt;
    private AudioSource audioSource;

    private void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Item"))
        {
            audioSource.Play();
            Destroy(col.gameObject);
            cnt++;
        }
    }
}