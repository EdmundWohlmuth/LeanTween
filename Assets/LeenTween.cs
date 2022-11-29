using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeenTween : MonoBehaviour
{
    public GameObject scaleCapy;
    public GameObject translationCapy;
    public GameObject rotationCapy;
    public GameObject Capybara;

    public GameObject scaletopos;
    public GameObject transformto;
    public GameObject rotateto;

    public void Scaling()
    {
        LeanTween.scale(scaleCapy, new Vector3(.5f, .75f, .5f), 4f);
        LeanTween.move(scaleCapy, scaletopos.transform.position, 4f).setEaseOutElastic();
    }

    public void Translation()
    {
        LeanTween.move(translationCapy, transformto.transform.position, 3f).setEaseOutBounce();
    }

    public void Rotation()
    {
        LeanTween.rotate(rotationCapy, new Vector3(0, 0, 270), 4f);
        LeanTween.move(rotationCapy, rotateto.transform.position, 4f);
    }

    public void AllTheTween()
    {
        int id = LeanTween.move(Capybara, new Vector3(Capybara.transform.position.x + 50,
                                            Capybara.transform.position.y,
                                            Capybara.transform.position.z), 3f).setEaseOutElastic().id;
        LTDescr d = LeanTween.descr(id);

        if (d != null)
        {
            d.setOnComplete(PartTwo).setEaseInElastic();
        };
    }

    public void PartTwo()
    {
        int id = LeanTween.rotate(Capybara, new Vector3(0, 0, 270), 4f).id;

        LTDescr d = LeanTween.descr(id);

        if (d != null)
        {
            d.setOnComplete(PartThree).setEaseOutElastic();
        };
    }

    public void PartThree()
    {
        int id = LeanTween.rotate(Capybara, new Vector3(0, 0, 360), 4f).id;

        LTDescr d = LeanTween.descr(id);

        if (d != null)
        {
            d.setOnComplete(PartFour).setEaseOutElastic();
        };
    }

    public void PartFour()
    {
        int id = LeanTween.move(Capybara, new Vector3(Capybara.transform.position.x - 50,
                                    Capybara.transform.position.y,
                                    Capybara.transform.position.z), 3f).id;
        LTDescr d = LeanTween.descr(id);

        if (d != null)
        {
            d.setOnComplete(PartFive);
        };
    }

    public void PartFive()
    {
        int id = LeanTween.scale(Capybara, new Vector3(0f, 0f, 0f), 2f).id;
        LTDescr d = LeanTween.descr(id);

        if (d != null)
        {
            d.setOnComplete(PartSix);
        }
    } 

    public void PartSix()
    {
        LeanTween.scale(Capybara, new Vector3(1f, 1f, 1f), 2f);
    }
}
