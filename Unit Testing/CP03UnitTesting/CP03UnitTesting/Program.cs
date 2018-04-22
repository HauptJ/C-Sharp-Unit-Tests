using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP03UnitTesting
{
    class Program
    {
        public class SomeGlobalVariables
        {
            public static DBMgr DBM = new DBMgr();

        }

        static void Main(string[] args)
        {
            //-------BEGIN tests for pen class - Pen.cs -------//
            
            //NORMAL CONDITIONS - good input
            string testNameGood = "test123";
            string testIDGood = "123";
            //update
            string testNameUpdateGood = "testUpdate123";
            string testIDUpdateGood = "456";

            //BAD CONDITIONS - bad input
            //bad input works since input checking has not been implemented
            string testNameBad = "=-!~afhdalkhfdal vjdfadfj valdksfhalkdfv adfvh adslfv aldkv adlv asdav dsfalkdfhadklfhv kldfv ladsfjafd";
            string testIDBad = "ajfdahfda;fafalfkdjafdhafdhjakl;fdjhafdjhaklsfdjaskl;fdjakldjaskl;dfjaskl;dfajkl;hdv;ajdfl;ahfdl;jhafdkla";
            //update
            string testNameUpdateBad = "ERROR ERROR ERROR ERROR ERROR ERROR ERROR ERROR";
            string testIDUpdateBad = "CRASH";

            //BAD CONDTIONS - empty input
            //bad input works since input checking has not been implemented
            string testNameEmpty = "";
            string testIDEmpty = "";

            
            //test constructor
            Console.WriteLine("testing Pen() constructor");
            Pen testPenGood = new Pen(testNameGood, testIDGood); //pass
            Pen testPenBad = new Pen(testNameBad, testIDBad); //pass
            Pen testPenEmpty = new Pen(testNameEmpty, testIDEmpty); //pass

            //test update function
            Console.WriteLine("testing update()");
            testPenGood.update(testNameUpdateGood); //pass :)
            testPenBad.update(testNameUpdateBad); //pass :)

            //test Pen toString - PASS
            Console.WriteLine("testing Pen.cs toSting()");
            testPenBad.toString(); //pass
            testPenEmpty.toString(); //pass
            Console.WriteLine(testPenGood.toString()); //pass
            Console.WriteLine(testPenBad.toString()); //pass
            Console.WriteLine(testPenEmpty.toString()); //pass
            
            //-------END tests for pen class - Pen.cs -------//

            //-------BEGIN tests for penManagementController - PenManagementController.cs -------//

            PenManagementController testControllerGood;
            testControllerGood = new PenManagementController();

            PenManagementController testControllerBad;
            testControllerBad = new PenManagementController();

            PenManagementController testControllerEmpty;
            testControllerEmpty = new PenManagementController();


            //addPen()
            testControllerGood.addPen(testNameGood, testIDGood); //pass
            testControllerBad.addPen(testNameBad, testIDBad); //pass
            testControllerEmpty.addPen(testNameEmpty, testIDEmpty); //pass

            //editPen()
            //as long as good input works for a penID, editPen() should be ok
            testControllerGood.editPen(testIDGood); //pass
            testControllerBad.editPen(testIDBad); //pass
            testControllerEmpty.editPen(testIDEmpty); //pass

            //updatePen()
            //as long as good input works for a penID, editPen() should be ok
            testControllerGood.updatePen(testNameUpdateGood, testIDUpdateGood); //pass
            testControllerBad.addPen(testNameUpdateBad, testIDUpdateBad); //pass
            testControllerEmpty.updatePen(testNameEmpty, testIDEmpty); //pass

            //searchPen()           
            //as long as good input works for a penID, searchPen() should be ok
            testControllerGood.searchPen(testIDGood); //does not work
            testControllerBad.searchPen(testIDBad); //does not work
            testControllerEmpty.searchPen(testIDEmpty); //does not work



            //-------END tests for penManagementController - PenManagementController.cs -------//

            Console.Read(); //Keep console open

        }
    }
}
