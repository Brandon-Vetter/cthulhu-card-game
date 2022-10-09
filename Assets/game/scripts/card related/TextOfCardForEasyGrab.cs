using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextOfCardForEasyGrab : MonoBehaviour
{
    public List<TextMeshPro> AllMyText = new List<TextMeshPro>();
    public Sprite BloodOrSanity;
    public Sprite Art;

    [SerializeField] private SpriteRenderer ArtOfBloodOrSanity;
    [SerializeField] private SpriteRenderer ArtOnCard;
}
