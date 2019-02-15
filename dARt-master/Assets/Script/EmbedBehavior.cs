using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmbedBehavior : MonoBehaviour
{
    Rigidbody rigidB;
    // Use this for initialization
    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        rigidB.constraints = RigidbodyConstraints.FreezeAll;
        transform.parent = collision.transform;

        if (!(KeepScore.Score < 0))
        {
            if (collision.gameObject.name == "vier")
            {
                int current = KeepScore.Score - 40;
                if (((Mathf.Sign(current)) < 0))
                {
                    LastScore.Score = 40;
                }
                else
                {
                    LastScore.Score = 40;
                    KeepScore.Score -= 40;
                    CheckScore();
                }
            }
            if (collision.gameObject.name == "sechs")
            {
                int current = KeepScore.Score - 60;
                if (((Mathf.Sign(current)) < 0))
                {
                    LastScore.Score = 60;
                }
                else
                {
                    KeepScore.Score -= 60;
                    LastScore.Score = 60;
                    CheckScore();
                }
            }
            if (collision.gameObject.name == "acht")
            {
                int current = KeepScore.Score - 80;
                if (((Mathf.Sign(current)) < 0))
                {
                    LastScore.Score = 80;
                }
                else
                {
                    KeepScore.Score -= 80;
                    LastScore.Score = 80;
                    CheckScore();
                }
            }
            if (collision.gameObject.name == "eins")
            {
                int current = KeepScore.Score - 100;
                if (((Mathf.Sign(current)) <= 0))
                {
                    LastScore.Score = 100;
                }
                else
                {
                    KeepScore.Score -= 100;
                    LastScore.Score = 100;
                    CheckScore();
                }
            }
        }
    }

    private void CheckScore()
    {
        if (KeepScore.Score == 0)
        {
            KeepScore.Score = 720;
        } else if (KeepScore.Score == 20)
        {
            KeepScore.Score = 720;
        }
    }
}