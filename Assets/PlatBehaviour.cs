using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlatBehaviour : MonoBehaviour
{
    
    public List<GameObject> listOfPlatforms = new List<GameObject>();
    private GameObject [] platform;
	// Use this for initialization
	void Start ()
    {
        
        platform = GameObject.FindGameObjectsWithTag("platform");
        listOfPlatforms.AddRange(platform);
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

}
