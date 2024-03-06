using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace ClassDemos
{
    public class Bullet : MonoBehaviour
    {


        [SerializeField] float speed;

        private void Awake()
        {

            Destroy(gameObject, 15f);

        }

        // Update is called once per frame
        void Update()
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }

        private void OnTriggerEnter(Collider other)
        {

            //Destroy(gameObject);

            //if (other.transform.name == "Enemy")
            //{

            //    other.GetComponent

            //}

        }

        public void Damage()
        {

            Debug.Log("Damage!");

        }
    }
}
