using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuGlyph : MonoBehaviour
{
    [SerializeField] private GameObject Glyph;

    public Sprite[] Glyphs;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = Glyph.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Glyphs[Random.Range(0, Glyphs.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
