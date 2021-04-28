using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterChoosed : MonoBehaviour
{
    private Player[] players;
    private CharacterSelect[] characters;

    // Start is called before the first frame update
    void Start()
    {
        characters[1].getCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("Main");
    }
}
