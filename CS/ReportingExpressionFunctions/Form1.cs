using DevExpress.XtraReports.UI;
namespace ReportingExpressionFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Report1 report = new Report1();
            report.ShowRibbonPreviewDialog();
           
        }
    }
}