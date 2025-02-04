using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] Image pie;
    public Sprite greenpie;
    [SerializeField] GameObject spawner;
    public GameObject spawnObject;
    private GameObject[] Spawners;
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Instantiate(spawnObject, pos+offset, Quaternion.identity);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Delete();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Delete();
            player.transform.position = new Vector3(0, 0, 0);
            Instantiate(spawnObject, new Vector3(12, -10, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Delete();
            player.transform.position = new Vector3(0, 0, 0);
            Instantiate(spawnObject, new Vector3(-10, 10, 0), Quaternion.identity);
            Instantiate(spawnObject, new Vector3(-6, 12, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Scene");
        }
    }
    void Delete()
    {
        pie.sprite = greenpie;
        Spawners = GameObject.FindGameObjectsWithTag("Spawner");
        foreach (GameObject spawner in Spawners)
        {
            Destroy(spawner);
        }
    }
    public void exitGame()
    {
        Application.Quit();
    }

}
