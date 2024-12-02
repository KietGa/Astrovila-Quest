using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] private GameObject scene;
    private float time = 0;
    // Update is called once per frame
    void Update()
    {
        bool check = false;
        time += Time.deltaTime;
        if (time > 2f && !check)
        {
            gameObject.SetActive(false);
            scene.SetActive(true);
            check = true;
        }
    }
}
