using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour
{
    int WorldSize = 32;
    int Deep = 32;
    Vector3 positions = new Vector3(1,0,1);
    public GameObject Cube;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        for(int k = Deep;k>0;k--){
         for(int i = 1;i<WorldSize;i++){
                positions.x = (i);
                for(int j = 1;j<WorldSize;j++){
                    positions.y = k;
                    positions.z = (j);
                    GameObject Cube2 = Instantiate(Cube);
                    Cube2.transform.position = positions;
                    Debug.Log(positions);
                    positions.z= 0;
                    positions.y = 0;

            }
        }}
        Instantiate(Player,new Vector3(positions.x,5f,positions.x),Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
