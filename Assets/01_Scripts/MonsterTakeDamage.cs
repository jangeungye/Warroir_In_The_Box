using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTakeDamage : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    float monster1Health = 100;   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet1"))
        {
            StartCoroutine(TakeDamage(1));
        }
    }
    IEnumerator TakeDamage(float count)
    {
        monster1Health--;

        spriteRenderer.material.color = Color.red;
        yield return new WaitForSecondsRealtime(0.05f);//�����ʿ�
        spriteRenderer.material.color = Color.white;
    }
}