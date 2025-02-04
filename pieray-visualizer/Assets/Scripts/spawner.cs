using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public Sprite bluepie;
    public Sprite greenpie;
    public Image pie;
    private float Memory = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spawner")
        {
            Memory = transform.localScale.z;
            pie.sprite = bluepie;
        }
    }
    private void Update()
    {
        if (transform.localScale.z == Memory-4)
        {
            Memory = transform.localScale.z;
            pie.sprite = greenpie;
        }
    }
}
