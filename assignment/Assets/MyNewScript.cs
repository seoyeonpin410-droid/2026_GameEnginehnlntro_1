using UnityEngine;

public class MyNewScript : MonoBehaviour
{

    public string playerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello " + playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
