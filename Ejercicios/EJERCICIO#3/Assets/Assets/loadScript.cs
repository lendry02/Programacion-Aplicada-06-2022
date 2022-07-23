using System;
using System.Collections.Generic;
using UnityEngine;


public class loadScript : MonoBehaviour
{
    public GameObject A, B, C, D, E, F, G, H, I, J, K, L, P, W,Z;
    public GameObject player, enemy;
    TextAsset tmp;
    string[] words;
    Dictionary<string, GameObject> prefabs;

    private void Awake()
    {

      //  Instantiate(player, new Vector3(2, 3.9f), Quaternion.identity);

       // for (int i = 0; i < 5; i++)
       // {

           // Instantiate(enemy, new Vector3(UnityEngine.Random.Range(1.70f, 98), UnityEngine.Random.Range(2, 3.3f)), Quaternion.identity);
      //  }
        prefabs = new Dictionary<string, GameObject>()
        {
            {"A", A},
            {"B", B},
            {"C", C},
            {"D", D},
            {"E", E},
            {"F", F},
            {"G", G},
            {"H", H},
            {"I", I},
            {"J", J},
            {"K", K},
            {"L", L},
            {"P", P},
            {"W", W},
            {"Z", Z}
        };

    }



    void Start()
    {

        tmp = Resources.Load<TextAsset>("mapa4");
        string newTxt = tmp.text.Replace('\n', ',');
        words = newTxt.Split(',');


        for (int i = 0; i < words.Length; i++)
        {
           // string word = words[i].Trim();
           // Instantiate(prefabs[word], new Vector3(i % 100, i / 100), Quaternion.identity);

            if (prefabs.ContainsKey(words[i]))
            {
                if (words[i] == "W")
                {
                    Instantiate(A, new Vector3(i % 100, -(i / 100)), Quaternion.identity);
                }

                if (words[i] == "Z")
                {
                    print("Z entro");
                    Instantiate(Z, new Vector3(i % 100, -(i / 100)), Quaternion.identity);
                }

                // if (!words[i].Equals('W'))
                // {
                //   Instantiate(prefabs[words[i]], new Vector3(i % 100, -(i / 100)), Quaternion.identity);

                //  }

                Instantiate(prefabs[words[i]], new Vector3(i % 100, -(i / 100)), Quaternion.identity);
            }

                // if (word == "F")
                //{

                //}
                //else
                //{
                //    Instantiate(prefabs[word], new Vector3(i % 100, i / 100), Quaternion.identity);

                // }
        }

        // tmp = Resources.Load<TextAsset>("mapa4");
        // for (int i = 0; i < tmp.text.Length; i++)
        // {

        //   if (prefabs.ContainsKey(tmp.text[i].ToString()))
        //  {
        //   Instantiate(prefabs[tmp.text[i].ToString()], new Vector3(i % 100, i / 100), Quaternion.identity);
        //  }
        // else if (tmp.text[i].ToString().Equals("F"))
        // {
        //print(tmp.text[i].ToString());
        //   Instantiate(prefabs[tmp.text[i].ToString()], new Vector3((i % 100)+0.4f, ((i / 100)+0.9f)*-1), Quaternion.identity);


        //  }
        // else if(!tmp.text[i].ToString().Equals('\0'))
        // {
        //  Instantiate(B, new Vector3(i % 100, i / 100), Quaternion.identity);

        // string h = "prefab: " + tmp.text[i].ToString();
        // print(h);
        //  }

        //  };






    }

}
