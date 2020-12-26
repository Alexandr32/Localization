using System;
using System.Collections.Generic;
using System.Text;

namespace Localization
{
    public class LocalizableStrings
    {

        public string meal1_name { get; set; }
        public string meal2_name { get; set; }
        public string meal3_name { get; set; }
        public string meal4_name { get; set; }
        public string meal5_name { get; set; }

        public string meal_status_next { get; set; }
        public string meal_status_missed { get; set; }
        public string meal_status_vin { get; set; }

        public string delete_record { get; set; }

        public string description { get; set; }

        public string cancel { get; set; }
        public string add { get; set; }
        public string edit { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public string meal_win { get; set; }


        public override string ToString()
        {
            return $@"""{nameof(meal1_name)}"" = ""{meal1_name}"";
""{nameof(meal2_name)}"" = ""{meal2_name}"";
""{nameof(meal3_name)}"" = ""{meal3_name}"";
""{nameof(meal4_name)}"" = ""{meal4_name}"";
""{nameof(meal5_name)}"" = ""{meal5_name}"";

""{nameof(meal_status_next)}"" = ""{meal_status_next}"";
""{nameof(meal_status_missed)}"" = ""{meal_status_missed}"";
""{nameof(meal_status_vin)}"" = ""{meal_status_vin}"";

""{nameof(delete_record)}"" = ""{delete_record}"";

""{nameof(description)}"" = ""{description}"";

""{nameof(cancel)}"" = ""{cancel}"";
""{nameof(add)}"" = ""{add}"";
""{nameof(edit)}"" = ""{edit}"";
""{nameof(name)}"" = ""{name}"";
""{nameof(time)}"" = ""{time}"";
""{nameof(meal_win)}"" = ""{meal_win}"";";
        }
    }
}
