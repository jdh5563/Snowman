using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStructure : MonoBehaviour
{
	public GameObject structure;
    // Start is called before the first frame update
    void Start()
    {
		//66, 1, 41 /// 47, 1, 27
		Instantiate(structure, new Vector3(66, 1, 41), Quaternion.Euler(180, 0, 0));
		Instantiate(structure, new Vector3(47, 1, 27), Quaternion.Euler(180, 0, 0));
	}
}
