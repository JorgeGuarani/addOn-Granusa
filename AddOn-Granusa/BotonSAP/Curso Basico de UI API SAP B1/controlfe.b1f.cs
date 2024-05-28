using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace BOTONSAP
{
    [FormAttribute("UDO_FT_AUDITORIAFE")]
    class controlfe : UDOFormBase
    {
        public controlfe()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_0").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_1").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_14").Specific));
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_17").Specific));
            this.PictureBox0 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_18").Specific));
            this.PictureBox1 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_20").Specific));
            this.PictureBox2 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_21").Specific));
            this.PictureBox3 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_22").Specific));
            this.PictureBox4 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_25").Specific));
            this.PictureBox8 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_29").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_16").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_19").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_23").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_24").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_30").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_31").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_15").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_26").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_27").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_28").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_32").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_33").Specific));
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_35").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_36").Specific));
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_37").Specific));
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("Item_38").Specific));
            this.Button5 = ((SAPbouiCOM.Button)(this.GetItem("Item_39").Specific));
            this.CheckBox0 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_34").Specific));
            this.CheckBox1 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_40").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Button Button0;

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder2;
        private SAPbouiCOM.PictureBox PictureBox0;
        private SAPbouiCOM.PictureBox PictureBox1;
        private SAPbouiCOM.PictureBox PictureBox2;
        private SAPbouiCOM.PictureBox PictureBox3;
        private SAPbouiCOM.PictureBox PictureBox4;
        private SAPbouiCOM.PictureBox PictureBox8;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.StaticText StaticText9;
        private SAPbouiCOM.StaticText StaticText10;
        private SAPbouiCOM.StaticText StaticText11;
        private SAPbouiCOM.StaticText StaticText12;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.Button Button4;
        private SAPbouiCOM.Button Button5;
        private SAPbouiCOM.CheckBox CheckBox0;
        private SAPbouiCOM.CheckBox CheckBox1;
    }
}
