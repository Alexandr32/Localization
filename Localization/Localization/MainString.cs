using System;
using System.Collections.Generic;
using System.Text;

namespace Localization
{
    class MainString
    {

        public string Name { get; set; }
        public string Reminder { get; set; }
        public string Description { get; set; }
        public string ThankYou { get; set; }
        public string Done { get; set; }
        public string BonAppetit { get; set; }
        public string Time { get; set; }
        public string Missed { get; set; }

        public void SetAtribute(string kay,string atribute)
        {
            switch (kay)
            {
                case "meal_status_missed":
                    Missed = atribute;
                    break;
                case "time":
                    Time = atribute;
                    break;
                case "appetit":
                    BonAppetit = atribute;
                    break;
                case "meal_status_vin":
                    Done = atribute;
                    break;
                case "thank":
                    ThankYou = atribute;
                    break;
                case "description":
                    Description = atribute;
                    break;
                case "reminder":
                    Reminder = atribute;
                    break;
                case "name":
                    Name = atribute;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return $@"
/* Class = ""UIButton""; normalTitle = ""Description""; ObjectID = ""2c3-rc-hoo""; */
""2c3-rc-hoo.normalTitle"" = ""{Description}"";

/* Class = ""UILabel""; text = ""13:00""; ObjectID = ""4So-hf-ElH""; */
""4So-hf-ElH.text"" = ""13:00"";

/* Class = ""UILabel""; text = ""Name:""; ObjectID = ""5wI-kB-rc2""; */
""5wI-kB-rc2.text"" = ""{Name}:"";

/* Class = ""UILabel""; text = ""Reminder""; ObjectID = ""Geo-RL-ix6""; */
""Geo-RL-ix6.text"" = ""{Reminder}"";

/* Class = ""UILabel""; text = ""Второй ужин""; ObjectID = ""GxL-tf-qnf""; */
""GxL-tf-qnf.text"" = ""Второй ужин"";

/* Class = ""UILabel""; text = ""Description:""; ObjectID = ""JDI-NP-64p""; */
""JDI-NP-64p.text"" = ""{Description}:"";

/* Class = ""UIButton""; normalTitle = ""Thank you!""; ObjectID = ""Ktc-CG-7gx""; */
""Ktc-CG-7gx.normalTitle"" = ""{ThankYou}"";

/* Class = ""UILabel""; text = ""Done""; ObjectID = ""OdB-cz-iCw""; */
""OdB-cz-iCw.text"" = ""{Done}"";

/* Class = ""UIButton""; normalTitle = ""Description""; ObjectID = ""QZN-JU-9Qh""; */
""QZN-JU-9Qh.normalTitle"" = ""{Description}"";

/* Class = ""UINavigationController""; title = ""Master""; ObjectID = ""RMx-3f-FxP""; */
""RMx-3f-FxP.title"" = ""Master"";

/* Class = ""UILabel""; text = ""Name:""; ObjectID = ""VC2-Zp-CQ1""; */
""VC2-Zp-CQ1.text"" = ""{Name}:"";

/* Class = ""UILabel""; text = ""Bon Appetit!""; ObjectID = ""VfE-sq-5np""; */
""VfE-sq-5np.text"" = ""{BonAppetit}"";

/* Class = ""UILabel""; text = ""Time:""; ObjectID = ""aX6-Ql-InN""; */
""aX6-Ql-InN.text"" = ""{Time}:"";

/* Class = ""UIButton""; normalTitle = ""Ок""; ObjectID = ""cga-rE-iRT""; */
""cga-rE-iRT.normalTitle"" = ""Ок"";

/* Class = ""UIButton""; normalTitle = ""Time""; ObjectID = ""df2-5E-h8m""; */
""df2-5E-h8m.normalTitle"" = ""{Time}"";

/* Class = ""UIButton""; normalTitle = ""Name""; ObjectID = ""hPO-ut-UhJ""; */
""hPO-ut-UhJ.normalTitle"" = ""{Name}"";

/* Class = ""UILabel""; text = ""Bon Appetit!""; ObjectID = ""hms-EG-lmV""; */
""hms-EG-lmV.text"" = ""{BonAppetit}"";

/* Class = ""UILabel""; text = ""Второй ужин""; ObjectID = ""j49-o0-MVt""; */
""j49-o0-MVt.text"" = ""Второй ужин"";

/* Class = ""UILabel""; text = ""19:00""; ObjectID = ""kHH-Y9-hm5""; */
""kHH-Y9-hm5.text"" = ""19:00"";

/* Class = ""UILabel""; text = ""Time:""; ObjectID = ""lCu-R7-cUp""; */
""lCu-R7-cUp.text"" = ""{Time}:"";

/* Class = ""UIButton""; normalTitle = ""Name""; ObjectID = ""lT2-N2-YXX""; */
""lT2-N2-YXX.normalTitle"" = ""{Name}"";

/* Class = ""UIButton""; normalTitle = ""Time""; ObjectID = ""lsV-bQ-e3T""; */
""lsV-bQ-e3T.normalTitle"" = ""{Time}"";

/* Class = ""UILabel""; text = ""10:30""; ObjectID = ""reN-xV-FgR""; */
""reN-xV-FgR.text"" = ""10:30"";

/* Class = ""UILabel""; text = ""Missed!""; ObjectID = ""uRw-M0-Vp4""; */
""uRw-M0-Vp4.text"" = ""{Missed}"";

/* Class = ""UILabel""; text = ""Description:""; ObjectID = ""unI-ix-VWk""; */
""unI-ix-VWk.text"" = ""{Description}:"";

/* Class = ""UILabel""; text = ""Второй ужин""; ObjectID = ""wzG-gD-7vr""; */
""wzG-gD-7vr.text"" = ""Второй ужин"";
";
        }

    }
}
