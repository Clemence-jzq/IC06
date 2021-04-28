using System;
using UnityEngine;

public class CharacterSelect2 : MonoBehaviour
{
    private int index = 0;
    public Sprite[] spriteImages;
    private Sprite[] spriteShow;

    // Start is called before the first frame update
    void Start()
    {
        spriteShow = new Sprite[spriteImages.Length];

        for (int i=0; i<spriteImages.Length; i++)
        {
            spriteShow[i] = spriteImages[i];
        }

        Show(index);
    }

    private void Show(int x)
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        //show
        renderer.sprite = this.spriteShow[x];

        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            index += 1;

            if (index >= spriteImages.Length)
                index = 0;

            Show(index);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            index -= 1;

            if (index < 0)
                index = spriteImages.Length - 1;

            Show(index);
        }
    }
}
