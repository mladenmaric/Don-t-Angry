using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontAngry.Engines
{
    public enum FieldType
    {
        GreenHomeStart, 
        GreenHomeEnd,
        GreenStart,
        GreenEnd,

        RedHomeStart,
        RedHomeEnd,
        RedStart,
        RedEnd,

        BlueHomeStart,
        BlueHomeEnd,
        BlueStart,
        BlueEnd,

        YellowHomeStart,
        YellowHomeEnd,
        YellowStart,
        YellowEnd,

        Ordinary
    }

    public class Field
    {
        public FieldType TypeOfField { get; set; }
        public Player PlayerAtField { get; set; }
        
        public Field(FieldType _typeOfField)
        {
            TypeOfField = _typeOfField;
        }
    }

    public class FieldListElement
    {
        public Field CurrentField { set; get; }
        public FieldListElement Next { set; get; }
        public FieldListElement NextHomeEnd { set; get; }

        public FieldListElement(Field _currentField)
        {
            CurrentField = _currentField;
        }   

        public void AddHomeEndElement(FieldListElement _nextHomeEnd)
        {
            FieldListElement curr = NextHomeEnd;

            if (curr == null)
                NextHomeEnd = _nextHomeEnd;
            else
            {
                while (curr.NextHomeEnd != null)
                    curr = curr.NextHomeEnd;

                curr.NextHomeEnd = _nextHomeEnd;
            }
        }
    }

    public class FieldList
    {
        public FieldListElement Head { set; get; }        

        public void AddElement(FieldListElement element)
        {
            FieldListElement currElement = Head;

            if (currElement == null)
                Head = element;
            else
            {
                while (currElement.Next != null)
                    currElement = currElement.Next;

                currElement.Next = element;
            }
        }

        public FieldListElement FindListElement(FieldType _ft)
        {
            FieldListElement f = Head;

            do
            {
                if (f.CurrentField.TypeOfField == _ft)
                    return f;

                f = f.Next;
            }
            while (f != Head);

            return null;
        }

    }
}
