using Microsoft.Reporting.NETCore;
using System.Data;

namespace BlazorServerRdlcReport.Services;

public class EmployeeService
{
    public DataTable QryEmployeeList()
    {
        var dt = new DataTable();
        dt.Columns.Add("EmpId");
        dt.Columns.Add("EmpName");
        dt.Columns.Add("Department");
        dt.Columns.Add("Designation");
        dt.Columns.Add("JoinDate");

        DataRow dr;
        for (int i = 1; i <= 50; i++)
        {
            dr = dt.NewRow();
            dr["EmpId"] = $"{i}";
            dr["EmpName"] = $"John King-{i}";
            dr["Department"] = "Accounts";
            dr["Designation"] = "Sr. Officer";
            dr["JoinDate"] = $"{DateTime.Now.AddYears(-5).AddDays(i):yyyy/MM/dd}";
            dt.Rows.Add(dr);
        }

        return dt;
    }

    public byte[] MakeRdlcReport()
    {
        DataTable dt = QryEmployeeList();

        var path = new FileInfo("Reports\\EmployeeReport.rdlc");
        using Stream reportDefinition = path.OpenRead();

        LocalReport report = new LocalReport();
        report.LoadReportDefinition(reportDefinition);
        report.DataSources.Add(new ReportDataSource("dtEmployeeInfo", dt));
        report.SetParameters(new[] { new ReportParameter("param", "My Blazor RDLC Report YES") });
        byte[] pdf = report.Render("PDF");

        return pdf;
    }
}
