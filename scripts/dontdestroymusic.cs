using UnityEngine;

public class dontdestroymusic : MonoBehaviour
{
    void Awake(){

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if(objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }
}
