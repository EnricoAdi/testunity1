using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    public int id;
    public GameObject canvas;
    Animator an;

    private void Awake()
    {
        an = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //cek apakah target yang menjadi spesifik adalah game object ini. jika ia pastikan bahwa kemunculan berada pada posisi main
        if (canvas.GetComponent<CanvasUI>().getTarget() == gameObject && an.GetCurrentAnimatorStateInfo(0).IsName("Main"))
        {
            //munculkan canvas 
            canvas.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (canvas.gameObject.activeSelf == false)
        {
            //ubah datanya dan isi nama target yang dituju adalah game object ini 
            canvas.GetComponent<CanvasUI>().setDataText(id, gameObject);
            //jalankan animasinya
            an.SetInteger("animasi", 1);
        }
    }

    public void doCloseAnim()
    {
        canvas.SetActive(false);
        an.SetInteger("animasi", 0);
    }



}
