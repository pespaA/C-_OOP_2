using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session2
{
    internal class Car
    {
        #region propFull
        //private int id;

        //public int Id
        //{
        //	get { return id; }
        //	set { id = value; }
        //}

        //private string model;

        //public string Model
        //{
        //	get { return model; }
        //	set { model = value; }
        //}

        //private int speed;

        //public int Speed
        //{
        //	get { return speed; }
        //	set { speed = value; }
        //} 
        #endregion
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        // If No User Defined Constructor Exisets,
        // Compiler Will Alwayes Generate Empty Parametrless Constructor
        //public Car()
        //{

        //} // Do Nothing

        //-------------------
        // Constructor Chainning
        public Car(int _id, string _model, double _speed)
        {
            Console.WriteLine("Constructor 01");
            Id = _id;
            Model = _model;
            Speed = _speed;
        }
        public Car(int _id, string _model) : this(_id, _model, 200.1)
        {
            Console.WriteLine("Constructor 02");
            //Id = _id;
            //Model = _model;
            //Speed = 200.1;
        }
        public Car(int _id) : this(_id, "_moooodel", 200.1)
        {
            Console.WriteLine("Constructor 03");
            //Id = _id;
            //Model = _model;
            //Speed = 200.1;
        }

        public override string ToString()
        {
            return $"Id = {Id}\nModel is {Model}\nSpees is {Speed}";
        }



    }
}
