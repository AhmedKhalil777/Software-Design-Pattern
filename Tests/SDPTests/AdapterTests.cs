using System.Data.OleDb;

namespace SDPTests;

public class AdapterTests
{
    public const string Connection = "Provider=SQLOLEDB.1;Data Source=.;Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=AdapterDB;Initial File Name=\"D:\\Projects\\Software-Design-Pattern\\8. The Adapter Pattern __ Structural\\Adapter\\AdapterDb.mdf\"";
    [Fact]
    public void RenderShouldRender3Lines()
    {
        var renderer = new DataRenderer(new StubDataAdapter());
        var writer = new StringWriter();
         renderer.Render(writer);
        var res = writer.ToString();
        Assert.Equal(3, res.Count(x => x == '\n'));
    }

    [Fact]
    public void RenderForOledbProviderOnDatabaseWith2RowsShouldPrintTheRowsAsExpected()
    {
        var adapter = new OleDbDataAdapter();
        adapter.SelectCommand = new OleDbCommand("Select * from StubTable");
        adapter.SelectCommand.Connection = new OleDbConnection(Connection);
        var writer = new StringWriter();
        var renderer = new DataRenderer(adapter);
        renderer.Render(writer);
        var res = writer.ToString();
        Assert.Equal(4, res.Count(x => x == '\n'));

    }
}
