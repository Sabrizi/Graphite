using System.Collections;
using System.Collections.Generic;
using System; //Levi might not need this
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour {
    //TODO
    [Serializable]
    public class Count
    {
        public int min;
        public int max;
        public Count(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
    }

    public int width = 400;
    public int height = 400;
    public GameObject exit;
    
    public GameObject[] enemyTypes;
    public GameObject[] weaponTypes;

    private Transform boardHolder;


    void boardSetup()
    {
        //boardHolder = new GameObject("Board").transform;
    }


    Vector2 randomPos()
    {
        return new Vector2(Random.Range(0f, width), Random.Range(0f, width));
    }

    void layout(GameObject[] objects, int min, int max)
    {
        int count = Random.Range(min, max + 1);

        for (int i = 0; i < count; i++)
        {
            Vector2 pos = randomPos();
            GameObject o = objects[Random.Range(0, objects.Length)];
            Instantiate(o, pos, Quaternion.identity);
        }
    }

    public void setup(int level)
    {
        boardSetup();
        int enemyCount = (int)Mathf.Log(level, 2f);
        int weaponCount = (int)Mathf.Log(level, 2f);
        layout(enemyTypes, enemyCount, enemyCount);
        layout(weaponTypes, weaponCount, weaponCount);
    }


}
