using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public GameObject character;
    public Animator characterAnim;
    // Start is called before the first frame update
    void Start()
    {
        //Karakter atamasını kodun ekli olduğu gameobject olarak seçiyoruz
        character = this.gameObject;
        //Karakterin animator üzerinden yürüme animasyonunu kontrol ediyoruz
        characterAnim.SetBool("isRun", true);
    }

    // Update is called once per frame
    void Update()
    {
        //Karakterin belirlediğimiz hızını frame geçiş süresi ile çarparak daha gerçekçi bir yürüme yapıyoruz
        character.transform.Translate(Vector3.forward * speed*Time.deltaTime);

    }
}
