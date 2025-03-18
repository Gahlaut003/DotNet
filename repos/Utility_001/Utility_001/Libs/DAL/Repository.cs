using Utility_001.Models;
using System;
using System.Data;

namespace Utility_001.Libs.DAL
{
    public abstract class Repository<TEntity> where TEntity : new()
    {
        AdoDBContext _context;

        public Repository(AdoDBContext context)
        {
            _context = context;
        }

        protected AdoDBContext Context
        {
            get
            {
                return this._context;
            }
        }
        protected int ExecuteNonQuery(IDbCommand command)
        {

            var record = command.ExecuteNonQuery();

            return record;

            //return -1;

        }
        protected object ExecuteScalar(IDbCommand command)
        {
            var retVal = command.ExecuteScalar();
            return retVal;
            //return -1;
        }
        protected string ExecuteScalarString(IDbCommand command)
        {
            var retVal = ExecuteScalar(command);
            if (retVal == null || retVal == DBNull.Value)
            {
                retVal = string.Empty;
            }
            string s = Convert.ToString(retVal);
            return s;
            //return -1;
        }
        protected DateTime ExecuteScalarDateTime(IDbCommand command)
        {
            var retVal = ExecuteScalar(command);
            if (retVal == null || retVal == DBNull.Value)
            {
                retVal = string.Empty;
            }
            string sDate = string.Format("{0}", retVal);
            DateTime dtDate;
            if (DateTime.TryParse(sDate.ToString(), out dtDate))
                return dtDate;

            return DateTime.MinValue;
            //return -1;
        }
        protected int ExecuteScalarInt(IDbCommand command)
        {
            var retVal = ExecuteScalar(command);
            if (retVal == null || retVal == DBNull.Value)
            {
                retVal = 0;
            }
            int val = Convert.ToInt32(retVal);
            return val;
            //return -1;
        }
        public DataSet ExecuteDataSet(IDbCommand command)
        {
            DataSet dataSet = new DataSet();
            IDataAdapter adapter = _context.GetDataAdapter(command);

            adapter.Fill(dataSet);

            return dataSet;
        }
        public DataTable ExecuteDataTable(IDbCommand command)
        {
            DataSet dataSet = new DataSet();
            IDataAdapter adapter = _context.GetDataAdapter(command);

            adapter.Fill(dataSet);

            return dataSet.Tables[0];
        }
/*        protected IEnumerable<TEntity> ToList(IDbCommand command)
        {
            using (var record = command.ExecuteReader())
            {
                List<TEntity> items = new List<TEntity>();
                while (record.Read())
                {

                    items.Add(Map<TEntity>(record));
                }
                return items;
            }
        }
*/
/*  protected TEntity ToObject(IDbCommand command)
        {
            using (var record = command.ExecuteReader())
            {
                TEntity item = default(TEntity);
                while (record.Read())
                {
                    item = Map<TEntity>(record);
                }
                return item;
            }
        }*/
/*        protected IEnumerable<TOEntity> ToObjectList<TOEntity>(IDbCommand command)
        {
            using (var record = command.ExecuteReader())
            {
                List<TOEntity> items = new List<TOEntity>();
                while (record.Read())
                {

                    items.Add(Map<TOEntity>(record));
                }
                return items;
            }
        }*/
      /*  protected virtual T Map<T>(IDataRecord record)
        {
            var objT = Activator.CreateInstance<T>();
            foreach (var property in typeof(T).GetProperties())
            {
                if (record.HasColumn(property.Name) && !record.IsDBNull(record.GetOrdinal(property.Name)))
                    if (record[property.Name] != null)
                    {
                        var typeDest = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                        property.SetValue(objT, Convert.ChangeType(record[property.Name], typeDest), null);
                    }
            }
            return objT;
        }*/

        //protected abstract TEntity Map<TEntity>(IDataRecord record);
    }
}

