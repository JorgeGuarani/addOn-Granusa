using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace BOTONSAP
{
    [FormAttribute("UDO_FT_REMI_TEMP")]
    class RTtemporal : UDOFormBase
    {
        public RTtemporal()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("2_U_G").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("33_U_S").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("33_U_E").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("35_U_S").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("35_U_E").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("36_U_S").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("36_U_E").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("38_U_S").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("38_U_E").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("40_U_S").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("40_U_Cb").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("41_U_S").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("41_U_Cb").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("42_U_S").Specific));
            this.ComboBox2 = ((SAPbouiCOM.ComboBox)(this.GetItem("42_U_Cb").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Matrix Matrix0;

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.ComboBox ComboBox2;
    }
}
