using UnityEngine;

public class rotateAround : MonoBehaviour
{

    //public string nameTest;
    //public bool booleanTest;
    //public int intTest;
    public float speed;


    //public enum EnumTest { A, B, C, D};
    //public EnumTest testEnum;

    //public GameObject[] gameObjectsTest;

    //public GameObject gameObjectTest;

    public Transform target;
    private void Start()
    {
        //Debug.Log("Olá mundo !");

        //Verificação Inicial
        if (target != null) return;
        target = transform;
        Debug.Log("Alvo n definido");

    }

    private void Update()
    {
        //Debug.Log("INVOCADO UPDATE METHOD !");
        //transform.RotateAround(transform.position, new Vector3(0, 1, 0), speed);
        transform.RotateAround(transform.position, Vector3.up, speed * Time.deltaTime);
        //Debug.Log(Time.deltaTime);
    }

}
