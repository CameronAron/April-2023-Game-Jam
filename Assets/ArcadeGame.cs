using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeGame : MonoBehaviour
{
    //[SerializeField] bool gameStarted; 
    [SerializeField] pressStartButton startScript;
    [SerializeField] GameObject startScreen;
    //[SerializeField] GameObject Fruit;
    [SerializeField] Transform SpawnOne;
    [SerializeField] Transform SpawnTwo;
    [SerializeField] Transform SpawnThree;
    [SerializeField] GameObject FruitPrefab;

    private float counter = 0f;
    private int random = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startScript.GameStarted)
        {
            startScreen.SetActive(false);

            counter += Time.deltaTime;

            Debug.Log(counter);

            if (counter > 3f)
            {
                random = Random.Range(1, 4);
                if (random == 1)
                {
                    Instantiate(FruitPrefab, new Vector3(SpawnOne.position.x, SpawnOne.position.y, SpawnOne.position.z), new Quaternion(0, 45, 0, 0));
                }
                else if (random == 2)
                {
                    Instantiate(FruitPrefab, new Vector3(SpawnTwo.position.x, SpawnTwo.position.y, SpawnTwo.position.z), new Quaternion(0, -45, 0, 0));
                }
                else if (random == 3)
                {
                    Instantiate(FruitPrefab, new Vector3(SpawnThree.position.x, SpawnThree.position.y, SpawnThree.position.z), new Quaternion(0, 180, 0, 0));
                }
                else
                {

                }

                counter = 0;
            }
        }
    }
}
