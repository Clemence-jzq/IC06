using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    private int index = 0;
    public GameObject[] characterPrefabs;
    private GameObject[] characterShow;

    // Start is called before the first frame update
    void Start()
    {
        characterShow = new GameObject[characterPrefabs.Length];

        for (int i = 0; i < characterPrefabs.Length; i++)
        {
            characterShow[i] = (GameObject)Instantiate(characterPrefabs[i], transform.position, transform.rotation);
        }

        ChangeCharacter(index);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            index += 1;

            if (index >= characterPrefabs.Length)
                index = 0;

            ChangeCharacter(index);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            index -= 1;

            if (index < 0)
                index = characterPrefabs.Length - 1;

            ChangeCharacter(index);
        }
    }

    private  void ChangeCharacter(int x)
    {
        for (int i = 0; i < characterPrefabs.Length; i++)
        {
            if (i == x)
                //show
                characterShow[i].SetActive(true);
            else
                //invisible
                characterShow[i].SetActive(false);
        }
    }

    public GameObject getCharacter()
    {
        return characterShow[index];
    }
}
