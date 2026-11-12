using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class logoScript : MonoBehaviour
{
    //PSEUDO CODE: Declare(Create) a public variable for a Game Object, Type: Renderer
    public Renderer myRenderer;
    //FUNCTION: Accesses "this" Game Object by default, or can drag in another in Inspector Box....
    void Start()
    {
        //PSEUDO CODE: Initialize variable with Mesh Renderer from Game Object this script is attached to...
        myRenderer = GetComponent<Renderer>();
        //(default), or use "this" to specify more precisely, or drag in different Game Object to Inspector Box.
        //ALTERNATE: use "this" to access variable
    }
    void Update()
    {
        //PSEUDO CODE: Check for Key input (Space Key)
        if (Input.GetKeyDown(KeyCode.Space)) {
            
                //PSEUDO CODE: Turn on/off mesh renderer
                myRenderer.enabled = !myRenderer.enabled;
            //ALTERNATE: use "this"
            //this.GetComponent<Renderer>().enabled = !this.GetComponent<Renderer>().enabled;
            }
        }
    }

