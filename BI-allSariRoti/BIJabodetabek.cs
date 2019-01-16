using SpssLib.DataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_allSariRoti
{
   public  class BIJabodetabek
    {
        //static void Main(string[] args)
        public void runBIJabodetabek()
        {
            var variablesmap = new Dictionary<string, string>();

            int SurveyID = 600615;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-08-31";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_BiallSariroti iobj = new DB_insertion_BiallSariroti();
            string questions = "id,weight,B37a1,B37a2,B37a3,B37a4,B37a5,B37a6,B37a7,B37a8,B37a9,B37a10,B37a11,B37a12,B37a13,B37a14,B37a15,B37a16,B37a17,B37a18,B37a19,B37a20,B37a21,B37a22,B37a23";// dashboard variable value   
            //string questions = "NETT_SR_User,NETT_Non_SR_User";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\SariRoriHW\BI\SRHW_Jabodetabek.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
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
                    string B37a1 = "-- Not Available --";
                    string B37a2 = "-- Not Available --";
                    string B37a3 = "-- Not Available --";
                    string B37a4 = "-- Not Available --";
                    string B37a5 = "-- Not Available --";
                    string B37a6 = "-- Not Available --";
                    string B37a7 = "-- Not Available --";
                    string B37a8 = "-- Not Available --";
                    string B37a9 = "-- Not Available --";
                    string B37a10 = "-- Not Available --";
                    string B37a11 = "-- Not Available --";
                    string B37a12 = "-- Not Available --";
                    string B37a13 = "-- Not Available --";
                    string B37a14 = "-- Not Available --";
                    string B37a15 = "-- Not Available --";
                    string B37a16 = "-- Not Available --";
                    string B37a17 = "-- Not Available --";
                    string B37a18 = "-- Not Available --";
                    string B37a19 = "-- Not Available --";
                    string B37a20 = "-- Not Available --";
                    string B37a21 = "-- Not Available --";
                    string B37a22 = "-- Not Available --";
                    string B37a23 = "-- Not Available --";

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
                                    case "B37a1": { B37a1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a2": { B37a2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a3": { B37a3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a4": { B37a4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a5": { B37a5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a6": { B37a6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a7": { B37a7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a8": { B37a8 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a9": { B37a9 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a10": { B37a10 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a11": { B37a11 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a12": { B37a12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a13": { B37a13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a14": { B37a14 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a15": { B37a15 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a16": { B37a16 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a17": { B37a17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a18": { B37a18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a19": { B37a19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a20": { B37a20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a21": { B37a21 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a22": { B37a22 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B37a23": { B37a23 = Convert.ToString(record.GetValue(variable)); break; }
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0)
                    {
                        iobj.insert_Jabodetabek_values(userID, SurveyID, AttendedOn, Weight, country, B37a1, B37a2, B37a3, B37a4, B37a5, B37a6, B37a7, B37a8, B37a9, B37a10, B37a11, B37a12, B37a13, B37a14, B37a15, B37a16, B37a17, B37a18, B37a19, B37a20, B37a21, B37a22, B37a23);
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
