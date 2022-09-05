using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update

    private Renderer buttonRender;
    private bool buttonPressed = false;

    public GameObject door;
    public Texture doorTexture;
    public Texture buttonTexture;

    void Start()
    {
        buttonRender = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && buttonPressed == false)
        {
            door.transform.position = door.transform.position - new Vector3(0, 2.7f, 0);
            door.GetComponent<Renderer>().material.mainTexture = doorTexture;
            buttonRender.material.mainTexture = buttonTexture;
            buttonPressed = true;
        }
    }



}
