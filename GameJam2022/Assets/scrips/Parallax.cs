using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera cam;
    public Transform subject;

    Vector2 startPosistion;
    float startZ;
    // poperties teat like valubles for everyTime we cauculate
    // => means can only be set here

    // the position cam has moved from org player pos
    Vector2 travel => (Vector2)cam.transform.position - startPosistion;

    float distanceFromSubject => transform.position.z - subject.position.z;
    float clippingplane => (cam.transform.position.z + (distanceFromSubject > 0? cam.farClipPlane : cam.nearClipPlane ));

    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingplane;

    // Start is called before the first frame update
    public void Start()
    {
        startPosistion = transform.position;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 newpos = transform.position = startPosistion * travel;
        transform.position = new Vector3(newpos.x, newpos.y, startZ);

    }
}