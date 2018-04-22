using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP03UnitTesting
{
    class PenManagementController
    {
        public PenManagementController() { }

        public string addPen(string animalName, string penID)
        {
            Console.WriteLine("string addPen(string animalName, string penID)");
            Pen newPen = new Pen(animalName, penID);
            bool exists = Program.SomeGlobalVariables.DBM.penExists(penID);
            if (exists)
            {
                return "Pen already exists in the Database.";
            }
            else
            {
                bool success = Program.SomeGlobalVariables.DBM.addPen(newPen);
                if (success)
                {
                    return "Pen successfully added.";
                }
                else
                {
                    return "Error adding the Pen.";
                }
            }
        }

        public string editPen(string penID)
        {
            Console.WriteLine("string editPen(string penID)");
            Pen newPen = Program.SomeGlobalVariables.DBM.editPen(penID);
            if (newPen == null)
            {
                return "Pen does not exist.";
            }
            else
            {
                return newPen.toString();
            }

        }

        public string updatePen(string newAnimalName, string penID)
        {
            Console.WriteLine("string updatePen(string newAnimalName, string penID)");
            Pen newPen = Program.SomeGlobalVariables.DBM.editPen(penID);
            newPen.update(penID);
            bool success = Program.SomeGlobalVariables.DBM.updatePen(newPen);
            if (success)
            {
                return "Successfully edited pen.";
            }
            else
            {
                return "Error updating the Database.";
            }
        }

        public string searchPen(string penID)
        {
            Console.WriteLine("string searchPen(string penID)");
            Pen newPen = Program.SomeGlobalVariables.DBM.searchPen(penID);
            if (newPen != null)
            {
                return newPen.toString();
            }
            else
            {
                return "There is no Pen with that ID.";
            }
        }
    }
}
