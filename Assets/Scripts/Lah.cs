// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Lah : MonoBehaviour
{
    public SpriteRenderer pointer;
    public Rigidbody2D rb;
    public float launchForce = 200;

    bool launched = false;

    void Start() { }

    void Update()
    {
        this.RotatePointer();
        this.LaunchSelf();
    }

    void RotatePointer()
    {
        if (!this.launched)
        {
            Vector2 mouse = Input.mousePosition;
            Vector2 mouse_pos = Camera.main.ScreenToWorldPoint(mouse);
            Vector2 this_pos = this.rb.position;
            var angle =
                (Mathf.Atan2(mouse_pos.y - this_pos.y, mouse_pos.x - this_pos.x) * Mathf.Rad2Deg)
                - 90
                - 180;
            var eulerAngles = pointer.transform.eulerAngles;
            eulerAngles.z = angle;
            pointer.transform.eulerAngles = eulerAngles;
        }
    }

    void LaunchSelf()
    {
        if (Input.GetMouseButtonDown(0) && !this.launched)
        {
            this.launched = true;
            this.pointer.enabled = false;
            var angle = (this.pointer.transform.eulerAngles.z + 90) * Mathf.Deg2Rad;
            this.rb.AddForce(
                new Vector2(
                    Mathf.Cos(angle) * this.launchForce,
                    Mathf.Sin(angle) * this.launchForce
                )
            );
        }
    }
}
