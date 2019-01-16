using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BI_allSariRoti
{
    class DB_insertion_BiallSariroti
    {
        SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
        internal void insert_Jabodetabek_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string B37a1, string B37a2, string B37a3, string B37a4, string B37a5, string B37a6, string B37a7, string B37a8, string B37a9, string B37a10, string B37a11, string B37a12, string B37a13, string B37a14, string B37a15, string B37a16, string B37a17, string B37a18, string B37a19, string B37a20, string B37a21, string B37a22, string B37a23)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_BI_Jabodetabek_temp (UserID,SurveyID,AttendedOn,weight,Country,B37a1,B37a2,B37a3,B37a4,B37a5,B37a6,B37a7,B37a8,B37a9,B37a10,B37a11,B37a12,B37a13,B37a14,B37a15,B37a16,B37a17,B37a18,B37a19,B37a20,B37a21,B37a22,B37a23) " + "VALUES('" + userID + "','" + SurveyID + "','" + AttendedOn + "','" + Weight + "','" + country + "','" + B37a1 + "','" + B37a2 + "','" + B37a3 + "','" + B37a4 + "','" + B37a5 + "','" + B37a6 + "','" + B37a7 + "','" + B37a8 + "','" + B37a9 + "','" + B37a10 + "','" + B37a11 + "','" + B37a12 + "','" + B37a13 + "','" + B37a14 + "','" + B37a15 + "','" + B37a16 + "','" + B37a17 + "','" + B37a18 + "','" + B37a19 + "','" + B37a20 + "','" + B37a21 + "','" + B37a22 + "','" + B37a23 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        internal void insert_Dashboard_variable_values(string VARIABLE_NAME, string VARIABLE_NAME_SUB_NAME, string VARIABLE_ID, string VARIABLE_VALUE, string VARIABLE_NAME_QUESTION, int SurveyID, string country, string BASE_VARIABLE_NAME, string AttendedOn)
        {
            String VARIABLEVALUE = VARIABLE_VALUE.Replace("'", "");
            String VARIABLE_QUESTION = VARIABLE_NAME_QUESTION.Replace("'", "");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardSPS_Variable_Values (VARIABLE_NAME,VARIABLE_NAME_SUB_NAME,VARIABLE_ID,VARIABLE_VALUE,VARIABLE_NAME_QUESTION,SURVEY_ID,SURVEY_COUNTRY,BASE_VARIABLE_NAME,SURVEY_PERIOD) " + "VALUES('" + VARIABLE_NAME + "','" + VARIABLE_NAME_SUB_NAME + "','" + VARIABLE_ID + "','" + VARIABLEVALUE + "','" + VARIABLE_QUESTION + "','" + SurveyID + "','" + country + "','" + BASE_VARIABLE_NAME + "','" + AttendedOn + "')", connection);
            try
            {


                cmd.ExecuteNonQuery();
                Console.WriteLine("Dashboard variable values inserted successfully");

                connection.Close();



            }
            catch (Exception)
            {

                Console.WriteLine("Exception occured");
                Console.ReadLine();
            }
        }

        internal void insert_BISurabaya_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string B37b1, string B37b2, string B37b3, string B37b4, string B37b5, string B37b6, string B37b7, string B37b8, string B37b9, string B37b10, string B37b11, string B37b12, string B37b13, string B37b14, string B37b15, string B37b16, string B37b17, string B37b18, string B37b19, string B37b20, string B37b21, string B37b22, string B37b23)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_BI_Surabaya_temp (UserID,SurveyID,AttendedOn,weight,Country,B37b1,B37b2,B37b3,B37b4,B37b5,B37b6,B37b7,B37b8,B37b9,B37b10,B37b11,B37b12,B37b13,B37b14,B37b15,B37b16,B37b17,B37b18,B37b19,B37b20,B37b21,B37b22,B37b23) " + "VALUES('" + userID + "','" + SurveyID + "','" + AttendedOn + "','" + Weight + "','" + country + "','" + B37b1 + "','" + B37b2 + "','" + B37b3 + "','" + B37b4 + "','" + B37b5 + "','" + B37b6 + "','" + B37b7 + "','" + B37b8 + "','" + B37b9 + "','" + B37b10 + "','" + B37b11 + "','" + B37b12 + "','" + B37b13 + "','" + B37b14 + "','" + B37b15 + "','" + B37b16 + "','" + B37b17 + "','" + B37b18 + "','" + B37b19 + "','" + B37b20 + "','" + B37b21 + "','" + B37b22 + "','" + B37b23 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        internal void insert_BIBandung_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string B37c1, string B37c2, string B37c3, string B37c4, string B37c5, string B37c6, string B37c7, string B37c8, string B37c9, string B37c10, string B37c11, string B37c12, string B37c13, string B37c14, string B37c15, string B37c16, string B37c17, string B37c18, string B37c19, string B37c20, string B37c21, string B37c22, string B37c23)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_BI_Bandung_temp (UserID,SurveyID,AttendedOn,weight,Country,B37c1,B37c2,B37c3,B37c4,B37c5,B37c6,B37c7,B37c8,B37c9,B37c10,B37c11,B37c12,B37c13,B37c14,B37c15,B37c16,B37c17,B37c18,B37c19,B37c20,B37c21,B37c22,B37c23) " + "VALUES('" + userID + "','" + SurveyID + "','" + AttendedOn + "','" + Weight + "','" + country + "','" + B37c1 + "','" + B37c2 + "','" + B37c3 + "','" + B37c4 + "','" + B37c5 + "','" + B37c6 + "','" + B37c7 + "','" + B37c8 + "','" + B37c9 + "','" + B37c10 + "','" + B37c11 + "','" + B37c12 + "','" + B37c13 + "','" + B37c14 + "','" + B37c15 + "','" + B37c16 + "','" + B37c17 + "','" + B37c18 + "','" + B37c19 + "','" + B37c20 + "','" + B37c21 + "','" + B37c22 + "','" + B37c23 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }
    }
}
