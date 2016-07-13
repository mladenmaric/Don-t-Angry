using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontAngry.Engines
{
    public enum GameMode
    {
        DropCube,
        MovePlayer
    }

    public class Engine
    {
        FieldListElement greenListStart;
        FieldListElement redListStart;
        FieldListElement blueListStart;
        FieldListElement yellowListStart;

        FieldList mainList = new FieldList();

        public PlayerType CurrPlayer = PlayerType.Green;
        public GameMode CurrGameMode = GameMode.DropCube;


        public Engine()
        {
            InitializeLists();
        }


        public void InitializeLists()
        {
            FieldListElement[] greenBegin = new FieldListElement[11];

            greenBegin[0] = new FieldListElement(new Field(FieldType.GreenEnd));
            greenBegin[1] = new FieldListElement(new Field(FieldType.GreenStart));

            for (int i = 2; i < 11; i++)
                greenBegin[i] = new FieldListElement(new Field(FieldType.Ordinary));

            for (int i = 0; i < 4; i++)
                greenBegin[0].AddHomeEndElement(new FieldListElement(new Field(FieldType.GreenHomeEnd)));



            FieldListElement[] redBegin = new FieldListElement[11];

            redBegin[0] = new FieldListElement(new Field(FieldType.RedEnd));
            redBegin[1] = new FieldListElement(new Field(FieldType.RedStart));

            for (int i = 2; i < 11; i++)
                redBegin[i] = new FieldListElement(new Field(FieldType.Ordinary));

            for (int i = 0; i < 4; i++)
                redBegin[0].AddHomeEndElement(new FieldListElement(new Field(FieldType.RedHomeEnd)));


            FieldListElement[] blueBegin = new FieldListElement[11];

            blueBegin[0] = new FieldListElement(new Field(FieldType.BlueEnd));
            blueBegin[1] = new FieldListElement(new Field(FieldType.BlueStart));

            for (int i = 2; i < 11; i++)
                blueBegin[i] = new FieldListElement(new Field(FieldType.Ordinary));

            for (int i = 0; i < 4; i++)
                blueBegin[0].AddHomeEndElement(new FieldListElement(new Field(FieldType.BlueHomeEnd)));


            FieldListElement[] yellowBegin = new FieldListElement[11];

            yellowBegin[0] = new FieldListElement(new Field(FieldType.YellowEnd));
            yellowBegin[1] = new FieldListElement(new Field(FieldType.YellowStart));

            for (int i = 2; i < 11; i++)
                yellowBegin[i] = new FieldListElement(new Field(FieldType.Ordinary));

            for (int i = 0; i < 4; i++)
                yellowBegin[0].AddHomeEndElement(new FieldListElement(new Field(FieldType.YellowHomeEnd)));


            mainList.Head = greenBegin[1];
  
            FillLists(mainList, greenBegin, false);
            FillLists(mainList, redBegin, true);
            FillLists(mainList, blueBegin, true);
            FillLists(mainList, yellowBegin, true);

            mainList.AddElement(greenBegin[0]);
            greenBegin[0].Next = greenBegin[1]; // Make it circle list

            greenListStart = greenBegin[1];
            redListStart = redBegin[1];
            blueListStart = blueBegin[1];
            yellowListStart = yellowBegin[1];
        }

        private void FillLists(FieldList list, FieldListElement[] listElements, bool fromBegining)
        {
            int i = fromBegining ? 0 : 2;

            for (; i < listElements.Length; i++)
                list.AddElement(listElements[i]);
        }

        public int DropCube()
        {
            Random rand = new Random();

            return rand.Next(6) + 1;
        }

        public override string ToString()
        {
            string s = "";

            FieldListElement f = mainList.Head;

            do
            {
                s += f.CurrentField.TypeOfField.ToString() + " - " + 
                    (string)(f.CurrentField.PlayerAtField != null ? f.CurrentField.PlayerAtField.PlayerName.ToString() : "No player")
                    + "\n";
                f = f.Next;
            }
            while (f != mainList.Head);

            return s;
        }


    }
}
