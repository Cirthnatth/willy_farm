using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_scr : MonoBehaviour
{
    public float car_speed_forward;
    public float car_speed_left;
    public float car_speed_right;
    public float car_speed_backward;
    public int Area_width;
    public int Area_length;
    public float circle_radius;
    public int circle_radius_2;
    public int Circle_radius_3;
    public int multiplyer;
    public int s;
    public int d;
    public int e;
    // Start is called before the first frame update
    void Start()
    {
        addition2();
        addition();
        
        // car_speed_left = car_speed_left * (-1);
        // car_speed_backward = car_speed_backward * (-1);
    }


    // Update is called once per frame
    void Update()
    {
        addition(s, d);
        addition(s, d, e);
        addition_str(s, d, e);
        int Reciv_Area_2 = 0;
        int Reciv_Area_3 = 0;
        //  int CircleRecArea2 = Circle(circle_radius_2);
        //int circleRecArea3 = Circle(Circle_radius_3, multiplyer);
        //int Reciv_Area_1 = Rectangle(Area_width, Area_length,out Reciv_Area_2,out Reciv_Area_3);
        // float CircleRecArea_1 = Circle(circle_radius);
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, car_speed_forward);
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(car_speed_left * (-1), 0, 0);

            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(car_speed_right, 0, 0);
            }
        }


        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, car_speed_backward * (-1));
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(car_speed_left * (-1), 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(car_speed_right, 0, 0);
            }
        }
    }
    public float Circle(float _radius)
    {
        float radius = _radius;
        float area_c_1 = 2 * 22 / 7 * radius * radius;
        Debug.Log("area_circle_float = " + area_c_1);
        return area_c_1;
    }
    public int Circle(int _radius)
    {
        int radius = _radius;
        int area_c_2 = 2 * 22 / 7 * radius * radius;
        Debug.Log("area_circle_int = " + area_c_2);
        return area_c_2;
    }
    public int Circle(int _radius, int _Multiplyer)
    {
        int radius = _radius;
        int Multiplyer = _Multiplyer;
        int area_c_3 = 2 * 22 / 7 * radius * radius;
        int area_c_multiply = area_c_3 * Multiplyer;
        Debug.Log("area_circle_Multiplyed = " + area_c_multiply);
        return area_c_multiply;
    }

    public int Rectangle(int _width, int _length, out int Rec_out1, out int Rec_out2)
    {
        int width = _width;
        int length = _length;
        int area1 = width * length;
        int area2 = area1 + 2;
        int area3 = area1 * 3;
        Debug.Log("area = " + area1);
        Rec_out2 = area3;
        Rec_out1 = area2;
        return area1;
    }
    public void addition()
    {
        int adding = 10 + 5;
        Debug.Log("adding = " + adding);
    }
    public void addition2()
    {
        int adding = s + d;
        Debug.Log("adding2 = " + adding);

    }
    public void addition(int _fst, int _snd)
    {
        int fst = _fst;
        int snd = _snd;
        int adding = fst + snd;
        Debug.Log("adding3 = " + adding);
    }
    public void addition(int _first, int _second, int _third)
    {

        int adding = _first + _second + _third;
        Debug.Log("adding4 = " + adding);
    }
    public int addition5(int _first, int _second, int _third)
    {
        int adding_2 = _first + _second + _third;
        Debug.Log("adding5 = " + adding_2);
        return adding_2;
    }
    public float addition5(float _first, float _second, float _third)
    {
        float adding_2 = _first + _second + _third;
        Debug.Log("adding6 = " + adding_2);
        return adding_2;
    }
    public double addition5(double _first, double _second, double _third)
    {
        double adding_2 = _first + _second + _third;
        Debug.Log("adding7 = " + adding_2);
        return adding_2;
    }
    public string addition_str(float _first,float _second,float _third)
    {
        float adding_2 = _first + _second + _third;
        Debug.Log("adding8 = " + adding_2);
        return adding_2.ToString();
    }
}
