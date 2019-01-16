using SpssLib.DataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_allSariRoti
{
    class BIBandung
    {
        public void runBIBandung()
        {
            var variablesmap = new Dictionary<string, string>();

            int SurveyID = 600616;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-09-30";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_BiallSariroti iobj = new DB_insertion_BiallSariroti();
            string questions = "id,weight,B37c1,B37c2,B37c3,B37c4,B37c5,B37c6,B37c7,B37c8,B37c9,B37c10,B37c11,B37c12,B37c13,B37c14,B37c15,B37c16,B37c17,B37c18,B37c19,B37c20,B37c21,B37c22,B37c23";// dashboard variable value   
            //string questions = "NETT_SR_User,NETT_Non_SR_User";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\SariRoriHW\BI\SR-HW_Bandung-Sep18.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
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
                    string B37c1 = "-- Not Available --";
                    string B37c2 = "-- Not Available --";
                    string B37c3 = "-- Not Available --";
                    string B37c4 = "-- Not Available --";
                    string B37c5 = "-- Not Available --";
                    string B37c6 = "-- Not Available --";
                    string B37c7 = "-- Not Available --";
                    string B37c8 = "-- Not Available --";
                    string B37c9 = "-- Not Available --";
                    string B37c10 = "-- Not Available --";
                    string B37c11 = "-- Not Available --";
                    string B37c12 = "-- Not Available --";
                    string B37c13 = "-- Not Available --";
                    string B37c14 = "-- Not Available --";
                    string B37c15 = "-- Not Available --";
                    string B37c16 = "-- Not Available --";
                    string B37c17 = "-- Not Available --";
                    string B37c18 = "-- Not Available --";
                    string B37c19 = "-- Not Available --";
                    string B37c20 = "-- Not Available --";
                    string B37c21 = "-- Not Available --";
                    string B37c22 = "-- Not Available --";
                    string B37c23 = "-- Not Available --";

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
                                    case "B37c1": { B37c1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c2": { B37c2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c3": { B37c3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c4": { B37c4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c5": { B37c5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c6": { B37c6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c7": { B37c7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c8": { B37c8 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c9": { B37c9 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c10": { B37c10 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c11": { B37c11 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c12": { B37c12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c13": { B37c13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c14": { B37c14 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c15": { B37c15 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c16": { B37c16 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c17": { B37c17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c18": { B37c18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c19": { B37c19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c20": { B37c20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c21": { B37c21 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c22": { B37c22 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37c23": { B37c23 = Convert.ToString(record.GetValue(variable)); break; }
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_BIBandung_values(userID, SurveyID, AttendedOn, Weight, country, B37c1, B37c2, B37c3, B37c4, B37c5, B37c6, B37c7, B37c8, B37c9, B37c10, B37c11, B37c12, B37c13, B37c14, B37c15, B37c16, B37c17, B37c18, B37c19, B37c20, B37c21, B37c22, B37c23);
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
