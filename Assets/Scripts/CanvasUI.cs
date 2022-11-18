using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasUI : MonoBehaviour
{
    public TextMeshProUGUI judul_txt;
    public TextMeshProUGUI deskripsi_txt;
    public Image image_ui;

    //tujuannya adalah membuat spesifik dari setiap element yang diinteraksikan hello
    public GameObject target = null;

    List<global> arr = new List<global>();

    // Start is called before the first frame update
    void Start()
    {
        global obj_;
        obj_= new global("kotak", "ini adalah kotak","gambar1");
        arr.Add(obj_);
        obj_ = new global("capsule", "ini adalah capsule","gambar2");
        arr.Add(obj_);
        obj_ = new global("lingkaran", "ini adalah lingkaran","gambar3");
        arr.Add(obj_);
     
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDataText(int paramID, GameObject obj)
    {
        target = obj;
        judul_txt.text = arr[paramID].getJudul();
        deskripsi_txt.text = arr[paramID].getDeskripsi();
        Sprite sp = Resources.Load<Sprite>(arr[paramID].getGambar());
        image_ui.overrideSprite = sp;
        

        //image_ui.overrideSprite = sp;

    }

    public GameObject getTarget()
    {
        return target;
    }

    public void closeWindow()
    {
        target.GetComponent<MouseEvent>().doCloseAnim();
        target = null;
    }




}
