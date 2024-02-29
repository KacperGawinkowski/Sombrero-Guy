using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject movementChangedPopupPrefab;
    private GameObject movementChangedPopup;

    private Animator anim;
    public GameObject skin;
    public float moveSpeed;

    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    float time = 30;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    public void changeMovementBingings()
    {
        KeyCode[] sigm;
        sigm = new KeyCode[4];
        sigm[0] = KeyCode.W;
        sigm[1] = KeyCode.S;
        sigm[2] = KeyCode.A;
        sigm[3] = KeyCode.D;

        List<int> list = new List<int>();
        list = new List<int>(new int[4]);

        for(int i = 0; i < 4; i ++)
        {
            int Rand = Random.Range(0, 5);
            while(list.Contains(Rand))
            {
                Rand = Random.Range(0, 5);
            }
            list[i] = Rand;
            Debug.Log(list[i]);
        }

        up = sigm[list[0]-1];
        down = sigm[list[1]-1];
        left = sigm[list[2]-1];
        right = sigm[list[3]-1];

        list.Clear();
    }

    void movement()
    {
        Vector3 moveDir = Vector3.zero;

        if (Input.GetKey(up))
        {
            moveDir.z++;
        }
        if (Input.GetKey(down))
        {
            moveDir.z--;
        }
        if (Input.GetKey(left))
        {
            moveDir.x--;
        }
        if (Input.GetKey(right))
        {
            moveDir.x++;
        }

        if (moveDir.x != 0 && moveDir.z != 0)
        {
            moveDir = moveDir / Mathf.Sqrt(2f);
        }

        if (moveDir == Vector3.zero)
        {
            anim.SetBool("walk", false);
        }
        else
        {
            anim.SetBool("walk", true);
            skin.transform.rotation = Quaternion.LookRotation(moveDir);
        }

        transform.position = transform.position + moveDir * Time.deltaTime * moveSpeed;
    }

    void movementChangeTimer()
    {
        time -= Time.deltaTime;
        if(time < 0 )
        {
            movementChangedPopup = Instantiate(movementChangedPopupPrefab, GameObject.Find("Canvas").transform);
            Destroy(movementChangedPopup, 8f);

            changeMovementBingings();
            time = 30;
            Time.timeScale = 1;
        }
    }
}
