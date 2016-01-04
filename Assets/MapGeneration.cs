using UnityEngine;
using System.Collections;

public class MapGeneration : MonoBehaviour {

    public Transform floor;
    public Transform wall;
    public Transform player;
    // Use this for initialization
    void Start () {
        Texture2D mySample = Resources.Load("Maps/fazeum") as Texture2D;

        for (int i = 0; i < 8; i++)
        {
            string ods = "";
            for (int j = 0; j < 8; j++)
            {
                float a = mySample.GetPixel(i, j).grayscale;
                ods += a.ToString("0.00") + ", ";
            }
            print(ods);
        }
        /* Texture2D levelBitmap = Resources.Load("Maps/fazeum") as Texture2D;
         Debug.LogWarning(levelBitmap.height);

         //Color[] m_Terrain;
         int m_TerrainWidth;
         int m_TerrainHeight;
         //m_Terrain = levelBitmap.GetPixels();
         m_TerrainWidth = levelBitmap.width;
         m_TerrainHeight = levelBitmap.height;

         Vector3 position = new Vector3((float)m_TerrainHeight / 2 - .5f, 0, (float)m_TerrainWidth / 2 - .5f);
         Instantiate(floor, position, Quaternion.identity);
         floor.transform.localScale = new Vector3((float)m_TerrainWidth/10, 1.0f, (float)m_TerrainHeight/10);
         //Instantiate(player, new Vector3((float)m_TerrainHeight/2, 0, (float)m_TerrainWidth/2), Quaternion.identity);

         int[,] l = new int[8,8];
         for (int i = 0; i < 8; i++)
             for (int j = 0; j < 8; j++)
             {
                 l[i,j] = (int)levelBitmap.GetPixel().grayscale;
             }

         l[0,0] = 1;
         l[7,0] = 1;
         l[0,7] = 1;

         int morango = 0;
         for (int i = 0; i < 8; i++)
             for (int j = 0; j < 8; j++)
             {
                 if(l[i,j] > 0)
                 //if (levelBitmap.GetPixel(i, j).grayscale < .5f)
                 {
                     Instantiate(wall, new Vector3(i, 1, j), Quaternion.identity);
                     morango++;
                 }
             }
         Debug.Log(morango);
         */



    }

    // Update is called once per frame
    void Update () {
	
	}
}