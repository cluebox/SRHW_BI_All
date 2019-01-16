using SpssLib.DataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_allSariRoti
{
    public class BISurabaya
    {
        public void runBISurabaya()
        {
            var variablesmap = new Dictionary<string, string>();

            int SurveyID = 600617;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-09-30";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_BiallSariroti iobj = new DB_insertion_BiallSariroti();
            string questions = "id,weight,B37b1,B37b2,B37b3,B37b4,B37b5,B37b6,B37b7,B37b8,B37b9,B37b10,B37b11,B37b12,B37b13,B37b14,B37b15,B37b16,B37b17,B37b18,B37b19,B37b20,B37b21,B37b22,B37b23";// dashboard variable value   
            //string questions = "NETT_SR_User,NETT_Non_SR_User";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\SariRoriHW\BI\SR-HW_Surabaya-Sep18.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {
                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header
                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {
                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                                //iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SurveyID, country, BASE_VARIABLE_NAME, AttendedOn);
                            }
                        }

                    }
                }
                foreach (var record in spssDataset.Records)
                {
                    string variable_name;
                    string userID = null;
                    string u_id = null;
                    decimal Weight = 0;
                    string B37b1 = "-- Not Available --";
                    string B37b2 = "-- Not Available --";
                    string B37b3 = "-- Not Available --";
                    string B37b4 = "-- Not Available --";
                    string B37b5 = "-- Not Available --";
                    string B37b6 = "-- Not Available --";
                    string B37b7 = "-- Not Available --";
                    string B37b8 = "-- Not Available --";
                    string B37b9 = "-- Not Available --";
                    string B37b10 = "-- Not Available --";
                    string B37b11 = "-- Not Available --";
                    string B37b12 = "-- Not Available --";
                    string B37b13 = "-- Not Available --";
                    string B37b14 = "-- Not Available --";
                    string B37b15 = "-- Not Available --";
                    string B37b16 = "-- Not Available --";
                    string B37b17 = "-- Not Available --";
                    string B37b18 = "-- Not Available --";
                    string B37b19 = "-- Not Available --";
                    string B37b20 = "-- Not Available --";
                    string B37b21 = "-- Not Available --";
                    string B37b22 = "-- Not Available --";
                    string B37b23 = "-- Not Available --";

                    foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {
                                variable_name = variable.Name;

                                switch (variable_name)
                                {
                                    case "id":
                                        {
                                            u_id = Convert.ToString(record.GetValue(variable));
                                            userID = find_UserId(SurveyID, AttendedOn, u_id);
                                            break;
                                        }
                                    case "weight":
                                        {
                                            Weight = Convert.ToDecimal(record.GetValue(variable));
                                            break;
                                        }
                                    case "B37b1": { B37b1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b2": { B37b2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b3": { B37b3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b4": { B37b4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b5": { B37b5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b6": { B37b6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b7": { B37b7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b8": { B37b8 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b9": { B37b9 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b10": { B37b10 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b11": { B37b11 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b12": { B37b12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b13": { B37b13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b14": { B37b14 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b15": { B37b15 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b16": { B37b16 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b17": { B37b17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b18": { B37b18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b19": { B37b19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b20": { B37b20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b21": { B37b21 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b22": { B37b22 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37b23": { B37b23 = Convert.ToString(record.GetValue(variable)); break; }
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_BISurabaya_values(userID, SurveyID, AttendedOn, Weight, country, B37b1, B37b2, B37b3, B37b4, B37b5, B37b6, B37b7, B37b8, B37b9, B37b10, B37b11, B37b12, B37b13, B37b14, B37b15, B37b16, B37b17, B37b18, B37b19, B37b20, B37b21, B37b22, B37b23);
                    }


                }
            }
        }
        private static string find_UserId(int SurveyID, string SurveyPeriod, string u_id)
        {
            string sum = "";
            string[] date = SurveyPeriod.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return u_id + SurveyID + sum;
        }
    }
}
