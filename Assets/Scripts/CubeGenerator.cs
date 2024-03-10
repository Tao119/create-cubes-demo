using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CubeGenerator : MonoBehaviour
{

    public GameObject cube;
    public List<GameObject> cubes = new List<GameObject>();
    public int rangeX = 50;
    public int rangeY = 50;

    void Start()
    {
        createCube();
    }

    public void createCube()
    {
        float newX = Random.value * rangeX;
        float newY = Random.value * rangeY;
        while (cubes.Count > 0 && cubes.All(value => Mathf.Abs(value.transform.position.x - newX) < cube.transform.localScale.x && Mathf.Abs(value.transform.position.y - newY) < cube.transform.localScale.y))
        {
            newX = Random.value * rangeX;
            newY = Random.value * rangeY;
        }
        GameObject newCube = Instantiate(cube, new Vector3(newX, 0f, newY), Quaternion.identity, this.gameObject.transform);
        cubes.Add(newCube);

        float maxX = 0;
        GameObject maxGo = cubes[0];
        foreach (GameObject item in cubes)
        {
            item.tag = "cube";
            if (maxX < item.transform.position.x)
            {
                maxX = item.transform.position.x;
                maxGo = item;
            }
        }
        maxGo.tag = "rightCube";
    }
}
