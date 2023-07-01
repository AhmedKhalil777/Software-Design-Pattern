using System.Data;

public class DataRenderer
{
    private readonly IDbDataAdapter _dataAdapter;

    public DataRenderer(IDbDataAdapter dataAdapter)
    {
        _dataAdapter = dataAdapter;
    }


    public void Render(TextWriter writer)
    {
        writer.WriteLine("Rendering Data : ");
        var dataSet = new DataSet();

        _dataAdapter.Fill(dataSet);

        foreach (DataTable table in dataSet.Tables) {
            foreach (DataColumn col in table.Columns)
            {
                writer.Write(col.ColumnName.PadRight(20) + " ");
            }
            writer.WriteLine();
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    writer.Write(row[i]?.ToString()?.PadRight(20) + " ");

                }
                writer.WriteLine();
            }
        }
    }
}


public class StubDataAdapter : IDbDataAdapter
{
    public IDbCommand? DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public IDbCommand? InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public IDbCommand? SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public IDbCommand? UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public ITableMappingCollection TableMappings => throw new NotImplementedException();

    public int Fill(DataSet dataSet)
    {
        var dataTable = new DataTable();
        dataTable.Columns.Add(new DataColumn("ID" ,typeof(int)));
        dataTable.Columns.Add(new DataColumn("Name" ,typeof(string)));
        dataTable.Columns.Add(new DataColumn("Description" ,typeof(string)));

        var row = dataTable.NewRow();
        row[0] = 1;
        row[1] = "Adapter";
        row[2] = "Structural Design Pattern";
        dataTable.Rows.Add(row);
        dataSet.Tables.Add(dataTable);
        dataSet.AcceptChanges();

        return 1;
    }

    public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
    {
        throw new NotImplementedException();
    }

    public IDataParameter[] GetFillParameters()
    {
        throw new NotImplementedException();
    }

    public int Update(DataSet dataSet)
    {
        throw new NotImplementedException();
    }
}