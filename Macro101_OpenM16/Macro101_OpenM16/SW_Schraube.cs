using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Macro101_OpenM16
{
    internal class SW_Schraube
    {
        
        public static void OpenModel()
        {
        SldWorks swApp = new SldWorks();
        ModelDoc2 swModel;
        int errors = 0;
        int warnings = 0;
        string filepath = "C:\\Kuhne Group\\Sandkasten\\Krahn\\Macro´s SW\\OpenDIN934_M16\\DIN934_M16_Daten\\DIN934+Normteile_M16x25.SLDASM";
        swModel = (ModelDoc2)swApp.ActivateDoc3("DIN934+Normteile_M16x25.SLDASM", false, 1, 0);

        if (swModel == null)
            {
                swModel = (ModelDoc2)swApp.OpenDoc6(filepath, 2, 2, "", ref errors, ref warnings);
            }
        
         swApp.ActivateDoc3("DIN934+Normteile_M16.SLDASM", false, 1, ref errors);
        }
        public static void CloseModel()
        {
            // schliesse das Model
        }
        public static void changeAndRebuild(int Klemmung, string SchraubenFile)
        {
            SldWorks swApp = new SldWorks();
            ModelDoc2 swModel;
            AssemblyDoc swAssy;
            Dimension myDimension;
            bool boolstatus;
            swModel = (ModelDoc2)swApp.ActiveDoc;
            //select Schraube
            swModel.Extension.SelectByID2("", "COMPONENT", 0, 0, 0, false, 0, null, 0);
            swAssy = (AssemblyDoc)swModel;
            //ersetze Schraube
            boolstatus = swAssy.ReplaceComponents2(SchraubenFile, "", true, 0, true);
            //select Features für Abstand
            swModel.Extension.SelectByID2("Abstand1", "MATE",0,0,0,false,0,null,0);
            swModel.ActivateSelectedFeature();
            swModel.Extension.SelectByID2("D1@Abstand1@DIN934+Normteile_M16x25.SLDASM","DIMENSION",0,0,0,false,0, null, 0);
            myDimension = (Dimension)swModel.Parameter("D1@Abstand1");
            //Ändere den Abstand
            myDimension.SystemValue = Klemmung * 0.001;
            swModel.ClearSelection2(true);
            // Neuaufbau
            swModel.ForceRebuild3(true);
        }
    }
}
