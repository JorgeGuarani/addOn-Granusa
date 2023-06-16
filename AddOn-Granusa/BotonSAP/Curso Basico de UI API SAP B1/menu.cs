using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbouiCOM;
using Curso_Basico_de_UI_API_SAP_B1;
using System.Xml;

namespace Curso_Basico_de_UI_API_SAP_B1
{
    internal class menu
    {
        //public void AddMenuItems()
        //{
        //    BOTONSAP.Program.oCompany=(SAPbobsCOM.Company)BOTONSAP.Program.SBO_Application.Company.GetDICompany();
        //    //SBOConexion._SBO = (SAPbobsCOM.Company)SAPbouiCOM.Framework.Application.SBO_Application.Company.GetDICompany();
        //    SAPbouiCOM.Menus oMenus = null;
        //    SAPbouiCOM.MenuItem oMenuItem = null;

        //    oMenus = BOTONSAP.Program.SBO_Application.Menus;//Application.SBO_Application.Menus;

        //    SAPbouiCOM.MenuCreationParams oCreationPackage = null;
        //    oCreationPackage = ((SAPbouiCOM.MenuCreationParams)(BOTONSAP.Program.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)));
        //    oMenuItem = BOTONSAP.Program.SBO_Application.Menus.Item("43520"); // moudles'

        //    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP;
        //    oCreationPackage.UniqueID = "FE";
        //    oCreationPackage.String = "Facturacion Electronica";
        //    oCreationPackage.Enabled = true;
        //    oCreationPackage.Position = -1;

        //    oMenus = oMenuItem.SubMenus;

        //    try
        //    {
        //        //  If the manu already exists this code will fail
        //        oMenus.AddEx(oCreationPackage);
        //    }
        //    catch (Exception e)
        //    {
        //        BOTONSAP.Program.SBO_Application.SetStatusBarMessage("Menu Already Exists", SAPbouiCOM.BoMessageTime.bmt_Short, true);
        //    }
        //}
        public void AddMenus()
        {
            XmlDocument oXML;
            string sXML = "";

            // Get reference to the Main Menu form
            
            SAPbouiCOM.Form sboForm = BOTONSAP.Program.SBO_Application.Forms.GetFormByTypeAndCount(169, 1);

            // Freeze it
            sboForm.Freeze(true);

            try
            {
                // Load the menus to the SBO application in one batch
                oXML = new XmlDocument();
                oXML.Load(System.Environment.CurrentDirectory.ToString() + "\\Menus\\");

                sXML = oXML.InnerXml.ToString();
                BOTONSAP.Program.SBO_Application.LoadBatchActions(ref sXML);

            }
            finally
            {
                // Unfreeze and update the Main Menu form
                sboForm.Freeze(false);
                sboForm.Update();
            }
        }
    }
}
