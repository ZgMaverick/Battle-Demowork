using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GridManager : MonoBehaviour
{
    //public GameObject[] objetos;
    //public GameObject[] peon;
    //public GameObject tabuleiro;
    //private GameObject[] cubeVectorStorage;
    //private GameObject[,] cube2dVectorStorage;
    //public GameObject particulaSpawn;
    //private int numMaxObjetos;    
    //private int numObjetos;
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private Material[] materialPanel;

    [SerializeField]
    private int painelVertical;
    [SerializeField]
    private int painelHorisontal;
    [SerializeField]
    private GameObject painelPrefab;
    //[SerializeField]
    //private AudioSource[] audio;
    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateGrid()
    {
        //criar cubos
        for (int i = 0; i < painelVertical; ++i) 
        {
            for (int j = 0; j < painelHorisontal; ++j)
            {
                Vector3 spawnCubeLoc = new Vector3(j, 0, i) + Vector3.zero;
                GameObject cubeTemp = Instantiate(painelPrefab, spawnCubeLoc, Quaternion.identity, this.transform);
                cubeTemp.name ="{"+ (j) + "." + (i) + "}";
                if (j + 1 <= painelHorisontal / 2) cubeTemp.GetComponent<Renderer>().material = materialPanel[0];
                else if ((painelHorisontal / 2) == j && ((float)painelHorisontal / 2) % 1 != 0) cubeTemp.GetComponent<Renderer>().material = materialPanel[2];
                else cubeTemp.GetComponent<Renderer>().material = materialPanel[1];
            }
        }
        //camera dinamica
        Vector3 camPos = new Vector3(0, painelHorisontal, 0);
        //Maincamera.transform.parent.parent.position = ((cube2dVectorStorage[0, 0].transform.position + cube2dVectorStorage[numCasas - 1, numCasas - 1].transform.position) / 2);
        //Maincamera.transform.position += camPos;
    }
}
