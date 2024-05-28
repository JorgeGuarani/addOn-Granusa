using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using BOTONSAP;

namespace BOTONSAP
{
    [FormAttribute("UDO_FT_ANULAR")]
    class UDOForm1 : UDOFormBase
    {
        public UDOForm1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            // this.oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.ActiveForm;
            // this.btnAnular = ((SAPbouiCOM.Button)(this.GetItem("Item_0").Specific));
            // this.btnAnular.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.btnAnular_ClickBefore);
            // this.txtfact1 = ((SAPbouiCOM.EditText)(this.GetItem("0_U_E").Specific));
            // this.txtMotivo = ((SAPbouiCOM.EditText)(this.GetItem("1_U_E").Specific));
            // this.btncancelar = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            // this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            // this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            // this.btncancelar.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button1_ClickBefore);
            // this.btncancelar.Item.Visible = false;
            // this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            // this.cboDocu = ((SAPbouiCOM.ComboBox)(this.GetItem("cboDocu").Specific));
            // this.txtfact2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            // this.txtfact3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_4").Specific));
            // this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_5").Specific));
            // this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_6").Specific));
            // this.cboMoti = ((SAPbouiCOM.ComboBox)(this.GetItem("cboMoti").Specific));
            // this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            // this.txtMotivo.Item.Visible = false;
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

       

        private void OnCustomInitialize()
        {
            
        }

        private void btnAnular_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
            //instnciamos las variables
            //string doc = txtDocumento.Value;
            //string moti = txtMotivo.Value;
            ////instanciamos el servicio
            //servicio.FacturacionElectronicaClient cliente = new servicio.FacturacionElectronicaClient();
            //servicio.anularRequest anular = new servicio.anularRequest();
            //servicio.anularResponse response = new servicio.anularResponse();

            ////realizamos el query para traer el CDC correspondiente
            //SAPbobsCOM.Recordset query;
            //query = (SAPbobsCOM.Recordset)BOTONSAP.Program.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            //query.DoQuery("SELECT \"U_CDC\",\"DocEntry\" FROM OINV WHERE \"DocNum\"='"+doc+"'");
            ////consultamos si existe el numero de documento
            //if(query.BoF)
            //{
            //    BOTONSAP.Program.SBO_Application.SetStatusBarMessage("No existe el Documento", SAPbouiCOM.BoMessageTime.bmt_Short, true);
            //}
            ////enviamos las variables al servicio
            //anular.cdc = query.Fields.Item(0).Value.ToString();
            //anular.motivo = moti;
            ////ejecutamos el servicio
            //response = cliente.anular(anular);
            //string resp = response.ok.ToString();

            //if(resp.Equals("true"))
            //{
            //    //instanciamos el objeto
            //    SAPbobsCOM.Documents factura;
            //    SAPbobsCOM.Documents factCancel;
            //    factura = (SAPbobsCOM.Documents)BOTONSAP.Program.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices);
            //    factCancel = (SAPbobsCOM.Documents)BOTONSAP.Program.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices);

            //    if(factura.GetByKey(int.Parse(query.Fields.Item(1).Value.ToString())))
            //    {
            //        factCancel = factura.CreateCancellationDocument();
            //        int cancelado = factCancel.Add();
            //        if(cancelado==0)
            //        {

            //        }
            //        else
            //        {

            //        }
            //    }

            //}
            //else
            //{
                
            //}





        }

        #region Variables
        private SAPbouiCOM.Button btnAnular;
        private SAPbouiCOM.EditText txtfact1;
        private SAPbouiCOM.EditText txtMotivo;
        private SAPbouiCOM.Form oForm;
        #endregion

        private SAPbouiCOM.Button btncancelar;
        private SAPbouiCOM.Button Button0;

        private void Button1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();

        }

        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
            if(""=="")
            {

            }
        }

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.ComboBox cboDocu;
        private SAPbouiCOM.EditText txtfact2;
        private SAPbouiCOM.EditText txtfact3;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.ComboBox cboMoti;
        private SAPbouiCOM.StaticText StaticText3;
    }
}
