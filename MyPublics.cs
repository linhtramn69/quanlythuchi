using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1910468_ChuDe10
{
    class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMaCV, strMaNV, strSTTPhieu, strMaLyDo, strQuyenSD;

        public static void ConnectDatabase()
        {
            string strCon = "Server = localhost; Database = QL_ThuChi; Integrated Security = false; UID = TN207User; PWD = TN207User";
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strCon;
            try
            {
                conMyConnection.Open();
            }
            catch (Exception)
            {
            }
        }

        public static string MaHoaPassword(string strPass)
        {
            string strTemp1, strTemp2;
            int i, n;
            strTemp1 = "";
            strTemp2 = "";
            n = strPass.Length;

            for (i = 0; i < n; i = i + 2)
            {
                strTemp1 += strPass[i];
                if (n > i + 1)
                    strTemp2 += strPass[i + 1];
            }
            return (strTemp1 + strTemp2);
        }

        public static bool TonTaiKhoaChinh(string strGiaTri, string strTruong, string strTable)
        {
            bool blnResult = false;
            SqlCommand cmdCommand;
            SqlDataReader drReader;

            try
            {
                string SqlSelect = "select 1 from " + strTable + " where " + strTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                cmdCommand = new SqlCommand(SqlSelect, conMyConnection);
                drReader = cmdCommand.ExecuteReader();
                if (drReader.HasRows)
                    blnResult = true;
                drReader.Close();
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }

            return blnResult;
        }

        public static void GetData(string strSelect, DataSet dsDatabase, string strTableName)
        {
            SqlDataAdapter daDataAdapter;
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter = new SqlDataAdapter(strSelect, conMyConnection);
                daDataAdapter.Fill(dsDatabase, strTableName);
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
