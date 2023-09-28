using System.Data;
using System.Data.SqlClient;

namespace SattaTigerTS.Core
{
    public class BusinessLogicLayer:BaseClass
    {
        DataBaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new DataBaseLogicLayer();
        }

        public DataTable GetItemTable()
        {
            SqlDataReader reader = DLL.GetItemReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            
            reader.Close();
            dt.Columns.Add("SelectedItem", typeof(bool));
            return dt;
        }

        public DataTable GetItemTable2()
        {
            SqlDataReader reader = DLL.GetItemReader2();
            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();
            return dt;
        }

        public DataTable GetCurrencyTable(object DATE_)
        {
            SqlDataReader reader = DLL.CurrencyTable(DATE_);
            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();
            return dt;
        }

        public DataTable GetBestOfSupplier()
        {
            SqlDataReader reader = DLL.BestOfSupplierReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();
            return dt;
        }

        public DataTable GetBestOfItem()
        {
            SqlDataReader reader = DLL.BestOfItemReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();
            return dt;
        }
    }
}
