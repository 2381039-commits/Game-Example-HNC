using System.Runtime.CompilerServices;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("What A Wonderful Day!");
        Debug.LogWarning("This Is A Warning!");
        Debug.LogWarning("Error!");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, (float)0.09, (float)0.07);
    }
}
