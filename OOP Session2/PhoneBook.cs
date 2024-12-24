using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Session2
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        long[] numbers;
        int size;

        #endregion

        #region Propety
        public int Size //read only property
        {
            get { return size; }
        }
        #endregion

        #region constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        #region Methods
        //object Member Method
        public void AddPerson(int Position, string Name, long Number)
        {
            if (names is not null && numbers is not null)
            {
                if (Position >= 0 && Position < size)
                {
                    names[Position] = Name;
                    numbers[Position] = Number;
                }
            }
        }
        #endregion

        #region Encapsulation
        #region Getter / Setter
        // Getter 
        public long GetNumber (string Name)
        {
            if (names != null && numbers != null)
            {
                for (int i = 0; i<names.Length;i++)
                {
                    if (Name == names[i])
                        return numbers[i];
                }
            }
            return -1;
        }
        //Setter
        public void SetNumber(string Name,long Number)
        {
            if (names != null && numbers != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                        numbers[i] = Number;
                }
            }
        }
        #endregion
        #region indexer
        // indexer is Special property
        // 1- Named Alwayes With KeyWord This 
        // 2- Can Take Parameters
        // 
        public long this[string Name]
        {
            get
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            return numbers[i];
                    }
                }
                return -1;
            }
            set 
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            numbers[i] = value;
                    }
                }
            }
        }
        #endregion
        #endregion
        //public override string ToString()
        //{
        //    return "";
        //}

    }
}
