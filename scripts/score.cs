
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // this detects the player / cube
    public Transform player;
    // this gets the distanceText (lower down in the code) and sends it to "Text", which then changes the text in the UI
    public Text distanceText;

    // Update is called once per frame
    void Update()
    {
        //this tells the computer that the number that is the player's Z position is the same thing as "distanceText.text"
        distanceText.text = player.position.z.ToString("0");
    }
}
