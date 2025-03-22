using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using essaiProjetExam;
using System;
using System.Windows.Forms;

namespace SystemeDeGestionDesEtudiants.View
{
    public partial class BulletinNote : Form
    {
        public BulletinNote(int etudiantId)
        {
            InitializeComponent();
            ChargerRapport(etudiantId);
        }

        private void ChargerRapport(int etudiantId)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\Users\\Hp\\source\\repos\\SystemeDeGestionDesEtudiants\\SystemeDeGestionDesEtudiants\\Rapport\\releveNote.rpt");

            ParameterFieldDefinitions parameterFieldDefinitions = reportDocument.DataDefinition.ParameterFields;
            ParameterFieldDefinition parameterFieldDefinition = parameterFieldDefinitions["EtudiantId"];
            ParameterValues parameterValues = new ParameterValues();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            parameterDiscreteValue.Value = etudiantId;
            parameterValues.Add(parameterDiscreteValue);
            parameterFieldDefinition.ApplyCurrentValues(parameterValues);

            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // BulletinNote
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "BulletinNote";
            this.Load += new System.EventHandler(this.BulletinNote_Load);
            this.ResumeLayout(false);
        }

        private void BulletinNote_Load(object sender, EventArgs e)
        {

        }
    }
}
