using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSprite : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
    }
}
