using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Platform_Controller : MonoBehaviour
{
    public GameObject platform,Label;
    public TMP_Text label_text;
    public Transform ray_origin;
    public BoxCollider2D boxCollider;
    public SpriteRenderer spriteRenderer;
    private bool platform_moving = false;
    private Vector3 offset;
    public float platform_height;
    void Start()
    {
        PlatformModeChange(false);
    }

    void Update()
    {
        
        if(platform_moving)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
        platform_height = ray_origin.position.y;
        label_text.text = "Platform Yüksekliği:" + (Mathf.Round(platform_height * 10.0f) * 0.1f);
    }
    public void PlatformModeChange(bool tog)
    {
        if (tog)
        {
            PlatformOn();
        }
        else
        {
            PlatformOff();
        }
    }
    void PlatformOn()
    {
        boxCollider.enabled = true;
        spriteRenderer.enabled = true;
    }
    void PlatformOff()
    {
        boxCollider.enabled = false;
        spriteRenderer.enabled = false;
    }
    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        platform_moving = true;
    }
    private void OnMouseUp()
    {
        platform_moving = false;
    }
}
