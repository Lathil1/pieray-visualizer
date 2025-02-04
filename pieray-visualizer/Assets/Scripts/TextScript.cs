using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    [SerializeField] GameObject renderDistance;
    private float distance = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = renderDistance.transform.localScale.z;
        text.text = $"RD: {distance}";
    }
}
