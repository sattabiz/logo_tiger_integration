
using System.Data.SqlClient;


namespace SattaTigerTS.Core
{
    public class DataBaseLogicLayer:BaseClass
    {
        SqlConnection _connection;
        SqlCommand cmd;
        SqlDataReader reader;

        public DataBaseLogicLayer()
        {
            _connection = new SqlConnection("data source=server; initial catalog = database; user Id = user; password = password");    
        }

        public void BaglantiIslemleri()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
            else
            {
                _connection.Open();
            }
        }
        public SqlDataReader GetItemReader()
        {
            BaglantiIslemleri();
            cmd = new SqlCommand("Select * from ST_ITEMS_TO_DEMAND", _connection);
            reader = cmd.ExecuteReader();
            return reader;
        }

        public SqlDataReader GetItemReader2()
        {
            BaglantiIslemleri();
            cmd = new SqlCommand("Select * from ST_ITEMS_TO_DEMAND", _connection);
            reader = cmd.ExecuteReader();
            return reader;
        }

        public SqlDataReader BestOfSupplierReader()
        {

            TryCatchKullan(() =>
            {
                BaglantiIslemleri();
                cmd = new SqlCommand("SELECT * FROM ST_BEST_OF_SUPPLIER", _connection);
                reader = cmd.ExecuteReader();
            });
            return reader;
            _connection.Close();
        }

        public SqlDataReader BestOfItemReader()
        {

            TryCatchKullan(() =>
            {
                BaglantiIslemleri();
                cmd = new SqlCommand("SELECT * FROM ST_BEST_OF_ITEM", _connection);
                reader = cmd.ExecuteReader();
            });
            return reader;
            _connection.Close();
        }


        public SqlDataReader UnitList(int ItemRef)
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("Select * from ST_ITEMS_TO_DEMAND where ItemRef="+ItemRef, _connection);
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader UnitSetList(int ItemRef)
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("Select * from ST_ITEMS_TO_SET where ItemRef="+ItemRef, _connection);
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader CurrencyTable(object DATE_)
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("select * from LG_EXCHANGE_120 where DATE_=" + DATE_, _connection);
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
    }
}
